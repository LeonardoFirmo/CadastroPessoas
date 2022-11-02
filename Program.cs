using System;
using System.Threading;
using System.Collections.Generic;

namespace UC12_SA2
{
    class Program
    {
        static void Main(string[] args)
        {

            List<PessoaFisica> listaPf = new List<PessoaFisica>();
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
|                  PESSOA FÍSICA                       |
|              1 - Cadastrar Pessoa Física             |
|              2 - Listar Pessoa Física                |
|              3 - Remover Pessoa Física               |
|                                                      |
|                  PESSOA JURÍDICA                     |
|              4 - Cadastrar Pessoa Jurídica           |
|              5 - Listar Pessoa Jurídica              |
|              6 - Remover Pessoa Jurídica             |
|                                                      |
|              0- Sair                                 |
|                                                      |
========================================================
");
        opcao = Console.ReadLine();


            switch (opcao){
                case "1":
                    
                    Endereco endPf = new Endereco();
                    Console.WriteLine($"Digite seu logradouro");
                    endPf.logradouro = Console.ReadLine();

                    Console.WriteLine($"Digite o número");
                    endPf.numero = int.Parse(Console.ReadLine());

                    Console.WriteLine($"Digite o complemento (aperte ENTER para vazio)");
                    endPf.complemento = Console.ReadLine();


                    Console.WriteLine($"Este endereço é comercial? S/N");
                    string endComercial = Console.ReadLine().ToUpper();

                    if (endComercial == "S"){
                        endPf.enderecoComercial = true;
                    }else{
                        endPf.enderecoComercial = false;
                    }

                    // endPf.logradouro = "Rua Akira";
                    // endPf.numero = 100;
                    // endPf.complemento="Próximo a tokyo";
                    // endPf.enderecoComercial = false;


                    PessoaFisica novapf = new PessoaFisica();
                    Console.WriteLine($"Digite seu CPF (Somente Números)");
                    novapf.cpf= Console.ReadLine();

                    Console.WriteLine($"Digite seu nome");
                    novapf.nome= Console.ReadLine();

                    // novapf.endereco = Console.ReadLine();

                    Console.WriteLine($"Digite sua data de nascimento");
                    novapf.dataNascimento = DateTime.Parse(Console.ReadLine());
                   
                    novapf.salario = 7000;


                    bool idadeValida = novapf.validarDataNascimento(novapf.dataNascimento);
                    Console.WriteLine(idadeValida);

                    if(idadeValida == true){
                       

                        System.Console.WriteLine($"Cadastro aprovado");
                        listaPf.Add(novapf);
                        Console.WriteLine(novapf.PagarImposto(novapf.salario));
                    }else{
                        System.Console.WriteLine($"Cadastro reprovado");
                    }
                    break;

                case "2":

                    foreach (var cadaItem in listaPf)
                    {
                        Console.WriteLine($"{cadaItem.nome}, {cadaItem.cpf}, {cadaItem.dataNascimento}");
                    }

                    break;
                
                case "3":

                    Console.WriteLine($"Digite o CPF que deseja remover");
                    string cpfProcurado = Console.ReadLine();

                    PessoaFisica pessoaEncontrada = listaPf.Find(cadaItem => cadaItem.cpf == cpfProcurado);
                    if(pessoaEncontrada != null){
                        listaPf.Remove(pessoaEncontrada);
                        Console.WriteLine($"Cadastro Removido");
                    }else{
                        Console.WriteLine($"CPF não encontrado");
                    }
                break;


                case "4":
                        
                    Endereco endPj = new Endereco();
                    endPj.logradouro = "Rua PJ";
                    endPj.numero = 500;
                    endPj.complemento= "em frente a rua pj";

                    PessoaJuridica pj = new PessoaJuridica();
                    PessoaJuridica novapj = new PessoaJuridica();
                    novapj.cnpj= "12345678900001";
                    novapj.razaoSocial = "Pessoa juridica RS";
                    novapj.endereco = endPj;
                    novapj.salario = 8000;
                    
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



