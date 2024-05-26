using Library.Library.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Library.DataAccess.Concrete.EntityFramework
{
    //Veri Tabanı ile kodun bağlantısını sağlayan EntityFramework kodları
    // bu nesneleri sorgular ve kaydeder
    public class LibraryContext : DbContext
    {
        public DbSet<Status> Status { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Magazine> Magazines { get; set; } 
    }
}
