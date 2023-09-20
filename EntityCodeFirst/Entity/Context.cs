using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EntityCodeFirst.Entity {
    public class Context: DbContext {
        public DbSet<Urunler> Urunler { get; set; }
        public DbSet<Kategori> Kategori { get; set; }
    }
}
