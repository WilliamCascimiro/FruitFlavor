using Entities.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace Infra.Contexto
{
    public class DbContext : IdentityDbContext<ApplicationUser>
    {
        public DbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<ProdutoModel> Produto { set; get; }
        public DbSet<PedidoModel> Pedido { set; get; }
        public DbSet<Produto_Pedido> ProdutoPedido { set; get; }
        


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<ApplicationUser>().ToTable("AspNetUsers").HasKey(t => t.Id);

            base.OnModelCreating(builder);
        }

    }
}
