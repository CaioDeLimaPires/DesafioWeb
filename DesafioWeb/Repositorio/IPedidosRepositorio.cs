using ControleDePedidos.Models;

namespace DesafioWeb.Repositorio
{
    public interface IPedidosRepositorio
    {
        //Buscar todos os dados do banco
        List<PedidosModel> BuscarTodos();
        
        //Adicionar os dados do banco
        PedidosModel Adicionar(PedidosModel pedido);
    }
}
