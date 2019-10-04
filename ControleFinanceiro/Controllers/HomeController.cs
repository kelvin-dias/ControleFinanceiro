using Servico.Tabelas;
using System;
using System.Web.Mvc;

namespace ControleFinanceiro.Controllers
{
    public class HomeController : Controller
    {
        private DashboardServico dashboardServico = new DashboardServico();

        
        // GET: Home
        public ActionResult Dashboard()
        {
            var mes = DateTime.Now.Month;
            var ano = DateTime.Now.Year;

            var somaTotalDespesasMensal = dashboardServico.ObterSomaDespesasMensal(mes, ano);
            ViewBag.SomaDespesasMensalTotal = somaTotalDespesasMensal;
            return View();
        }
    }
}