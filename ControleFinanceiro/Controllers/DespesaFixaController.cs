using Servico.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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