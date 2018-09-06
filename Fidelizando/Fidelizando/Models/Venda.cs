using System;
using System.Collections.Generic;
using System.Text;

namespace Fidelizando.Models
{
    public class Venda
    {
        public int Id { get; set; }
        public string Data { get; set; }
        public string TotalPontos { get; set; }
        public string UrlQrCode { get; set; }
    }
}
