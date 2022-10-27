using System;
using System.Threading;

namespace UC12_SA2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.BackgroundColor = ConsoleColor.White;    
            Console.WriteLine(@$"
========================================================
|            Bem vindo ao sistema de cadastro          |
|            de pessoa física e pessoa jurídica        |
========================================================
");
            BarraCarregamento("Iniciando");
            

            
        string? opcao;
        do{
            Console.WriteLine(@$"
========================================================
|            Escolha uma das opções abaixo             |
|              1 - Pessoa Física                       |
|              2 - Pessoa Jurídica                     |
|              0 - Sair                                |
|                                                      |
========================================================
");
        opcao = Console.ReadLine();


            switch (opcao){
                case "1":
                    
                    Endereco endPf = new Endereco();
                    endPf.logradouro = "Rua Akira";
                    endPf.numero = 100;
                    endPf.complemento="Próximo a tokyo";
                    endPf.enderecoComercial = false;


                    PessoaFisica novapf = new PessoaFisica();
                    novapf.cpf= "12354546";
                    novapf.dataNascimento = new DateTime(2000, 01, 23);
                    novapf.nome= "Pessoa física";
                    novapf.endereco = endPf;


                    bool idadeValida = novapf.validarDataNascimento(novapf.dataNascimento);
                    Console.WriteLine(idadeValida);

                    if(idadeValida == true){
                        System.Console.WriteLine($"Cadastro aprovado");
                    }else{
                        System.Console.WriteLine($"Cadastro reprovado");
                    }
                    break;


                case "2":
                        
                    Endereco endPj = new Endereco();
                    endPj.logradouro = "Rua PJ";
                    endPj.numero = 500;
                    endPj.complemento= "em frente a rua pj";

                    PessoaJuridica pj = new PessoaJuridica();
                    PessoaJuridica novapj = new PessoaJuridica();
                    novapj.cnpj= "12345678900001";
                    novapj.razaoSocial = "Pessoa juridica RS";
                    novapj.endereco = endPj;
                    
                    break;

                case "0":
                        Console.WriteLine(@$"Obrigado por utilizar o nosso sistema");
                        BarraCarregamento("Finalizando");
                       

                    break;

                default:
                    Console.WriteLine($"Opção inválida, digite uma opção válida");
                    break;
            }
            
        } while (opcao != "0");

        
            
       

       















            // Console.WriteLine($"Rua: {novapf.endereco.logradouro}, {novapf.endereco.numero}")
            
            // Console.WriteLine($"Sua data de nascimento é: {novapf.dataNascimento}")


          

            // pj.ValidarCNPJ(novapj.cnpj);

            // if(pj.ValidarCNPJ(novapj.cnpj)){
            //     Console.WriteLine("CNPJ é válido");
            // }else{
            //     Console.WriteLine("CNPJ é inválido");

            // }
            
        }
        

        static void BarraCarregamento(string textoCarregamento){

            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write(textoCarregamento);
            Thread.Sleep(500);
            

            for (int i = 0; i < 10; i++)
            {
                Console.Write(@$".");
                Thread.Sleep(500);
               
            }
             Console.ResetColor();

        }
    }


}



