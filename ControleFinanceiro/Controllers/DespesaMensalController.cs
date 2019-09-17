using Servico.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControleFinanceiro.Controllers
{
    public class DespesaMensalController : Controller
    {
        private DespesaMensalServico despesaMensalServico = new DespesaMensalServico();

        // GET: DespesaMensal
        public ActionResult Index()
        {
            return View();
        }

        // GET: DespesaMensal
        public ActionResult ListarDespesasMensais()
        {
            return View(despesaMensalServico.ObterDespesasMensais());
        }
    }
}