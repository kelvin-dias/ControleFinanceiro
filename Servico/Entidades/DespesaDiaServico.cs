using Modelo.Entidades;
using Persistencia.DAL.Entidades;
using System.Linq;

namespace Servico.Entidades
{
    public class DespesaDiaServico
    {
        DespesaDiaDAL despesasDiaDAL = new DespesaDiaDAL();

        public IQueryable ObterDespesasDia()
        {
            return despesasDiaDAL.ObterDespesasDia();
        }

        public void AdicionarDespesaDia(DespesaDia despesaMensal)
        {
            despesasDiaDAL.AdicionarDespesaDia(despesaMensal);
        }
    }
}
