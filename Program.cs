namespace Stella
{
    public class Program
    {
        /* 
         * Console.WriteLine(JsonSerializer.Serialize(ctx.Request.Form.ToDictionary(k => k.Key, v => v.Value.ToString()), new JsonSerializerOptions { WriteIndented = true }));
         * above to print form in json
        */

        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            var webApplication = builder.Build();
            var app = new ServerAPI(webApplication);

            app.Init();

            Signatures.Init();

            app.Run();
        }
    }
}