using ControleDePedidos.Models;
using DesafioWeb.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace DesafioWeb.Controllers
{
    public class SolicitacaoController : Controller
    {
        private readonly IPedidosRepositorio _ipedidosrepositorio;
        public SolicitacaoController(IPedidosRepositorio pedidosrepositorio)
        {
            _ipedidosrepositorio = pedidosrepositorio;
        }
        public IActionResult Index()
        {
           List<PedidosModel>  pedidos =_ipedidosrepositorio.BuscarTodos();
            return View(pedidos);
        }
        public IActionResult Cadastrar()
        {
            return View();
        }
        public IActionResult Editar()
        {
            return View();
        }
        public IActionResult CancelarSolicitacao()
        {
            return View();
        }
        
        //Salvar informações nos obj
        [HttpPost]
        public IActionResult Cadastrar(PedidosModel pedido)
        {
            _ipedidosrepositorio.Adicionar(pedido);
            return RedirectToAction("Index");
        }

    }
}
