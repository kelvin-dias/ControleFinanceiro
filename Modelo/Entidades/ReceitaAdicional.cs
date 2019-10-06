using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Modelo.Entidades
{
    public class ReceitaAdicional
    {
        public int? ReceitaAdicionalId { get; set; }

        [DisplayName("Item")]
        public string NomeItem { get; set; }

        [DisplayName("Data")]
        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal Valor { get; set; }

        [DisplayName("Data")]
        public DateTime DataHora { get; set; }
        public string TipoReceita { get; set; }
    }
}
