using Microsoft.EntityFrameworkCore;
using DictionaryApi.Models;

namespace DictionaryApi.Data
{
    public class DictionaryContext : DbContext
    {
        public DictionaryContext(DbContextOptions<DictionaryContext> options) : base(options) { }

        public DbSet<DictionaryItem> DictionaryItems { get; set; }
    }
}
