using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControleFinanceiro.Controllers
{
    public class DespesaMensalController : Controller
    {
        // GET: CompraMensal
        public ActionResult Index()
        {
            return View();
        }
    }
}