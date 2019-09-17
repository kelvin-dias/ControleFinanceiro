using Servico.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControleFinanceiro.Controllers
{
    public class DespesaParceladaController : Controller
    {
        private DespesaParceladaServico despesaParceladaServico = new DespesaParceladaServico();

        // GET: CompraParcelada
        public ActionResult Index()
        {
            return View();
        }

        // GET: DespesaParcelada
        public ActionResult ListarDespesasParceladas()
        {
            return View(despesaParceladaServico.ObterDespesasParceladas());
        }
    }
}