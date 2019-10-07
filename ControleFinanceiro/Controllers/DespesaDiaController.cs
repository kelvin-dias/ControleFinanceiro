using Modelo.Entidades;
using Servico.Entidades;
using System;
using System.Web.Mvc;

namespace ControleFinanceiro.Controllers
{
    public class DespesaDiaController : Controller
    {
        private DespesaDiaServico despesaDiaServico = new DespesaDiaServico();


        // GET: DespesaDia
        public ActionResult ListarDespesasDia()
        {
            return View(despesaDiaServico.ObterDespesasDia());
        }

        public ActionResult TabelaDespesasDia()
        {
            var mes = DateTime.Now.Month;
            var ano = DateTime.Now.Year;

            var somaTotalDespesasMensal = despesaDiaServico.ObterSomaDespesasDia(mes, ano);
            ViewBag.SomaDespesasDiaTotal = somaTotalDespesasMensal;

            return View(despesaDiaServico.ObterDespesasDia());
        }

        // GET: DespesaFixa
        public ActionResult AdicionarDespesasDia()
        {
            return View();
        }

        // POST: DespesaDia
        [HttpPost]
        public ActionResult AdicionarDespesasDia(DespesaDia despesaDia)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    despesaDiaServico.AdicionarDespesaDia(despesaDia);
                    return RedirectToAction("TabelaDespesasDia");
                }
                return View(despesaDia);
            }
            catch
            {
                return View(despesaDia);
            }
        }
    }
}