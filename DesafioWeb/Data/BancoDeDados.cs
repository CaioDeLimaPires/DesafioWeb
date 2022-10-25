using Microsoft.EntityFrameworkCore;
using ControleDePedidos.Models;
namespace DesafioWeb.Data
{
    public class BancoDeDados : DbContext
    {
        public BancoDeDados(DbContextOptions<BancoDeDados> options) : base(options)
        {
        }
        public DbSet<PedidosModel> Pedidos { get; set; }

    }
}
