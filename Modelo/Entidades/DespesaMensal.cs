﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Modelo.Entidades
{
    public class DespesaMensal
    {
        public int? DespesaMensalId { get; set; }
        public string NomeItem { get; set; }
        public double Valor { get; set; }
        public DateTime DataHora { get; set; }

    }
}