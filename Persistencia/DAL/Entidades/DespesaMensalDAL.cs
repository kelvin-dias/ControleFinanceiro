using Modelo.Entidades;
using Persistencia.Context;
using System.Linq;

namespace Persistencia.DAL.Entidades
{
    public class DespesaMensalDAL
    {
        private EFContext context = new EFContext();

        public IQueryable<DespesaMensal> ObterDespesasFixas()
        {
            return context.DespesasMensais.OrderBy(x => x.Valor);
        }
    }
}
