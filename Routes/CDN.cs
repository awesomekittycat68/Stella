namespace Stella.Routes
{
    public class CDN
    {
        [ServerAPI.GET("/cdn/config/LoadingScreenTipData")]
        public List<object> LoadingScreenTips()
        {
            return [];
        }

        [ServerAPI.GET("/cdn/room/{blobname}")]
        public IResult GetDatablob(HttpContext ctx, string blobname)
        {
            string datablobPath = Path.Combine("Data", "Datablobs", blobname);

            if (!File.Exists(datablobPath))
                return Results.NotFound();

            byte[] dbBytes = File.ReadAllBytes(datablobPath);

            return Results.File(dbBytes);
        }
    }
}