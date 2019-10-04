using Persistencia.Context;
using System.Linq;

namespace Persistencia.DAL.Tabelas
{
    public class DashboardDAL
    {
        EFContext context = new EFContext();
        public decimal ObterSomaDespesasMensal(int mes, int ano)
        {
            var somaDespesasFixas = context.DespesasDia.Where(x => x.DataHora.Month == mes && x.DataHora.Year == ano).Sum(x => x.Valor);
            var somaDespesasParceladas = context.DespesasParceladas.Where(x => x.DataHora.Month == mes && x.DataHora.Year == ano).Sum(x => x.Valor);
            var somaDespesasMensal = context.DespesasMensais.Where(x => x.DataHora.Month == mes && x.DataHora.Year == ano).Sum(x => x.Valor);

            var somaDespesasTotal = somaDespesasFixas + somaDespesasParceladas + somaDespesasMensal;

            return somaDespesasTotal;
        }
    }
}
