﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Modelo.Entidades
{
    public class DespesaFixa
    {
        public int? DespesaFixaId { get; set; }
        public string NomeItem { get; set; }

        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal Valor { get; set; }
        public DateTime DataHora { get; set; }
        public string Categoria { get; set; }
    }
}