using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Modelo.Entidades
{
    public class DespesaParcelada
    {
        public int? DespesaParceladaId { get; set; }

        [DisplayName("Item")]
        public string NomeItem { get; set; }
        public double ValorParcela { get; set; }


        [DisplayName("Valor do Item")]
        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal Valor { get; set; }

        [DisplayName("Data")]
        public DateTime DataHora { get; set; }
        public int QuantidadeParcela { get; set; }
        public string Categoria { get; set; }
        public Boolean StatusPagamento { get; set; }
    }
}