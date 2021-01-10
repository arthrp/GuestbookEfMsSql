using GuestbookEfMsSql.Dtos;
using Microsoft.EntityFrameworkCore;

namespace GuestbookEfMsSql
{
    public class MainDbContext : DbContext
    {
        public MainDbContext(DbContextOptions<MainDbContext> options): base(options) {}

        public DbSet<PostDto> Posts { get; set; }
    }
}