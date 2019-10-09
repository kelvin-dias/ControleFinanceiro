using Modelo.Entidades;
using Persistencia.DAL.Entidades;
using System.Linq;

namespace Servico.Entidades
{
    public class ReceitaExtraServico
    {
        ReceitaExtraDAL receitaExtraDAL = new ReceitaExtraDAL();

        public IQueryable ObterReceitaExtra()
        {
            return receitaExtraDAL.ObterReceitaExtra();
        }

        public void AdicionarReceitaExtra(ReceitaExtra receitaExtra)
        {
            receitaExtraDAL.AdicionarReceitaExtra(receitaExtra);
        }

        public decimal ObterSomaReceitaExtra(int mes, int ano)
        {
            return receitaExtraDAL.ObterSomaReceitaExtra(mes, ano);
        }
    }
}
