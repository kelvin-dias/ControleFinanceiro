using System;
using System.ComponentModel.DataAnnotations;

namespace Modelo.Entidades
{
    public class ReceitaMensal
    {
        public int? ReceitaMensalId { get; set; }
        public string NomeReceita { get; set; }

        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal Valor { get; set; }
        public DateTime DataHora { get; set; }
        public string TipoReceita { get; set; }
    }
}
