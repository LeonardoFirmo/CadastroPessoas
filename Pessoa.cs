using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UC12_SA2
{
    public abstract class Pessoa
    {
        public string? nome {get;set;}
        public Endereco? endereco { get; set; }

        public float salario {get;set;}

        public abstract float PagarImposto(float salario);
        
    }
}