namespace AcademiaExercicios4_Vetores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Questao 01
            /*
            int[] numeros = new int[10];
            int pares = 0, impares = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write("Informe o número da posição {0}: ", i);
                numeros[i] = int.Parse(Console.ReadLine());
                
                if (numeros[i] % 2 == 0)
                {
                    pares++;
                }
                else if (numeros[i] % 2 != 0)
                {
                    impares++;
                }
            }
            Console.Clear();
            
            Console.WriteLine("Números pares: {0}", pares);
            Console.WriteLine("Números ímpares: {0}", impares);                
            */

            /* Questao 02
            /*
            int[] vetor1 = new int[20], vetor2 = new int[20], vetorSoma = new int[20];
            for (int i = 0; i < 20; i++)
            {
                Console.Write("Informe o valor da posição {0} do Vetor 1: ",i);
                vetor1[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 20; i++)
            {
                Console.Write("Informe o valor da posição {0} do Vetor 2: ",i);
                vetor2[i] = int.Parse(Console.ReadLine());
            }
            Console.Clear();
            
            for (int i = 0; i < 20; i++)
            {
                vetorSoma[i] = vetor1[i] + vetor2[i];
                Console.WriteLine("Vetor1[{0}] + Vetor2[{0}]: {1}", i, vetorSoma[i]);                
            }
            */

            /* Questao 03
            /*
            int[] vetor = new int[20], vetorPrimo = new int[20];
            int resto, cont=0, pos=0;
            for (int i = 0; i < 20; i++)
            {
                Console.Write("Informe o valor da posição {0} do Vetor 1: ", i);
                vetor[i] = int.Parse(Console.ReadLine());
                for (int j = 0; j < vetor[i]; j++)
                {
                    resto = vetor[i] % (j + 1);
                    if (resto == 0)
                    {
                        cont++;
                    }
                }
                if (cont == 2) {
                    vetorPrimo[pos] = i;
                    pos++;
                }
                cont = 0;
            }
            Console.Write("\nPosição dos números primos: ");
            for (int i = 0; i < pos; i++)
            {
                Console.Write(vetorPrimo[i] + " ");                
            }            
            */

            /* Questao 04
             * Escreva um algoritmo que leia dois vetores de 10 posições e faça a multiplicação 
             * dos elementos de mesmo índice, colocando o resultado em um terceiro vetor. 
             * Mostre o vetor resultante.
             */

            /*
            int[] vetor1 = new int[10], vetor2 = new int[10], vetorMulti = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Informe o valor da posição {0} do Vetor 1: ", i);
                vetor1[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Informe o valor da posição {0} do Vetor 2: ", i);
                vetor2[i] = int.Parse(Console.ReadLine());
            }
            Console.Clear();
            for (int i = 0; i < 10; i++)
            {
                vetorMulti[i] = vetor1[i] * vetor2[i];
                Console.WriteLine("Vetor1[{0}] + Vetor2[{0}]: {1}", i, vetorMulti[i]);
            }
            */

            /* Questao 05
            /*
            int[] vetor = new int[80];
            int menor=1000000000, pos = 0;
            for (int i = 0; i < 5;i++)
            {
                Console.Write("Informe o {0}º número: ", i+1);
                vetor[i] = int.Parse(Console.ReadLine());
                if (vetor[i] < menor)
                {
                    menor = vetor[i];
                    pos = i;
                }
            }
            
            Console.WriteLine("O menor valor é {0} e está na posição {1} do vetor.", menor, pos);
            */

            /* Questao 06
            /*
            int[] numeros = new int[10];
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write("Informe o número da posição {0} do vetor: ", i);
                numeros[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 9; i >= 0; i--)
            {                
                Console.Write("\n" + numeros[i] + " ");
            }
            */

            /* Questao 07
            /*
            int[] numeros = new int[10];
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write("Informe o número da posição {0} do vetor: ", i);
                numeros[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] % 2 == 0)
                {
                    Console.Write(numeros[i] + " ");
                }
            }
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] % 2 != 0)
                {
                    Console.Write(numeros[i] + " ");
                }
            }
            */

            /* Questao 08
            /*
            double[] numeros = new double[30];
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write("Informe o número da posição {0} do vetor: ", i);
                numeros[i] = double.Parse(Console.ReadLine());
            }
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] < 0) {
                    Console.Write(i + 1 + " ");
                }
            }
            */

            /* Questao 09 
            int[] numeros = new int[10], ordem = new int[10];            
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write("Informe o número da posição {0} do vetor: ", i);
                numeros[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(numeros);
            Console.WriteLine("Vetor em ordem crescente:\n");
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write("{0} ", numeros[i]);
            }
            /*
            for (int i = 0; i < ordem.Length; i++)
            {
                for (int j = 0; j < numeros.Length; j++)
                {
                    if (numeros[j] < menor && numeros[j] < ordem[i])
                    {
                        menor = numeros[j];
                    }
                }
                ordem[i] = menor;
                menor = ordem[i];
            }
            for (int i = 0; i < ordem.Length; i++)
            {
                Console.Write("{0} | ",ordem[i]);
            }
            */

            /* Questao 10
            /*
            int[] numeros = new int[20], validados = new int[20];
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write("Informe o número da posição {0} do vetor: ", i);
                numeros[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] == 0 || numeros[i] == null)
                {
                    validados[i] = 2;
                }
                else
                {
                    validados[i] = numeros[i];
                }                
            }
            Console.Clear();
            
            for (int i = 0; i < validados.Length; i++)
            {
                Console.WriteLine("Valor do vetor na posição {0}: {1}",i, numeros[i]);
            }
            
            Console.WriteLine("--------------------------------");
            
            for (int i = 0; i < validados.Length; i++)
            {
                Console.WriteLine("Valor do vetor validado na posição {0}: {1}",i, validados[i]);
            }
            */

            /* Questao 11
            /*
            int[] numeros = new int[5];
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write("Informe o número da posição {0} do vetor: ", i);
                numeros[i] = int.Parse(Console.ReadLine());
            }
            for (int i = numeros.Length - 1; i >= 0; i--)
            {
                Console.Write("\n" + numeros[i] + " ");
            }
            */

            /* Questao 12
            /*
            int[] numeros = new int[10];
            int busca, pos=0;
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write("Informe o número da posição {0} do vetor: ", i);
                numeros[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("\nQual número deseja procurar no vetor? ");
            busca = int.Parse(Console.ReadLine());
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] == busca)
                {
                    pos = i;
                }
            }
            Console.Clear();
            if (pos != 0)
            {
                Console.WriteLine("O número {0} encontra-se na posição {1} do vetor!", busca, pos);
            }
            else
            {
                Console.WriteLine("O número {0} não existe no vetor...", busca);
            }
            */

            /* Questao 13
            /*
            int[] numeros = new int[100];
            int dois=0, quatro=0, oito=0;
            Console.WriteLine("Digite -1 ou 100 números para encerrar o programa");
            
            for (int i = 0; i < numeros.Length; i++) {
                
                Console.Write("Digite um número: ");
                numeros[i] = int.Parse(Console.ReadLine());
                if (numeros[i] == -1)
                {
                    break;
                }
                if (numeros[i] == 2) { dois++; }
                if (numeros[i] == 4) { quatro++; }
                if (numeros[i] == 8) { oito++; }                
            }
            Console.Clear();
            Console.WriteLine("O número 2 apareceu {0} vezes.", dois);
            Console.WriteLine("O número 4 apareceu {0} vezes.", quatro);
            Console.WriteLine("O número 8 apareceu {0} vezes.", oito);
            */

            /* Questao 14
            /*
            int codigo=0, numeros=0;
            int[] vetor = new int[50];
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Clear();
                Console.WriteLine("0: Encerra o programa");
                Console.WriteLine("1: Encerra o programa e mostra os números na ordem que foram digitadas");
                Console.WriteLine("2: Encerra o programa e mostra os números na ordem inversa que foram digitados");
                Console.WriteLine("Digite o número desejado para prosseguir");
                Console.Write("\nDigite o código: ");
                codigo = int.Parse(Console.ReadLine());
                if (codigo == 0 || codigo == 1 || codigo == 2) { break; }
                else
                {
                    Console.Write("Digite um número para a posição {0} do vetor: ", i);
                    vetor[i] = int.Parse(Console.ReadLine());
                    numeros++;
                }
            }
            if (codigo == 1)
            {
                Console.Clear();
                
                Console.Write("\nNúmeros na ordem digitada: ");
                for (int i = 0; i < numeros; i++)
                {
                    Console.Write(vetor[i] + " ");
                }
            }
            
            if (codigo == 2)
            {
                Console.Clear();
                
                Console.Write("\nNúmeros na ordem inversa: ");
                for (int i = numeros - 1; i >= 0; i--)
                {
                    Console.Write(vetor[i] + " ");
                }
            }
            */

            /* Questao 15
            /*
            int[] vetor = new int[20], vetorInvert = new int[20];
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write("Informe o valor {0} do vetor: ");
                vetor[i] = int.Parse(Console.ReadLine());
                vetorInvert[19 - i] = vetor[i];
            }
            Console.Clear();
            
            Console.Write("\nConteúdo do vetor: ");
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write("{0} ", vetor[i]);
            }
            
            Console.Write("\nConteúdo do vetor em ordem invertida: ");
            for (int i = 0; i < vetorInvert.Length; i++)
            {
                Console.Write("{0} ", vetorInvert[i]);
            }
            Console.WriteLine("");
            */

            //* Questao 16

            //int[] x = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int[] y = new int[10] { 1, 6, 30, 4, 5, 60, 7, 9, 10, 11 };

            //int[] uniao = new int[20];
            //int[] diferenca = new int[20];
            //int[] intersecao = new int[10];

            //Console.WriteLine("UNIÃO");

            //x.CopyTo(uniao, 0);
            //int auxU = 10;

            //for (int i = 0; i < y.Length; i++)
            //{
            //    for (int j = 0; j < x.Length; j++)
            //    {
            //        if (y[i] == x[j])
            //        {
            //            break;
            //        }

            //        if (j == (x.Length - 1))
            //        {
            //            uniao[auxU] = y[i];
            //            auxU++;
            //        }
            //    }
            //}

            //for (int i = 0; i < auxU; i++)
            //{
            //    Console.WriteLine(uniao[i]);
            //}

            //Console.WriteLine("");

            //Console.WriteLine("DIFERENÇA");

            //int auxD = 0;

            //for (int i = 0; i < x.Length; i++)
            //{
            //    for (int j = 0; j < y.Length; j++)
            //    {
            //        if (x[i] == y[j])
            //        {
            //            break;
            //        }

            //        if (j == (y.Length - 1))
            //        {
            //            diferenca[auxD] = x[i];
            //            auxD++;
            //        }
            //    }
            //}

            //for (int i = 0; i < auxD; i++)
            //{
            //    Console.WriteLine(diferenca[i]);
            //}

            //Console.WriteLine("");

            //Console.WriteLine("INTERSEÇÃO");

            //int auxI = 0;

            //for (int i = 0; i < x.Length; i++)
            //{
            //    for (int j = 0; j < y.Length; j++)
            //    {
            //        if (x[i] == y[j])
            //        {
            //            intersecao[auxI] = x[i];
            //            auxI++;
            //            break;
            //        }
            //    }
            //}

            //for (int i = 0; i < auxI; i++)
            //{
            //    Console.WriteLine(intersecao[i]);
            //}
        }
    }
}