using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UC12_SA2
{
    public class PessoaJuridica : Pessoa
    {
        public int cnpj { get;set;}
        public string razaoSocial {get;set;}

         public override void PagarImposto(float salario)
        {
           
        }
    }
}