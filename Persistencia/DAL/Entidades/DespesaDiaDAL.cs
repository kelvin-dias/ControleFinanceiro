using Microsoft.EntityFrameworkCore;
using Modelo.Entidades;
using Persistencia.Context;
using System.Linq;

namespace Persistencia.DAL.Entidades
{
    public class DespesaDiaDAL
    {
        private EFContext context = new EFContext();

        public IQueryable<DespesaDia> ObterDespesasDia()
        {

                var teste = context.DespesasDia.OrderBy(x => x.Valor);
            return teste;
        }

        public void AdicionarDespesaDia(DespesaDia despesaDia)
        {
            if (despesaDia.DespesaDiaId == null)
            {
                context.DespesasDia.Add(despesaDia);
            }
            else
            {
                context.Entry(despesaDia).State = EntityState.Modified;
            }

            context.SaveChanges();
        }

        public decimal ObterSomaDespesasDia(int mes, int ano)
        {
            var somaDespesasMensal = context.DespesasDia.Where(x => x.DataHora.Month == mes && x.DataHora.Year == ano).Sum(x => x.Valor);


            return somaDespesasMensal;
        }
    }
}
