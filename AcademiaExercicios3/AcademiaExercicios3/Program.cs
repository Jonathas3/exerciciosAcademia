namespace AcademiaExercicios3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Questao 01
           static void Main(string[] args)
           {
           int numero;
           do
           {
               Console.WriteLine("Digite um numero inteiro: ");
               numero = int.Parse(Console.ReadLine());
               if (numero <= 0)
               {
                   Console.WriteLine("Numero invalido. Vai precisar redigitar!");
               }
               else break;
           } while (true);
           Console.Write("\n\n os pares entre 1 e " + numero + " sao: ");
           for (int i = 1; i <= numero; i++)
           {
               if (i % 2 == 0)
               Console.Write(i + " ");
           }
           }*/

            /*Questao 02
            static void Main(string[] args)
            {
                int numero;

                do
                {
                    Console.WriteLine("Digite um numero inteiro: ");
                    numero = int.Parse(Console.ReadLine());
                    if (numero <= 0)
                    {
                        Console.WriteLine("Numero invalido. Vai precisar redigitar!");
                    }
                    else break;
                } while (true);
                Console.Write("\n\n os pares entre 1 e " + numero + " sao: ");
                for (int i = 1; i <= numero; i++)
                {
                    if (i % 2 == 0)
                        Console.Write(i + " ");
                }
                Console.WriteLine("\n\n Deseja informar outro número (s/n)?");
                Console.ReadLine();
                Console.WriteLine("Digite um número inteiro positivo: ");
                numero = int.Parse(Console.ReadLine());
                if (numero <= 0)
                {
                    Console.WriteLine("Numero invalido. Vai precisar redigitar!");
                }
                Console.Write("\n\n os pares entre 1 e " + numero + " sao: ");
                for (int i = 1; i <= numero; i++)
                {
                    if (i % 2 == 0)
                        Console.Write(i + " ");
                }
                Console.WriteLine("\n\n Deseja informar outro número (s/n)?");
                Console.ReadLine();
            }*/

            /*Questao 03
            static void Main(string[] args)
            {
                int numero;
                do
                {
                    Console.WriteLine("Digite um numero inteiro: ");
                    numero = int.Parse(Console.ReadLine());
                    if (numero <= 0)
                    {
                        Console.WriteLine("Numero invalido. Vai precisar redigitar!");
                    }
                    else break;
                } while (true);
                Console.Write("\n\n Os pares entre 1 e " + numero + " sao: ");
                for (int i = 1; i <= numero; i++)
                {
                    if (i % 2 == 0)
                        Console.Write(i + " ");
                }
                Console.Write("\n\n Os impares entre 1 e " + numero + " sao: ");
                for (int i = 1; i <= numero; i++)
                {
                    if (i % 2 != 0)
                        Console.Write(i + " ");
                }
                Console.Write("\n\n Os primos entre 1 e " + numero + " sao: ");
                for (int i = 1; i <= numero; i++)
                {
                    if (numero % i == 0)
                        Console.Write(i + " ");
                }
            }*/


            /* Questao 04
            /*
            int joao=0, zeca=0, brancos=0;
            string opcao="";
            
            while (opcao != "FIM")
            {
                if (opcao != "JOAO" && opcao != "ZECA" && opcao != "BRANCO" && opcao != "")
                {
                    Console.Clear();
                   
                    Console.WriteLine("Opção inválida\n");
                    Console.WriteLine("Escolha uma opção de voto:\n");
                    Console.WriteLine("JOAO para votar em João");
                    Console.WriteLine("ZECA para votar em Zeca");
                    Console.WriteLine("BRANCO para votar em branco");
                    Console.WriteLine("FIM para encerrar a votação");
                    Console.Write("\nInforme sua opção: ");
                    opcao = Console.ReadLine().ToUpper();
                }
                if (opcao == "JOAO" || opcao == "ZECA" || opcao == "BRANCO" || opcao == "")
                {
                    Console.Clear();
                    
                    Console.WriteLine("Escolha uma opção de voto:\n");
                    Console.WriteLine("JOAO para votar em João");
                    Console.WriteLine("ZECA para votar em Zeca");
                    Console.WriteLine("BRANCO para votar em branco");
                    Console.WriteLine("FIM para encerrar a votação");
                    Console.Write("\nInforme sua opção: ");
                    opcao = Console.ReadLine().ToUpper();
                    switch (opcao)
                    {
                        case "JOAO":
                            joao++;
                            break;
                        case "ZECA":
                            zeca++;
                            break;
                        case "BRANCO":
                            brancos++;
                            break;
                    }
                }
            }
            Console.Clear();
            Console.WriteLine("Resultado:\n");
            Console.WriteLine("João: {0}",joao);
            Console.WriteLine("Zeca: {0}",zeca);
            Console.WriteLine("\nVotos brancos: {0}",brancos);
            */

            /* Questao 05
            /*
            int joao = 0, zeca = 0, brancos = 0, nulos=0, total=0;
            string opcao = "";
            while (opcao != "FIM")
            {                
                Console.Clear();
                
                Console.WriteLine("Escolha uma opção de voto:\n");
                Console.WriteLine("JOAO para votar em João");
                Console.WriteLine("ZECA para votar em Zeca");
                Console.WriteLine("BRANCO para votar em branco");
                Console.WriteLine("FIM para encerrar a votação");
                Console.WriteLine("Atenção: Qualquer outro valor diferente desse ANULA o seu voto!");
                Console.Write("\nInforme sua opção: ");
                opcao = Console.ReadLine().ToUpper();
                switch (opcao)
                {
                    case "JOAO":
                        joao++;                        
                        break;
                    case "ZECA":
                        zeca++;
                        break;
                    case "BRANCO":
                        brancos++;
                        break;
                    default:
                        nulos++;
                        break;
                }
                total++;
            }            
            Console.Clear();
            Console.WriteLine("Resultado:\n");
            
            Console.WriteLine("Total de votos: {0}\n", total);
            Console.ForegroundColor = ConsoleColor.Green;
            if (joao > zeca)
            {
                Console.WriteLine("João venceu com {0} votos!", joao);
            }
            else
            {
                Console.WriteLine("Zeca venceu com {0} votos!", zeca);
            }
            Console.ResetColor();
            Console.WriteLine("\nVotos brancos: {0}", brancos);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\nVotos nulos: {0}", nulos);
            Console.ResetColor();
            */

            /* Questao 06
            /*
            int idade=0;
            while (idade <= 0)
            {
                Console.Clear();
                Console.Write("Informe uma idade: ");
                idade = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("\n{0} é uma idade válida!", idade);
            */

            /* Questao 07
             /* 
            string nome;
            int idade;
            float salario;
            do
            {​
                Console.Write("Nome: ");
                nome = Console.ReadLine();
                if (nome.Any(char.IsDigit) || string.IsNullOrWhiteSpace(nome))
                {​
                    Console.WriteLine("Digite um nome válido!!");
                }​ else
                {​
                    break;
                }​
            }​ while (true);
            do
            {​
                Console.Write("Idade: ");
                idade = int.Parse(Console.ReadLine());
                if (idade <= 0)
                {​
                    Console.WriteLine("Digite uma idade válida!!");
                }​ else
                {​
                    break;
                }​
            }​ while (true);
            do
            {​
                Console.Write("Salário: ");
                salario = float.Parse(Console.ReadLine());
                if (salario <= 0)
                {​
                    Console.WriteLine("Digite um salário válido!!");
                }​ else
                {​
                    break;
                }​
            }​ while (true);
            Console.WriteLine("Seus dados são: ");
            Console.WriteLine("Nome: " + nome.ToUpper());
            Console.WriteLine("Idade: " + idade);
            Console.WriteLine("Salário: " + salario);*/

            /* Questao 08
            /*
            int numero=0;
            char opcao = 's';
            while (opcao == 's' || opcao == 'S')
                {
                    Console.Write("Informe um número inteiro: ");
                    numero = int.Parse(Console.ReadLine());
                    while (numero < 0)
                    {
                        Console.Clear();
                        Console.Write("Informe um número inteiro: ");
                        numero = int.Parse(Console.ReadLine());            
                    }                    
                Console.Write("\nNúmeros pares entre 0 e {0}: ", numero);
                for (int i = 0; i < numero + 1; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write("{0} ",i);
                    }
                }
                Console.Write("\n\nDeseja informar outro número? (s)im ou (n)ão? ");
                opcao = char.Parse(Console.ReadLine());
                Console.Clear();
                }
                */

            /* Questao 09
            /*
            int filhos, filhos1a3=0, filhos4a7=0, filhos8=0, filhos0=0;
            for (int i = 1; i < 5; i++)     //usado 5 para fins de testes...
            {
                Console.Write("Informe quantos filhos o visitante {0} possui (0 para nenhum): ",i);
                filhos = int.Parse(Console.ReadLine());
                Console.Clear();
                if (filhos == 0)
                {
                    filhos0++;
                }
                if (filhos >= 1 && filhos <= 3)
                {
                    filhos1a3++;
                }
                if (filhos >= 4 && filhos <= 7)
                {
                    filhos4a7++;
                }
                if (filhos >= 8)
                {
                    filhos8++;
                }
            }
            Console.Clear();
            Console.WriteLine("Visitantes sem filhos: {0}", filhos0);
            Console.WriteLine("Visitantes com 1 a 3 filhos : {0}", filhos1a3);
            Console.WriteLine("Visitantes com 4 a 7 filhos : {0}", filhos4a7);
            Console.WriteLine("Visitantes com mais de 8 filhos : {0}", filhos4a7);
            //corrigindo o bug do console fechando automaticamente
            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.Read();
            */

            /* Questao 10 
            /*
            string nome;
            int idade, masculino=0, feminino=0, menosDe30=0, maior60=0, mediaIdadeMulheres=0;
            char sexo;
            for (int i = 1; i <= 5; i++)     //feito com 5 para fins de testes...
            {
                Console.Write("Informe o {0}º nome: ",i);
                nome = Console.ReadLine();
                
                Console.Write("Informe o sexo do(a) {0} (m)asculino ou (f)eminino: ", nome);
                sexo = char.Parse(Console.ReadLine());
                
                Console.Write("Informe a idade do(a) {0}: ", nome);
                idade = int.Parse(Console.ReadLine());
                Console.Clear();
                if (sexo == 'm' || sexo == 'M') { masculino++; }
                if (sexo == 'f' || sexo == 'F')
                {
                    feminino++;
                    mediaIdadeMulheres += idade;
                }
                if (idade < 30) { menosDe30++; }
                else if (idade > 60) { maior60++; }
            }
            mediaIdadeMulheres = mediaIdadeMulheres / feminino;
            Console.Clear();
            Console.WriteLine("Pessoas do sexo masculino: " + masculino);
            Console.WriteLine("Pessoas do sexo feminino: " + feminino);
            Console.WriteLine("Pessoas com menos de 30 anos: " + menosDe30);
            Console.WriteLine("Pessoas com mais de 60 anos: " + maior60);
            Console.WriteLine("Média de idade das mulheres: " + mediaIdadeMulheres);
            //corrigindo o bug do console fechando automaticamente
            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.Read();
            */

            /* Questao 11
            /*
            double nota=0, notaMaisAlta=0, notaMaisBaixa=10, media=0;
            int quantidade=0;
            while (nota != -1)
            {
                    Console.Write("Informe a nota do(a) aluno(a) (use -1 para encerrar): ");
                    nota = double.Parse(Console.ReadLine());
                    if (nota > notaMaisAlta) { notaMaisAlta = nota; }
                    if (nota < notaMaisBaixa && nota > -1) { notaMaisBaixa = nota; }
                    if (nota > -1)
                    {                
                        media += nota;
                        quantidade++;
                    }
            }
            media = media / quantidade;
            Console.WriteLine("\nNota mais alta: {0}", notaMaisAlta);
            Console.WriteLine("Nota mais baixa: {0}", notaMaisBaixa);
            Console.WriteLine("Média da turma: {0:0.0}", media);
            Console.WriteLine("Alunos na turma: {0}", quantidade);
            //corrigindo o bug do console fechando automaticamente
            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.Read();
            */

            /* Questao 12 

            /*
            int numeros=0;
            for (int i = 1; i <= 100; i++)
            {
                numeros += i;
            }
            Console.WriteLine(numeros);
            //corrigindo o bug do console fechando automaticamente
            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.Read();
            */

            /* Questao 13 
            /*
            int numeros=0;
            for (int i=1; i <= 500; i++)
            {
                if (i % 2 == 0)
                {
                    numeros += i;
                }
            }
            Console.WriteLine("Soma dos pares existentees entre 1 e 500: {0}", numeros);
            //corrigindo o bug do console fechando automaticamente
            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.Read();
            */

            /* Questao 14
            /*
            int potencias;
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("2^{0}: {1}",i, Math.Pow(2,i));
            }
            //corrigindo o bug do console fechando automaticamente
            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.Read();
            */

            /* Questao 15
            

            /*
            double[] notas = new double[4], pesos = {2, 1, 2, 4};
            double media=0, divisao=0;
                        
            for (int i = 0; i < pesos.Length; i++)
            {
                Console.Write("Informe a nota {0}: ", i + 1);
                notas[i] = double.Parse(Console.ReadLine());
                Console.Clear();
                media += notas[i] * pesos[i];
                divisao += pesos[i];
            }
            media = media / divisao;
            Console.WriteLine(media >= 7 ? "\nAprovado!" : "\nReprovado...");
            
            //corrigindo o bug do console fechando automaticamente
            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.Read();
            */

            /* Questao 16
            /*
            Random aleatorio = new Random();
            int numero = aleatorio.Next(1, 50);
            int aux = 0;
            Console.WriteLine("Número sorteado: {0}",numero);
            while (numero < 250)
            {
                aux = numero;
                numero *= 3;
            }
            Console.WriteLine(aux);
            */

            /* Ex. 17
             * Apresentar os quadrados dos números inteiros de 15 a 200.
             */

            /*
            for (int i = 15; i <= 200; i++)
            {
                Console.WriteLine("{0}² = {1}",i, (Math.Pow(i,2)));
            }            
            //corrigindo o bug do console fechando automaticamente
            Console.Write("\nPressione qualquer tecla para sair...");
            Console.Read();
            */

            /* Ex. 18
             * Elaborar um programa que apresente o valor de uma potência de uma base qualquer
             * elevada a um expoente qualquer, ou seja, NM.
             */

            /*
            double Base, potencia;
            Console.Write("Informe a base: ");
            Base = double.Parse(Console.ReadLine());
            
            Console.Write("Informe o expoente: ");
            potencia = double.Parse(Console.ReadLine());
            Console.WriteLine("\n{0} elevado a {1} é igual a {2}", Base, potencia, (Math.Pow(Base,potencia)));
            
            //corrigindo o bug do console fechando automaticamente
            Console.Write("\nPressione qualquer tecla para sair...");
            Console.Read();
            */

            /* Questao 19

            /*
            double salario=0, mediaSalario=0, maiorSalario=0;
            int filhos, numFilhos=0, mediaFilhos=0, salariosAteCem=0, habitantes=0;
            while (salario > -1)
            {
                Console.Clear();
                Console.WriteLine("Habitante {0}\n", habitantes);
                Console.Write("Qual o seu salário? R$");
                salario = double.Parse(Console.ReadLine());
                if (salario < 0) { break; }
                if (salario <= 100) { salariosAteCem++; }
                if (salario > maiorSalario) { maiorSalario = salario; }
                mediaSalario += salario;
                Console.Write("\nQuantos filhos você tem? ");
                filhos = int.Parse(Console.ReadLine());
                mediaFilhos += filhos;
                habitantes++;
            }
            mediaSalario /= habitantes;
            mediaFilhos /= habitantes;
            salariosAteCem = (100 * salariosAteCem) / habitantes;
            
            Console.Clear();
            Console.WriteLine("População: {0}", habitantes);
            Console.WriteLine("Média de salário da população: {0:C}",mediaSalario);
            Console.WriteLine("Média de filhos da população: {0}",mediaFilhos);
            Console.WriteLine("Maior salário da população: {0:C}",maiorSalario);
            Console.WriteLine("{0}% da população recebe até R$100.",salariosAteCem);
            */

            //* Questao 20



            //    int maiorIdade = 0, feminino18_35 = 0, idade = 1;
            //    char sexo, olho, cabelo;

            //    while (idade > 0)
            //    {
            //        Console.WriteLine("Informe a idade -1 para encerrar o programa.\n");

            //        Console.Write("Informe a idade: ");
            //        idade = int.Parse(Console.ReadLine());

            //        if (idade < 0) { break; }

            //        Console.Write("Informe o sexo: (m)asculino ou (f)eminino: ");
            //        sexo = char.Parse(Console.ReadLine());

            //        Console.Write("Informe a cor dos olhos: (a)zuis ou (v)erdes ou (c)astanhos: ");
            //        olho = char.Parse(Console.ReadLine());

            //        Console.Write("Informe a cor dos cabelos: (l)ouros ou (p)retos ou (c)astanhos: ");
            //        cabelo = char.Parse(Console.ReadLine());


            //        if (idade > maiorIdade) { maiorIdade = idade; }

            //        if (
            //            (sexo == 'f' || sexo == 'F')
            //            && (idade >= 18 && idade <= 35)
            //            && (olho == 'v' || olho == 'V')
            //            && (cabelo == 'l' || cabelo == 'L'))
            //        {
            //            feminino18_35++;
            //        }
            //        Console.Clear();
            //    }

            //    Console.Clear();

            //    Console.WriteLine("Maior idade dos habitantes: " + maiorIdade);
            //    Console.WriteLine("Indivíduos do sexo feminino entre 18 e 35 anos com olhos verdes e cabelos louros: " + feminino18_35);


            //}
        }



    }




}