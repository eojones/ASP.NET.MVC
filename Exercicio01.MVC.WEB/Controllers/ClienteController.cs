using Exercicio01.MVC.WEB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Exercicio01.MVC.WEB.Controllers
{
    
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Index(List<Cliente> lstClientes)
        {
            return View(lstClientes);
        }
       
    }
}