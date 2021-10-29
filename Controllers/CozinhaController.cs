using Factory_Method.Factory;
using Microsoft.AspNetCore.Mvc;

namespace Factory_Method.Controllers
{
    public class CozinhaController : Controller
    {
        // GET: CozinhaController
        public ActionResult Index(string pedido)
        {
            if (!string.IsNullOrEmpty(pedido))
            { 
                switch (pedido)
                {
                    case "hamburguer":
                        ViewBag.Result = NovoPedido(new PrepararHamburguer());
                        break;
                    case "pizza":
                        ViewBag.Result = NovoPedido(new PrepararPizza());
                        break;
                    case "batatafrita":
                        ViewBag.Result = NovoPedido(new PrepararBatataFrita());
                        break;
                }
            }

            return View();
        }

        private static string NovoPedido(Cozinha cozinha) => "Cozinha: " + cozinha.PrepararLanche();
    }
}
