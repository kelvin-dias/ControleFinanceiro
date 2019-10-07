using Modelo.Entidades;
using Persistencia.DAL.Entidades;
using System.Linq;

namespace Servico.Entidades
{
    public class DespesaParceladaServico
    {
        DespesaParceladaDAL despesasParceladasDAL = new DespesaParceladaDAL();

        public IQueryable ObterDespesaParcelada()
        {
            return despesasParceladasDAL.ObterDespesasParceladas();
        }

        public void AdicionarDespesaParcelada(DespesaParcelada despesaParcelada)
        {
            despesasParceladasDAL.AdicionarDespesaParcelada(despesaParcelada);
        }

        public decimal ObterSomaDespesasParceladas(int mes, int ano)
        {
            return despesasParceladasDAL.ObterSomaDespesasParceladas(mes, ano);
        }
    }
}
