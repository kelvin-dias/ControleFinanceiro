using Modelo.Entidades;
using Servico.Entidades;
using System;
using System.Web.Mvc;

namespace ControleFinanceiro.Controllers
{
    public class DespesaMensalController : Controller
    {
        private DespesaMensalServico despesaMensalServico = new DespesaMensalServico();

        // GET: DespesaMensal
        public ActionResult ListarDespesasMensais()
        {
            return View(despesaMensalServico.ObterDespesasMensais());
        }

        public ActionResult TabelaDespesasMensais()
        {
            var mes = DateTime.Now.Month;
            var ano = DateTime.Now.Year;

            var somaTotalDespesasMensal = despesaMensalServico.ObterSomaDespesasMensal(mes, ano);
            ViewBag.SomaDespesasMensalTotal = somaTotalDespesasMensal;

            return View(despesaMensalServico.ObterDespesasMensais());
        }

        // GET: DespesaMensal
        public ActionResult AdicionarDespesaMensal()
        {
            return View();
        }

        // POST: DespesaMensal
        [HttpPost]
        public ActionResult AdicionarDespesaMensal(DespesaMensal despesaMensal)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    despesaMensalServico.AdicionarDespesaMensal(despesaMensal);
                    return RedirectToAction("TabelaDespesasMensais");
                }
                return View(despesaMensal);
            }
            catch
            {
                return View(despesaMensal);
            }
        }
    }
}