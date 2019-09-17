using Servico.Entidades;
using System.Web.Mvc;

namespace ControleFinanceiro.Controllers
{
    public class DespesaFixaController : Controller
    {
        private DespesaFixaServico despesaFixaServico = new DespesaFixaServico();

        // GET: DespesaFixa
        public ActionResult AdicionarDespesasFixas()
        {
            return View();
        }

        // GET: DespesaFixa
        public ActionResult ListarDespesasFixas()
        {
            return View(despesaFixaServico.ObterDespesasFixas());
        }
    }
}