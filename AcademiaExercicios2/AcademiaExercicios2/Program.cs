namespace AcademiaExercicios2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                /* QUESTAO 01
               
                double baseT, alturaT;
                Console.Write("Informe a base do triângulo: ");
                baseT = double.Parse(Console.ReadLine());
                Console.Write("Informe a altura do triângulo: ");
                alturaT = double.Parse(Console.ReadLine());
                if (baseT > 0 && alturaT > 0)
                {
                    Console.WriteLine("Área do triângulo: " + (baseT * alturaT) / 2);
                }
                else
                {
                    Console.WriteLine("A área e/ou altura do triângulo precisam ser maiores que zero");
                }
                */

                /* QUESTAO 02
                /*
                int num;
                Console.Write("Informe um número: ");
                num = int.Parse(Console.ReadLine());
                if (num % 2 == 0)
                {
                    Console.WriteLine("Número par!");
                }
                else
                {
                    Console.WriteLine("Número ímpar!");
                }
                */

                /* QUESTAO 03
               
                int media=0;
                int[] valores = new int[4];
                for (int i = 0; i < 4; i++)
                {
                    Console.Write("Informe o Valor " + i + ": ");
                    valores[i] = int.Parse(Console.ReadLine());
                    media += valores[i];
                }
                media /= 4;
                Console.WriteLine("\nMédia: " + media);
                for (int i = 0; i < 4; i++)
                {
                    if (valores[i] > media) {
                        Console.WriteLine("\nValor {0} é maior que a média!", i);
                    }
                }
                */

                /* QUESTAO 04
                

                
                double[] valorProf = new double[2], salProf = new double[2];
                int[] horaProf = new int[2];
                for (int i = 0; i < 2; i++)
                {
                    Console.Write("Informe as horas/aula do Professor {0}: ", i+1);
                    horaProf[i] = int.Parse(Console.ReadLine());
                    Console.Write("Informe o valor da hora/aula do Professor {0}: ", i);
                    valorProf[i] = double.Parse(Console.ReadLine());

                    Console.Clear();
                    salProf[i] = valorProf[i] * horaProf[i];
                }

                if (salProf[0] > salProf[1])
                {
                    Console.WriteLine("Professor 1 tem o salário maior que o professor 2");
                }
                else
                {
                    Console.WriteLine("Professor 2 tem o salário maior que o professor 1");
                }
                */

                /* QUESTAO 05
               
                double n1, n2, media, exame, mediaFinal;
                Console.Write("Informe a Nota 1: ");
                n1 = double.Parse(Console.ReadLine());

                Console.Write("Informe a Nota 2: ");
                n2 = double.Parse(Console.ReadLine());
                media = (n1 + n2) / 2;
                if (media >= 7)
                {
                    Console.WriteLine("Aprovado com média " + media + "!");
                }
                else
                {
                    Console.Write("Informe a nota do exame: ");
                    exame = double.Parse(Console.ReadLine());
                    mediaFinal = (media + exame) / 2;
                    if ( mediaFinal >= 5)
                    {
                        Console.WriteLine("Aprovado com média " + mediaFinal + "!");
                    }
                    else
                    {
                        Console.WriteLine("Reprovado com média " + mediaFinal + "...");
                    }
                }
                */

                /* QUESTAO 06
                 
                string nome;
                double altura, peso, imc;
                Console.Write("Informe seu nome: ");
                nome = Console.ReadLine().ToUpper();

                Console.Write(nome + ", informe seu peso: ");
                peso = double.Parse(Console.ReadLine());

                Console.Write(nome + ", informe sua altura: ");
                altura = double.Parse(Console.ReadLine());
                Console.Clear();
                imc = peso / (altura * altura);
                if (imc < 18)
                {
                    Console.WriteLine(nome + ", seu I.M.C. é de " + imc.ToString("F") + " e você está abaixo do peso ideal...");
                }
                else if (imc > 18 && imc < 25)
                {
                    Console.WriteLine(nome + ", seu I.M.C. é de " + imc.ToString("F") + " e você está no peso ideal!");
                }
                else if (imc > 25 && imc < 30)
                {
                    Console.WriteLine(nome + ", seu I.M.C. é de " + imc.ToString("F") + " e você está com sobrepeso...");
                }
                else if (imc > 30 && imc < 35)
                {
                    Console.WriteLine(nome + ", seu I.M.C. é de " + imc.ToString("F") + " e você está obeso...");
                }
                else if (imc > 35)
                {
                    Console.WriteLine(nome + ", seu I.M.C. é de " + imc.ToString("F") + " e você está com um grau sério de obesidade...");
                }            
                */

                /* QUESTAO 07
                 
                string palavra, frase;
                bool busca;
                Console.Write("Por favor, digite uma frase: ");
                frase = Console.ReadLine();

                Console.Write("Por favor, digite a palavra que deseja encontrar: ");
                palavra = Console.ReadLine();
                busca = frase.Contains(palavra);
                if (busca)
                {
                    Console.WriteLine("A palavra '" + palavra + "' está presente na frase!");
                }
                else
                {
                    Console.WriteLine("A palavra '" + palavra + "' não foi encontrada na frase!");
                }
                */

                /* QUESTAO 08
                 
                string codigo, nome;
                double salarioBase, salarioFinal, totalVendas;
                Console.Write("Digite o código do funcionário: ");
                codigo = Console.ReadLine();

                Console.Write("Digite o nome do funcionário: ");
                nome = Console.ReadLine();

                Console.Write("Digite o salário base do funcionário " + nome + ": ");
                salarioBase = double.Parse(Console.ReadLine());

                Console.Write("Digite o total em vendas do funcionário " + nome + ": ");
                totalVendas = double.Parse(Console.ReadLine());
                Console.Clear();
                if (totalVendas > 500 && totalVendas < 1000)
                {
                    salarioFinal = salarioBase + (totalVendas * 0.05);
                    Console.WriteLine("O funcionário {0} receberá uma comissão de 5% e seu salário final será {1:C}", nome, salarioFinal);
                }
                else if (totalVendas > 1000 && totalVendas < 5000)
                {
                    salarioFinal = salarioBase + (totalVendas * 0.07);            
                    Console.WriteLine("O funcionário {0} receberá uma comissão de 7% e seu salário final será {1:C}", nome, salarioFinal);
                }
                else if (totalVendas > 5000)
                {
                    salarioFinal = salarioBase + (totalVendas * 0.1);                
                    Console.WriteLine("O funcionário {0} receberá uma comissão de 10% e seu salário final será {1:C}", nome, salarioFinal);
                }
                else
                {
                    salarioFinal = salarioBase;                
                    Console.WriteLine("O funcionário {0} não bateu a meta e não receberá comissão. Seu salário final será {1:C}", nome, salarioFinal);
                }
                */

                /* QUESTAO 09
                
                double[] glicemia = new double[3];
                double mediaDiaria=0;
                bool menorQue65 = false, maiorQue250 = false;
                for (int i = 0; i < 3; i++)
                {
                    Console.Write("Informe o {0}º valor da glicemia em jejum: ", i+1);
                    glicemia[i] = double.Parse(Console.ReadLine());
                    mediaDiaria += glicemia[i];

                    if (glicemia[i] < 65) { menorQue65 = true; }
                    if (glicemia[i] > 250) { maiorQue250 = true; }
                }
                mediaDiaria /= 3;
                Console.Clear();
                if (menorQue65)
                {
                    Console.WriteLine("Um dos seus valores está abaixo de 65.\nVocê corre risco de Hipoglicemia!");
                }
                if (maiorQue250)
                {
                    Console.WriteLine("Um dos seus valores está acima de 250.\nVocê corre risco de Hiperglicemia!");
                }
                if (mediaDiaria < 80)
                {
                    Console.WriteLine("A sua média está em " + mediaDiaria.ToString("F") + " e você deve diminuir 2 unidades de insulina");
                }
                else if (mediaDiaria > 150)
                {
                    Console.WriteLine("A sua média está em " + mediaDiaria.ToString("F") + " e você deve adicionar 2 unidades de insulina");
                }            
                */

                /* QUESTAO 10
                 
                string[] nomes = new string[2];            
                int[] idades = new int[2];
                int indiceMaisNovo=0, indiceMaisAlto=0, idadeMaisNovo=100;
                double[] alturas = new double[2];
                double alturaMaisAlto=0;

                for (int i = 0; i < 2; i++)
                {
                    Console.Write("Informe o nome do atleta {0}: ", i+1);
                    nomes[i] = Console.ReadLine();
                    Console.Write("Informe a idade do atleta {0}: ", i+1);
                    idades[i] = int.Parse(Console.ReadLine());

                    if (idades[i] < idadeMaisNovo) { 
                        idadeMaisNovo = idades[i];
                        indiceMaisNovo = i; 
                    }                
                    Console.Write("Informe a altura do atleta {0}: ", i+1);
                    alturas[i] = double.Parse(Console.ReadLine());
                    if (alturas[i] > alturaMaisAlto) { 
                        alturaMaisAlto = alturas[i];
                        indiceMaisAlto = i; 
                    }
                    Console.WriteLine();
                }
                Console.Clear();

                Console.WriteLine("\nAtleta mais novo: ");
                Console.WriteLine(nomes[indiceMaisNovo]);
                Console.WriteLine(idades[indiceMaisNovo] + " anos");
                Console.WriteLine("{0:0.00m}", alturas[indiceMaisNovo]);
                Console.WriteLine("\n-------------------\n");
                Console.WriteLine("Atleta mais alto: ");
                Console.WriteLine(nomes[indiceMaisAlto]);
                Console.WriteLine(idades[indiceMaisAlto] + " anos");
                Console.WriteLine("{0:0.00}m",alturas[indiceMaisAlto]);
                */

                /* QUESTAO 11
                
                int hora, minuto;
                bool valido = false;
                Console.Write("Informe a hora: ");
                hora = int.Parse(Console.ReadLine());

                Console.Write("Informe os minutos: ");
                minuto = int.Parse(Console.ReadLine());
                if (hora >= 0 && hora <= 23)
                {
                    valido = true;
                }
                if (minuto >= 0 && minuto <= 59)
                {
                    valido = true;
                }
                if (valido == true)
                {
                    Console.WriteLine("{0:00}:{1:00} é uma hora válida!", hora, minuto);
                }
                */

                /* QUESTAO 12
               
                string codigo;
                int numeroHoras;
                double salario, extra, salarioFinal=0;
                Console.Write("Informe o código do funcionário: ");
                codigo = Console.ReadLine();

                Console.Write("Informe o número de horas trabalhadas do funcionário: ");
                numeroHoras = int.Parse(Console.ReadLine());
                if (numeroHoras < 50)
                {
                    salarioFinal = numeroHoras * 10;
                }
                if (numeroHoras > 50)
                {
                    numeroHoras -= 50;
                    salario = 10 * 50;
                    extra = numeroHoras * 20;
                    salarioFinal = salario + extra;
                }
                Console.WriteLine("Salário final do funcionário: " + salarioFinal.ToString("C"));
                */

                /* QUESTAO 13
                 
                double h, pesoIdeal;
                char sexo;
                Console.Write("Você é do sexo (M)asculino ou (F)eminino? ");
                sexo = char.Parse(Console.ReadLine());

                Console.Write("Informe sua altura: ");
                h = double.Parse(Console.ReadLine());
                if (sexo == 'm' || sexo == 'M')
                {
                    pesoIdeal = (72.7 * h) - 58;
                    Console.WriteLine("Peso ideal: " + pesoIdeal.ToString("F") + "Kg");
                }
                else if (sexo == 'f' || sexo == 'F')
                {
                    pesoIdeal = (62.1 * h) - 44.7;
                    Console.WriteLine("Peso ideal: " + pesoIdeal.ToString("F") + "Kg");
                }
                else
                {
                    Console.WriteLine("Informe um sexo válido!\nM para masculino ou F para feminino");
                }
                /*
                /* QUESTAO 14
                
                double tamanhoArq, velocidadeInternet, minutos;
                Console.Write("Informe o tamanho do arquivo (em MB): ");
                tamanhoArq = double.Parse(Console.ReadLine());
                Console.Write("Informe a velocidade da conexão (em Mbp/s): ");
                velocidadeInternet = double.Parse(Console.ReadLine());
                minutos = tamanhoArq / velocidadeInternet;

                Console.WriteLine("Tempo de download: {0:0.00} minutos.", minutos);
                */

                /* QUESTAO 15
                
                double metrosQuadrados, latas, valor;
                Console.Write("Informe a área a ser pintada (em m²): ");
                metrosQuadrados = double.Parse(Console.ReadLine());
                latas = Math.Ceiling(metrosQuadrados / 54);
                valor = latas * 80;
                if (latas == 1)
                {
                    Console.WriteLine("\nSerá necessária " + latas  + " lata de 18L no valor de " + valor.ToString("C"));
                }
                else if (latas > 1)
                {
                    Console.WriteLine("\nSerão necessárias " + latas  + " latas de 18L no valor de " + valor.ToString("C"));
                }
                */

                /* QUESTAO 16
                
                int timeDaCasa, timedeFora;
                Console.Write("Informe a quantidade de gols do time da casa: ");
                timeDaCasa = int.Parse(Console.ReadLine());

                Console.Write("Informe a quantidade de gols do time de fora: ");
                timedeFora = int.Parse(Console.ReadLine());
                if (timedeFora >= timeDaCasa + 2)
                {
                    Console.WriteLine("\nO time de fora já se classificou");
                }
                else
                {
                    Console.WriteLine("\nOs times se enfrentarão em um novo jogo\n\n");
                    Console.Write("Informe a quantidade de gols do time da casa: ");
                    timeDaCasa = int.Parse(Console.ReadLine());

                    Console.Write("Informe a quantidade de gols do time de fora: ");
                    timedeFora = int.Parse(Console.ReadLine());

                    if (timeDaCasa > timedeFora)
                    {
                        Console.Clear();
                        Console.WriteLine("Time da casa passou de fase!");
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Time de fora passou de fase!");
                    }
                }
                */

                /* QUESTAO 17
                
                int ladoA, ladoB, ladoC;
                Console.Write("Informe o lado A do triângulo: ");
                ladoA = int.Parse(Console.ReadLine());

                Console.Write("Informe o lado B do triângulo: ");
                ladoB = int.Parse(Console.ReadLine());

                Console.Write("Informe o lado C do triângulo: ");
                ladoC = int.Parse(Console.ReadLine());
                if (ladoA < (ladoB + ladoC) && ladoB < (ladoA + ladoC) && ladoC < (ladoA + ladoB))
                {
                    Console.Write("\nÉ um triângulo ");
                    if (ladoA == ladoB && ladoB == ladoC)
                    {
                        Console.WriteLine("equilátero");
                    }
                    else if (ladoA == ladoB || ladoA == ladoC || ladoB == ladoC)
                    {
                        Console.WriteLine("isósceles");
                    }
                    else
                    {
                        Console.WriteLine("escaleno");
                    }
                }
                else
                {
                    Console.WriteLine("Não é um triângulo!");
                }
                */

                /* QUESTAO 18
          
                //versão com inteiros
                /*
                int valor1, valor2, valor3;
                Console.Write("Informe o valor 1: ");
                valor1 = int.Parse(Console.ReadLine());

                Console.Write("Informe o valor 2: ");
                valor2 = int.Parse(Console.ReadLine());

                Console.Write("Informe o valor 3: ");
                valor3 = int.Parse(Console.ReadLine());
                if (valor1 > valor2 && valor1 > valor3)
                {
                    Console.WriteLine("\n" + valor1 + " é o maior valor.");
                }
                else if (valor2 > valor1 && valor2 > valor3)
                {
                    Console.WriteLine("\n" + valor2 + " é o maior valor.");
                }
                else if (valor3 > valor1 && valor3 > valor2)
                {
                    Console.WriteLine("\n" + valor3 + " é o maior valor.");
                }
                */

                //------------------

                //versão com strings
                /*
                string valor1, valor2, valor3;
                int tamVal1, tamVal2, tamVal3;
                Console.Write("Informe o valor 1: ");
                valor1 = Console.ReadLine();
                Console.Write("Informe o valor 2: ");
                valor2 = Console.ReadLine();
                Console.Write("Informe o valor 3: ");
                valor3 = Console.ReadLine();
                tamVal1 = valor1.Length;
                tamVal2 = valor2.Length;
                tamVal3 = valor3.Length;
               if (tamVal1 > tamVal2 && tamVal1 > tamVal3)
                {
                    Console.WriteLine("\n'" + valor1 + "' é o maior valor com " + tamVal1 + " caracteres.");
                }
               else if (tamVal2 > tamVal1 && tamVal2 > tamVal3)
                {
                    Console.WriteLine("\n'" + valor2 + "' é o maior valor com " + tamVal2 + " caracteres.");
                }
               else if (tamVal3 > tamVal1 && tamVal3 > tamVal2)
                {
                    Console.WriteLine("\n'" + valor3 + "' é o maior valor com " + tamVal3 + " caracteres.");
                }
                */

                /* Exercício 19
                 * Ajuste o exercício 18 de maneira que mostre os valores informados em ordem crescente.
                 */

                /*
                int valor1, valor2, valor3;
                string maior="", meio="", menor="";
                Console.Write("Informe o valor 1: ");
                valor1 = int.Parse(Console.ReadLine());
                Console.Write("Informe o valor 2: ");
                valor2 = int.Parse(Console.ReadLine());
                Console.Write("Informe o valor 3: ");
                valor3 = int.Parse(Console.ReadLine());
                if (valor1 > valor2 && valor1 > valor3)
                {
                    maior = "Valor 1: " + valor1;
                    if (valor2 > valor3)
                    {
                        meio = "Valor 2: " + valor2;
                        menor = "Valor 3: " + valor3;
                    }
                    else
                    {
                        meio = "Valor 3: " + valor3;
                        menor = "Valor 2: " + valor2;
                    }
                }
                else if (valor2 > valor1 && valor2 > valor3)
                {
                    maior = "Valor 2: " + valor2;
                    if (valor1 > valor3)
                    {
                        meio = "Valor 1: " + valor1;
                        menor = "Valor 3: " + valor3;
                    }
                    else
                    {
                        meio = "Valor 3: " + valor3;
                        menor = "Valor 1: " + valor1;
                    }
                }
                else if (valor3 > valor1 && valor3 > valor2)
                {
                    maior = "Valor 3: " + valor3;
                    if (valor1 > valor2)
                    {
                        maior = "Valor 1: " + valor1;
                        menor = "Valor 2: " + valor2;
                    }
                    else
                    {
                        meio = "Valor 2: " + valor2;
                        menor = "Valor 1: " + valor1;
                    }
                }
                Console.Clear();
                Console.WriteLine("Números em ordem crescente: ");
                Console.WriteLine(maior);
                Console.WriteLine(meio);
                Console.WriteLine(menor);
                */

                /* QUESTAO 20
             
                int numSecreto = 10, tentativas = 3, opcao;
                Console.WriteLine("Bem vindo ao jogo Número Secreto!");
                Console.WriteLine("---------------------------------");
                do
                {
                    Console.Write("Digite a sua tentativa: ");
                    opcao = int.Parse(Console.ReadLine());
                    if (opcao != numSecreto)
                    {
                        tentativas -= 1;
                        Console.WriteLine("\nVocê errou!");
                        if (numSecreto > opcao)
                        {
                            Console.WriteLine("O número secreto é maior!");
                        }
                        else
                        {
                            Console.WriteLine("O número secreto é menor!");
                        }
                        if (tentativas > 1)
                        {
                            Console.WriteLine("Você possui mais " + tentativas + " tentivas...\n");
                        }
                        else if (tentativas == 0)
                        {
                            Console.WriteLine("\n");
                        }
                        else
                        {
                            Console.WriteLine("Sua última tentativa!\n");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Parabéns! Você acertou o número secreto!");
                        break;
                    }                
                }
                while (tentativas > 0);
                */

            }
        }
    }
}
    }
}