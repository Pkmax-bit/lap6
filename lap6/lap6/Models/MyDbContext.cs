using Microsoft.EntityFrameworkCore;

namespace lap6.Models
{
    public class MyDbContext : DbContext
    {
       
        public MyDbContext(DbContextOptions<MyDbContext>

        options) : base(options) { }
        #region Table
        public DbSet<Loai> Loais { get; set; }
        public DbSet<HangHoa> HangHoas { get; set; }
        #endregion
    }
}
