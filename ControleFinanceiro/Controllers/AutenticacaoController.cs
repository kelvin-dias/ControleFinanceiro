using Persistencia.Context;
using System.Web.Mvc;

namespace ControleFinanceiro.Controllers
{
    public class AutenticacaoController : Controller
    {
    private EFContext context = new EFContext();

        // GET: Autenticacao
        public ActionResult Index()
        {
            return View();
        }
    }
}