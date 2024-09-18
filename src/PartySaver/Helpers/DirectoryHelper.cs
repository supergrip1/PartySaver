namespace PartySaver.Services;

public static class DirectoryHelper
{
    public static string GetBaseDirectory()
    {
        return Path.Combine(Environment.GetEnvironmentVariable("BASE_PATH") ?? AppDomain.CurrentDomain.BaseDirectory,
            "data");
    }

    public static string GetImageDirectory()
    {
        return Path.Combine(GetBaseDirectory(), "images");
    }

    public static string GetDatabaseDirectory()
    {
        return Path.Combine(GetBaseDirectory(), "database");
    }

    public static string GetDatabaseFile()
    {
        return Path.Combine(GetBaseDirectory(), "database", "app.sqlite");
    }

    public static void Initialize()
    {
        Directory.CreateDirectory(GetBaseDirectory());
        Directory.CreateDirectory(GetImageDirectory());
        Directory.CreateDirectory(GetDatabaseDirectory());
    }
}