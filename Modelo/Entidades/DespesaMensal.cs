using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Modelo.Entidades
{
    public class DespesaMensal
    {
        public int? DespesaMensalId { get; set; }
        [DisplayName("Item")]
        public string NomeItem { get; set; }
        [DisplayName("Valor do Item")]
        [DisplayFormat(DataFormatString = "{0,N2}")]
        public decimal Valor { get; set; }
        [DisplayName("Data")]
        public DateTime DataHora { get; set; }

    }
}