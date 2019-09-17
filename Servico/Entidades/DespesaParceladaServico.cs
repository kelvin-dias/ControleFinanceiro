using Persistencia.DAL.Entidades;
using System.Linq;

namespace Servico.Entidades
{
    public class DespesaParceladaServico
    {
        DespesaParceladaDAL despesasParceladasDAL = new DespesaParceladaDAL();

        public IQueryable ObterDespesasParceladas()
        {
            return despesasParceladasDAL.ObterDespesasParceladas();
        }
    }
}
