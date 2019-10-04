using System;
using System.ComponentModel.DataAnnotations;

namespace Modelo.Entidades
{
    public class DespesaParcelada
    {
        public int? DespesaParceladaId { get; set; }
        public string NomeItem { get; set; }
        public double ValorParcela { get; set; }

        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal Valor { get; set; }
        public DateTime DataHora { get; set; }
        public int QuantidadeParcela { get; set; }
        public string Categoria { get; set; }
        public Boolean StatusPagamento { get; set; }
    }
}