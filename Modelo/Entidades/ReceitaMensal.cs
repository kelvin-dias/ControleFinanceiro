using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Modelo.Entidades
{
    public class ReceitaMensal
    {
        public int? ReceitaMensalId { get; set; }

        [DisplayName("Item")]
        public string NomeReceita { get; set; }

        [DisplayFormat(DataFormatString = "{0:N2}")]

        [DisplayName("Valor do Item")]
        public decimal Valor { get; set; }

        [DisplayName("Data")]
        public DateTime DataHora { get; set; }
        public string TipoReceita { get; set; }
    }
}
