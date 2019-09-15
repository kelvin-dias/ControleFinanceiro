using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Modelo.Entidades
{
    public class DespesaParcelada
    {
        public int DespesaParceladaId { get; set; }
        public string NomeItem { get; set; }
        public double ValorParcela { get; set; }
        public double Valor { get; set; }
        public DateTime DataHora { get; set; }
        public int QuantidadeParcela { get; set; }
        public string Categoria { get; set; }
        public Boolean StatusPagamento { get; set; }
    }
}