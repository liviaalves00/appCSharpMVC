using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace c_.Models
{
    public class Professor : Pessoa
    {
        public string Formacao {get; set;}
        public double Salario {get; set;}

        // public virtual ICollection<Turma> 
    }
}