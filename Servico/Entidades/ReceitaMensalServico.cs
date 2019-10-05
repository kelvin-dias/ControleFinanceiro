using Modelo.Entidades;
using Persistencia;
using System.Linq;

namespace Servico.Entidades
{
    public class ReceitaMensalServico
    {
        ReceitaMensalDAL receitaMensalDAL = new ReceitaMensalDAL();

        public IQueryable ObterReceitaMensal()
        {
            return receitaMensalDAL.ObterReceitaMensal();
        }

        public void AdicionarReceitaMensal(ReceitaMensal receitaMensal)
        {
            receitaMensalDAL.AdicionarReceitaMensal(receitaMensal);
        }
    }
}
