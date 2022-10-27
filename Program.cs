using System;
using System.Threading;

namespace UC12_SA2
{
    class Program
    {
        static void Main(string[] args)
        {
            Endereco end = new Endereco();
            end.logradouro = "Rua Akira";
            end.numero = 100;
            end.complemento="Próximo a tokyo";
            end.enderecoComercial = true;

            PessoaFisica novapf = new PessoaFisica();
            novapf.cpf= "12354546";
            novapf.dataNascimento = new DateTime(2000, 01, 23);
            novapf.nome= "Pessoa física";
            novapf.endereco = end;


            PessoaJuridica pj = new PessoaJuridica();
            pj.cnpj= 1774654321;
            pj.razaoSocial = "Pessoa juridica RS";
            pj.endereco.logradouro="Rua pessoa juridica";

            Console.WriteLine($"Rua: {novapf.endereco.logradouro}, {novapf.endereco.numero}")
            
            Console.WriteLine($"Sua data de nascimento é: {novapf.dataNascimento}")


            bool idadeValida = novapf.validarDataNascimento(novapf.dataNascimento);
            Console.WriteLine(idadeValida);

            if(idadeValida == true){
                System.Console.WriteLine($"Cadastro aprovado");
            }else{
                System.Console.WriteLine($"Cadastro reprovado");
            }
        }
        
    }


}



