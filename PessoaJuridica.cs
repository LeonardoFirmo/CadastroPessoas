using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UC12_SA2
{
    public class PessoaJuridica : Pessoa
    {
        public string? cnpj { get;set;}
        public string? razaoSocial {get;set;}

         public override float PagarImposto(float salario)
        {   
            if(salario <= 5000){
                return  salario * .06f;

            }else if(salario > 5000 && salario <= 10000){

                return salario * .08f;

            }else{
                return salario * .10f;
            }
        }

        public bool ValidarCNPJ(string cnpj){

            if(cnpj.Length == 14 && cnpj.Substring(cnpj.Length -6, 4) == "0001"  ){
                return true;
            }else{
                return false;
            }
        }
    }
}