using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UC12_SA2
{
    public class PessoaFisica : Pessoa
    {
        public string cpf {get; set;}

        public DateTime dataNascimento {get; set;}
    }
}