using Microsoft.EntityFrameworkCore;
using Modelo.Entidades;
using Persistencia.Context;
using System.Linq;

namespace Persistencia.DAL.Entidades
{
    public class DespesaMensalDAL
    {
        private EFContext context = new EFContext();

        public IQueryable<DespesaMensal> ObterDespesasFixas()
        {
            return context.DespesasMensais.OrderBy(x => x.Valor);
        }

        public void AdicionarDespesaMensal(DespesaMensal despesaMensal)
        {
            if (despesaMensal.DespesaMensalId == null)
            {
                context.DespesasMensais.Add(despesaMensal);
            }
            else
            {
                context.Entry(despesaMensal).State = EntityState.Modified;
            }

            context.SaveChanges();
        }
    }
}
