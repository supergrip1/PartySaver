namespace PartySaver.Services;

public class DirectoryService
{
    public readonly string BaseDirectory;
    public readonly string ImageDirectory;
    public readonly string DatabaseDirectory;
    public readonly string DatabaseFile;

    public DirectoryService()
    {
        BaseDirectory =
            Path.Combine(Environment.GetEnvironmentVariable("BASE_PATH") ?? AppDomain.CurrentDomain.BaseDirectory,
                "data");
        ImageDirectory = Path.Combine(BaseDirectory, "images");
        DatabaseDirectory = Path.Combine(BaseDirectory, "database");
        DatabaseFile = Path.Combine(BaseDirectory, "database", "app.sqlite");
    }

    private void Initialize()
    {
        Directory.CreateDirectory(BaseDirectory);
        Directory.CreateDirectory(ImageDirectory);
        Directory.CreateDirectory(DatabaseDirectory);
    }
}