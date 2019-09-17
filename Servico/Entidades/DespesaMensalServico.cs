using Persistencia.DAL.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servico.Entidades
{
     public class DespesaMensalServico
    {
        DespesaMensalDAL despesasMensaisDAL = new DespesaMensalDAL();

        public IQueryable ObterDespesasMensais()
        {
            return despesasMensaisDAL.ObterDespesasFixas();
        }
    }
}
