using Persistencia.DAL.Tabelas;

namespace Servico.Tabelas
{
    public class DashboardServico
    {
        DashboardDAL dashboardDAL = new DashboardDAL();
        public decimal ObterSomaDespesasMensalTotais(int mes, int ano)
        {
            return dashboardDAL.ObterSomaDespesasMensalTotais(mes, ano);
        }

        public decimal ObterSomaReceitaMensalTotais(int mes, int ano)
        {
            return dashboardDAL.ObterSomaReceitaMensalTotais(mes, ano);
        }
    }
}
