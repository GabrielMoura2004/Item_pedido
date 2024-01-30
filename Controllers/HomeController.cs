using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ItemPedidoMVC.Models;

namespace ItemPedidoMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

      

       
        public IActionResult Detalhe()
        {
          ItemPedido itempedido= new ItemPedido();
         
            itempedido.Quantidade=6;

            itempedido.ValorUnitario=7.50;
            itempedido.Descricao="Coca cola";
            
            return View(itempedido);
        }
           public IActionResult Cadastro()
           {
               return View();
           }
             [HttpPost]
             public IActionResult Cadastro(ItemPedido itempedido)
          {
             BaseDados.Incluir(itempedido);
             return View("Concluido");
          }
          public IActionResult Listagem()
         {
             List<ItemPedido> itempedidos=BaseDados.Listar();
             return View(itempedidos);
         }
          
          [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }     
    }

}
