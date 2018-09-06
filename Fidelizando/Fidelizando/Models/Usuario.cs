using System;
using System.Collections.Generic;
using System.Text;

namespace Fidelizando.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public int Pontos { get; set; }
        public bool IsLogged { get; set; }
    }
}
