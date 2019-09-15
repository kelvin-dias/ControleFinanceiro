using Persistencia.DAL.Tabelas;

namespace Servico.Tabelas
{
    public class DashboardServico
    {
        DashboardDAL dashboardDAL = new DashboardDAL();
        public double ObterSomaDespesasMensal(int mes, int ano)
        {
            return dashboardDAL.ObterSomaDespesasMensal(mes, ano);
        }
    }
}
