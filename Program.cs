using System;
using System.Threading;

namespace UC12_SA2
{
    class Program
    {
        static void Main(string[] args)
        {
            Endereco endPf = new Endereco();
            endPf.logradouro = "Rua Akira";
            endPf.numero = 100;
            endPf.complemento="Próximo a tokyo";
            endPf.enderecoComercial = true;

            Endereco endPj = new Endereco();
            endPj.logradouro = "Rua PJ";
            endPj.numero = 500;
            endPj.complemento= "em frente a rua pj";


            PessoaFisica novapf = new PessoaFisica();
            novapf.cpf= "12354546";
            novapf.dataNascimento = new DateTime(2000, 01, 23);
            novapf.nome= "Pessoa física";
            novapf.endereco = endPf;


            PessoaJuridica pj = new PessoaJuridica();
 
            PessoaJuridica novapj = new PessoaJuridica();
            novapj.cnpj= "12345678900001";
            novapj.razaoSocial = "Pessoa juridica RS";
            novapj.endereco = endPj;

            Console.WriteLine($"Rua: {novapf.endereco.logradouro}, {novapf.endereco.numero}")
            
            Console.WriteLine($"Sua data de nascimento é: {novapf.dataNascimento}")


            bool idadeValida = novapf.validarDataNascimento(novapf.dataNascimento);
            Console.WriteLine(idadeValida);

            if(idadeValida == true){
                System.Console.WriteLine($"Cadastro aprovado");
            }else{
                System.Console.WriteLine($"Cadastro reprovado");
            }


            pj.ValidarCNPJ(novapj.cnpj);

            if(pj.ValidarCNPJ(novapj.cnpj)){
                Console.WriteLine("CNPJ é válido");
            }else{
                Console.WriteLine("CNPJ é inválido");

            }
            
        }
        
    }


}



