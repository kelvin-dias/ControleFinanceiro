using Persistencia.DAL.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servico.Entidades
{
    public class DespesaFixaServico
    {
        DespesaFixaDAL despesasFixasDAL = new DespesaFixaDAL();

        public IQueryable ObterDespesasFixas()
        {
            return despesasFixasDAL.ObterDespesasFixas();
        }
    }
}
