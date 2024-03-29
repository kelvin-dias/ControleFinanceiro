﻿using Microsoft.EntityFrameworkCore;
using Modelo.Entidades;
using Persistencia.Context;
using System.Linq;

namespace Persistencia.DAL.Entidades
{
    public class DespesaParceladaDAL
    {
        private EFContext context = new EFContext();

        public IQueryable<DespesaParcelada> ObterDespesasParceladas()
        {
            return context.DespesasParceladas.OrderBy(x => x.Valor);
        }

        public void AdicionarDespesaParcelada(DespesaParcelada despesaParcelada)
        {
            if (despesaParcelada.DespesaParceladaId == null)
            {
                context.DespesasParceladas.Add(despesaParcelada);
            }
            else
            {
                context.Entry(despesaParcelada).State = EntityState.Modified;
            }

            context.SaveChanges();
        }

        public decimal ObterSomaDespesasParceladas(int mes, int ano)
        {
            var somaDespesasParceladas = context.DespesasParceladas.Where(x => x.DataHora.Month == mes && x.DataHora.Year == ano).Sum(x => x.Valor);


            return somaDespesasParceladas;
        }
    }
}
