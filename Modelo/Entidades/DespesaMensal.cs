using System;
using System.ComponentModel.DataAnnotations;

namespace Modelo.Entidades
{
    public class DespesaMensal
    {
        public int? DespesaMensalId { get; set; }
        public string NomeItem { get; set; }

        [DisplayFormat(DataFormatString = "{0,N2}")]
        public decimal Valor { get; set; }
        public DateTime DataHora { get; set; }

    }
}