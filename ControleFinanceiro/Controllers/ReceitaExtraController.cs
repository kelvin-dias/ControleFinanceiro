using Modelo.Entidades;
using Servico.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControleFinanceiro.Controllers
{
    public class ReceitaExtraController : Controller
    {
        private ReceitaExtraServico receitaExtraServico = new ReceitaExtraServico();

        // GET: ReceitaExtra
        public ActionResult ListarReceitaExtra()
        {
            return View(receitaExtraServico.ObterReceitaExtra());
        }

        // GET: ReceitaExtra
        public ActionResult TabelaReceitaExtra()
        {
            var mes = DateTime.Now.Month;
            var ano = DateTime.Now.Year;
            var somaTotalReceitaExtra = receitaExtraServico.ObterSomaReceitaExtra(mes, ano);
            ViewBag.SomaReceitaMensalTotal = somaTotalReceitaExtra;

            return View(receitaExtraServico.ObterReceitaExtra());
        }

        // GET: ReceitaExtra
        public ActionResult AdicionarReceitaExtra()
        {
            return View();
        }

        // POST: ReceitaExtra
        [HttpPost]
        public ActionResult AdicionarReceitaExtra(ReceitaExtra receitaExtra)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    receitaExtraServico.AdicionarReceitaExtra(receitaExtra);
                    return RedirectToAction("TabelaReceitaExtra");
                }
                return View(receitaExtra);
            }
            catch
            {
                return View(receitaExtra);
            }
        }
    }
}