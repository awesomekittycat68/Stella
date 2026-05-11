using MongoDB.Driver;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Formats.Jpeg;
using SixLabors.ImageSharp.Formats.Png;
using SixLabors.ImageSharp.Processing;
using Stella.Models;
using System.Text.Json;

namespace Stella.Routes.API
{
    public class Images
    {
        [ServerAPI.GET("/api/images/v2/named")]
        public List<object> ReturnGetImagesNamed()
        {
            return [];
        }

        [ServerAPI.POST("/api/images/v4/uploadsaved")]
        [ServerAPI.UseAuthorization]
        public async Task<ImageNameDTO> ReturnUploadSaved(HttpContext ctx, MongoDB.User user)
        {
            SavedImageMetaDTO? imgMeta = JsonSerializer.Deserialize<SavedImageMetaDTO>(ctx.Request.Form["imgMeta"]!);
            string fileName = $"{imgMeta?.savedImageType}-{user.DisplayName!.ToPascalCase()}-{DateTime.UtcNow.Year}.{DateTime.UtcNow.Month}.{DateTime.UtcNow.Day}-{DateTime.UtcNow.Hour}.{DateTime.UtcNow.Minute}.{DateTime.UtcNow.Second}.jpg";
            IFormFile image = ctx.Request.Form.Files["image"]!;

            if (image == null || image.Length == 0)
                throw new Exception("No image uploaded, buddy.");
            if (image.ContentType != "image/jpeg")
                throw new Exception("Upload images that are only ingame buddy");
            if (image.FileName != "image.dat")
                throw new Exception("Upload images that are only ingame buddy");


            if (image != null && image.Length > 0)
            {
                string savePath = Path.Combine("Data", "Images", fileName);

                using FileStream stream = new(savePath, FileMode.Create);
                await image.CopyToAsync(stream);
            }

            if (imgMeta.roomId == 0 || imgMeta.roomId == -1)
            {
                imgMeta.roomId = user.OtherData.DormRoomId;
            }
            
            if (imgMeta?.savedImageType == SavedImageType.ShareCamera)
            {
                await Logs.SendWebhookAsync(
                    fileName, 
                    user.Username, 
                    MongoDB.roomsCollection.Find(u => u.Room.RoomId == user.OtherData.DormRoomId).FirstOrDefault().Room.Name
                );
            }

            return new ImageNameDTO
            {
                ImageName = fileName
            };
        }
        
        [ServerAPI.GET("/img/{imageName}")]
        public IResult GetImages(HttpContext ctx, string imageName)
        {
            string imagePath = Path.Combine("Data", "Images", imageName.EndsWith(".jpg") ? imageName : imageName + ".jpg");

            if (!File.Exists(imagePath))
                return Results.NotFound();

            byte[] imageBytes = File.ReadAllBytes(imagePath);

            bool Square = false;

            string? cropSquare = ctx.Request.Query["cropSquare"];

            if (!string.IsNullOrEmpty(cropSquare) && (cropSquare == "1" || cropSquare == "true"))
            {
                Square = true;
            }

            int width = 512;
            int height = 0;

            string? H = ctx.Request.Query["height"];
            string? W = ctx.Request.Query["width"];
            if (!string.IsNullOrEmpty(W) && W.All(char.IsDigit))
            {
                width = int.Parse(W);
                if (width == 256)
                {
                    width = 512;
                }
            }
            if (!string.IsNullOrEmpty(H) && H.All(char.IsDigit))
            {
                height = int.Parse(H);
            }

            using (Image I = Image.Load(imageBytes))
            {
                if (Square)
                {
                    Size NewSize = new()
                    {
                        Width = width,
                        Height = height
                    };
                    int size = Math.Min(I.Width, I.Height);
                    Rectangle CropRectangle = new()
                    {
                        X = (I.Width - size) / 2,
                        Y = (I.Height - size) / 2,
                        Width = size,
                        Height = size
                    };
                    int Resize = Math.Max(width, height);
                    I.Mutate(x => x.Crop(CropRectangle).Resize(Resize, Resize));
                }
                else
                {
                    Size NewSize = new()
                    {
                        Width = width,
                        Height = height
                    };
                    I.Mutate(x => x.Resize(NewSize));
                }
                using MemoryStream ms = new();
                I.Save(ms, new JpegEncoder());
                imageBytes = ms.ToArray();
            }

            if (ctx.Request.Query["sig"] == "p1")
            {
                ctx.Response.Headers["Content-Signature"] = "key-id=KEY:RSA:p1.rec.net; data=" + Signatures.Sign(imageBytes);
            }

            return Results.File(imageBytes, "image/jpg");
        }
    }
}