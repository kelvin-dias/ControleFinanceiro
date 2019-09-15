using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Modelo.Entidades
{
    public class DespesaFixa
    {
        public int? DespesaFixaId { get; set; }
        public string NomeItem { get; set; }
        public double Valor { get; set; }
        public DateTime DataHora { get; set; }
        public string Categoria { get; set; }
    }
}