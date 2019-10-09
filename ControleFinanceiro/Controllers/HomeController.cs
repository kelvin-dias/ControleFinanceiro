using Servico.Tabelas;
using System;
using System.Web.Mvc;

namespace ControleFinanceiro.Controllers
{
    public class HomeController : Controller
    {
        private DashboardServico dashboardServico = new DashboardServico();

        // GET: Home
        public ActionResult Login()
        {
            return View();
        }

        // GET: Home
        public ActionResult Dashboard()
        {
            var mes = DateTime.Now.Month;
            var ano = DateTime.Now.Year;

            var somaTotalDespesasMensal = dashboardServico.ObterSomaDespesasMensalTotais(mes, ano);
            ViewBag.SomaDespesasMensalTotal = somaTotalDespesasMensal;

            var somaTotalReceitaMensal = dashboardServico.ObterSomaReceitaMensalTotais(mes, ano);
            ViewBag.SomaReceitaMensalTotal = somaTotalReceitaMensal;

            ViewBag.SomaReceitaLiquida = somaTotalReceitaMensal - somaTotalDespesasMensal;

            return View();
        }
    }
}