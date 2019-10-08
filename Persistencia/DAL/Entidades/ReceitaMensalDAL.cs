using Microsoft.EntityFrameworkCore;
using Modelo.Entidades;
using Persistencia.Context;
using System.Linq;

namespace Persistencia
{
    public class ReceitaMensalDAL
    {
        private EFContext context = new EFContext();

        public IQueryable<ReceitaMensal> ObterReceitaMensal()
        {
            return context.ReceitasMensais.OrderBy(x => x.Valor);
        }

        public void AdicionarReceitaMensal(ReceitaMensal receitaMensal)
        {
            if (receitaMensal.ReceitaMensalId == null)
            {
                context.ReceitasMensais.Add(receitaMensal);
            }
            else
            {
                context.Entry(receitaMensal).State = EntityState.Modified;
            }

            context.SaveChanges();
        }

        public decimal ObterSomaReceitaMensal(int mes, int ano)
        {
            var somaReceitaMensal = context.ReceitasMensais.Where(x => x.DataHora.Month == mes && x.DataHora.Year == ano).Sum(x => x.Valor);


            return somaReceitaMensal;
        }
    }
}
