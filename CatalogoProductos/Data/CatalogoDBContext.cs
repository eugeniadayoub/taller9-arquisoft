using Microsoft.EntityFrameworkCore;
using CatalogoProductos.Models;

namespace CatalogoProductos.Data
{
    public class CatalogoDBContext : DbContext
    {
        public CatalogoDBContext(DbContextOptions<CatalogoDBContext> options) : base(options) { }

        public DbSet<Producto> Productos { get; set; }
    }
}
