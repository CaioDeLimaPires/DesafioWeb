using ControleDePedidos.Models;
using DesafioWeb.Data;

namespace DesafioWeb.Repositorio
{
    public class PedidosRepositorio : IPedidosRepositorio
    {
        //Sistema de injeção
        private readonly BancoDeDados _bancodedados;
        public PedidosRepositorio(BancoDeDados bancodedados)
        {
            _bancodedados = bancodedados;
        }

        //Sistema De Consulta de dados do banco
        public List<PedidosModel> BuscarTodos()
        {
            return _bancodedados.Pedidos.ToList();
        }

        //Adicionar os dados ao banco
        public PedidosModel Adicionar(PedidosModel pedido)
        {
            //Gravar No Banco
            _bancodedados.Pedidos.Add(pedido);
            _bancodedados.SaveChanges();
            return pedido;
        }


    }
}
