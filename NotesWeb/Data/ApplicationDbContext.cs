using Microsoft.EntityFrameworkCore;
using NotesWeb.Models;

namespace NotesWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<MemoModel> Memos { get; set; }
    }
}
