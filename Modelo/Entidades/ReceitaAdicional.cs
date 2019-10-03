using System;
using System.ComponentModel.DataAnnotations;

namespace Modelo.Entidades
{
    public class ReceitaAdicional
    {
        public int? ReceitaAdicionalId { get; set; }
        public string NomeItem { get; set; }

        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal Valor { get; set; }
        public DateTime DataHora { get; set; }
        public string TipoReceita { get; set; }
    }
}
