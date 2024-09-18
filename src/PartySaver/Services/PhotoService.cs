using PartySaver.Data;
using PartySaver.Data.Models;

namespace PartySaver.Services;

public class PhotoService
{
    private readonly DatabaseContext _context;
    private readonly FileService _fileService;
    private readonly ILogger<PhotoService> _logger;

    public PhotoService(FileService fileService, DatabaseContext context, ILogger<PhotoService> logger)
    {
        _fileService = fileService;
        _context = context;
        _logger = logger;
    }


    public async Task AddPhoto(Stream file, string name, string user)
    {
        _logger.LogInformation("Processing Photo. Size {size} bytes", file.Length);
        var id = await _fileService.AddFile(file, name);
        var photo = new Photo();
        photo.PhotoFileId = id;
        photo.Username = user;

        _context.Photos.Add(photo);

        await _context.SaveChangesAsync();
    }
}