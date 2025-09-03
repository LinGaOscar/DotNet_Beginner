var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

string storedBody = null;

app.MapGet("/env", () =>
{
    return Results.Json(new
    {
        state = "success",
        code = "0000",
        body = new
        {
            version = "v1.0"
        }
    });
});

app.MapPost("/savebody", async (HttpContext context) =>
{
    using var reader = new StreamReader(context.Request.Body);
    var requestBody = await reader.ReadToEndAsync();

    var downloadPath = Path.Combine(Directory.GetCurrentDirectory(), "download");
    if (!Directory.Exists(downloadPath))
    {
        Directory.CreateDirectory(downloadPath);
    }

    var fileName = $"body_{DateTime.Now:yyyyMMddHHmmssfff}.txt";
    var filePath = Path.Combine(downloadPath, fileName);

    await File.WriteAllTextAsync(filePath, requestBody);

    return Results.Ok(new { message = "Body saved to file", filePath });
});

app.Run();
