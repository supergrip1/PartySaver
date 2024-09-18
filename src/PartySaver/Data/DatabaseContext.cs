using Microsoft.EntityFrameworkCore;
using PartySaver.Data.Models;

namespace PartySaver.Data;

public class DatabaseContext : DbContext
{
    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
    {
    }

    public DbSet<CdnFile> Files { get; set; }
    public DbSet<Photo> Photos { get; set; }
}