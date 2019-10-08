using Modelo.Entidades;
using Servico.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControleFinanceiro.Controllers
{
    public class ReceitaMensalController : Controller
    {
        private ReceitaMensalServico receitaMensalServico = new ReceitaMensalServico();

        // GET: ReceitaMensal
        public ActionResult ListarReceitaMensal()
        {
            return View(receitaMensalServico.ObterReceitaMensal());
        }

        // GET: ReceitaMensal
        public ActionResult TabelaReceitaMensal()
        {
            var mes = DateTime.Now.Month;
            var ano = DateTime.Now.Year;
            var somaTotalReceitaMensal = receitaMensalServico.ObterSomaReceitaMensal(mes, ano);
            ViewBag.SomaReceitaMensalTotal = somaTotalReceitaMensal;

            return View(receitaMensalServico.ObterReceitaMensal());
        }

        // GET: ReceitaMensal
        public ActionResult AdicionarReceitaMensal()
        {
            return View();
        }

        // POST: ReceitaMensal
        [HttpPost]
        public ActionResult AdicionarReceitaMensal(ReceitaMensal receitaMensal)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    receitaMensalServico.AdicionarReceitaMensal(receitaMensal);
                    return RedirectToAction("TabelaReceitaMensal");
                }
                return View(receitaMensal);
            }
            catch
            {
                return View(receitaMensal);
            }
        }
    }
}