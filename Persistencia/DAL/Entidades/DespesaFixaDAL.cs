using Modelo.Entidades;
using Persistencia.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.DAL.Entidades
{
    public class DespesaFixaDAL
    {
        private EFContext context = new EFContext();

        public IQueryable<DespesaFixa> ObterDespesasFixas()
        {

                var teste = context.DespesasFixas.OrderBy(x => x.Valor);
            return teste;
        }
    }
}
