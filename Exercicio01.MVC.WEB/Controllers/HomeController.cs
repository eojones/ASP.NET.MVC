using Exercicio01.MVC.WEB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Exercicio01.MVC.WEB.Controllers
{
   
    public class HomeController : Controller
    {
        private static List<Cliente> _listaClientes = new List<Cliente>();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddToList(Cliente cli)
        {
            _listaClientes.Add(cli);
            ViewBag.lista = _listaClientes;
            TempData["msg"] = "Cliente Adicionado!";
            return Redirect("Index");
        }
        public ActionResult Listar()
        {
            return RedirectToAction("Index","Cliente", _listaClientes);
        }
    }
}