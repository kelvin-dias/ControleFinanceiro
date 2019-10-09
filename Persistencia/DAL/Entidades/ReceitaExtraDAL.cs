using Microsoft.EntityFrameworkCore;
using Modelo.Entidades;
using Persistencia.Context;
using System;
using System.Linq;

namespace Persistencia.DAL.Entidades
{
    public class ReceitaExtraDAL
    {
        private EFContext context = new EFContext();

        public IQueryable<ReceitaExtra> ObterReceitaExtra()
        {
            return context.ReceitasExtras.OrderBy(x => x.Valor);
        }

        public void AdicionarReceitaExtra(ReceitaExtra receitaExtra)
        {
            if (receitaExtra.ReceitaExtraId == null)
            {
                context.ReceitasExtras.Add(receitaExtra);
            }
            else
            {
                context.Entry(receitaExtra).State = EntityState.Modified;
            }

            context.SaveChanges();
        }

        public decimal ObterSomaReceitaExtra(int mes, int ano)
        {
            var somaReceitaExtra = context.ReceitasExtras.Where(x => x.DataHora.Month == mes && x.DataHora.Year == ano).Sum(x => x.Valor);


            return somaReceitaExtra;
        }
    }
}