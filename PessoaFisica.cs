using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UC12_SA2
{
    public class PessoaFisica : Pessoa
    {
        public string? cpf {get; set;}

        public DateTime dataNascimento {get; set;}

        public override float PagarImposto(float salario)
        {
           if(salario <= 1500){
                return 0;

           }else if(salario > 1500 && salario <= 5000){
                return (salario / 100) *3;

           }else{
                return (salario / 100) *5;
           }
        }

        public bool validarDataNascimento(DateTime dataNasc){

            DateTime dataAtual = DateTime.Today;

            double anos = (dataAtual - dataNasc).TotalDays / 365;

            if(anos >= 18){
                return true;
            }else{
                return false;
            }
        }
    }
}