using Persistencia.Context;
using System.Linq;

namespace Persistencia.DAL.Tabelas
{
    public class DashboardDAL
    {
        EFContext context = new EFContext();
        public decimal ObterSomaDespesasMensalTotais(int mes, int ano)
        {
            var somaDespesasFixas = context.DespesasDia.Where(x => x.DataHora.Month == mes && x.DataHora.Year == ano).Sum(x => x.Valor);
            var somaDespesasParceladas = context.DespesasParceladas.Where(x => x.DataHora.Month == mes && x.DataHora.Year == ano).Sum(x => x.Valor);
            var somaDespesasMensal = context.DespesasMensais.Where(x => x.DataHora.Month == mes && x.DataHora.Year == ano).Sum(x => x.Valor);

            var somaDespesasTotal = somaDespesasFixas + somaDespesasParceladas + somaDespesasMensal;

            return somaDespesasTotal;
        }

        public decimal ObterSomaReceitaMensalTotais(int mes, int ano)
        {
            var somaReceitaExtra = context.ReceitasExtras.Where(x => x.DataHora.Month == mes && x.DataHora.Year == ano).Sum(x => x.Valor);
            var somaReceitaMensal = context.ReceitasMensais.Where(x => x.DataHora.Month == mes && x.DataHora.Year == ano).Sum(x => x.Valor);

            var somaReceitaTotal = somaReceitaExtra + somaReceitaMensal;

            return somaReceitaTotal;
        }
    }
}
