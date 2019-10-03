using Modelo.Entidades;
using Persistencia.DAL.Entidades;
using System.Linq;

namespace Servico.Entidades
{
    public class DespesaMensalServico
    {
        DespesaMensalDAL despesasMensaisDAL = new DespesaMensalDAL();

        public IQueryable ObterDespesasMensais()
        {
            return despesasMensaisDAL.ObterDespesasFixas();
        }

        public void AdicionarDespesaMensal(DespesaMensal despesaMensal)
        {
            despesasMensaisDAL.AdicionarDespesaMensal(despesaMensal);
        }
    }
}
