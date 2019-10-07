using Modelo.Entidades;
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
            return View(despesaParceladaServico.ObterDespesaParcelada());
        }

        public ActionResult TabelaDespesaParcelada()
        {
            var mes = DateTime.Now.Month;
            var ano = DateTime.Now.Year;
            var somaTotalDespesasParceladas = despesaParceladaServico.ObterSomaDespesasParceladas(mes, ano);
            ViewBag.SomaDespesasParceladasTotal = somaTotalDespesasParceladas;

            return View(despesaParceladaServico.ObterDespesaParcelada());
        }

        // GET: DespesaMensal
        public ActionResult AdicionarDespesaParcelada()
        {
            return View();
        }

        // POST: DespesaMensal
        [HttpPost]
        public ActionResult AdicionarDespesaParcelada(DespesaParcelada despesaParcelada)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    despesaParceladaServico.AdicionarDespesaParcelada(despesaParcelada);
                    return RedirectToAction("TabelaDespesaParcelada");
                }
                return View(despesaParcelada);
            }
            catch
            {
                return View(despesaParcelada);
            }
        }
    }
}