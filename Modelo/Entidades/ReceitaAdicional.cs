﻿using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Modelo.Entidades
{
    public class ReceitaAdicional
    {
        public int? ReceitaAdicionalId { get; set; }

        [DisplayName("Item")]
        public string NomeItem { get; set; }

        [DisplayName("Valor do Item")]
        [Required(ErrorMessage = "Informe o preço do produto", AllowEmptyStrings = false)]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = true)]
        public decimal Valor { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        [DataType(DataType.Date, ErrorMessage = "Data em formato inválido")]
        [DisplayName("Data")]
        public DateTime DataHora { get; set; }
        public string TipoReceita { get; set; }
    }
}
