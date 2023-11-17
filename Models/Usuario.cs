using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace c_.Models
{
    public class Usuario: Pessoa
    {
        public int Id {get; set;}
        public string Nome {get; set;}
        public string Login {get; set;}
        public string Password {get; set;}

        
    }
}