namespace AcademiaExerciciosmatriz5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Questao 01
            //int[,] matriz = new int[5, 3];
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("Informe um valor para a coluna 0: ");
            //    matriz[i, 0] = int.Parse(Console.ReadLine());
            //}
            //for (int i = 0; i < 5; i++)
            //{
            //    matriz[i, 1] = matriz[i, 0] + 10;
            //    matriz[i, 2] = matriz[i, 0] * 2;
            //}
            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write("[" + i + "," + j + "] = " + matriz[i, j] + "  ");



            ////Questao02
            //int[,] matriz = new int[3, 3];
            //int somalinha0 = 0, somacoluna0 = 0;
            //int somalinha1 = 0, somacoluna1 = 0;
            //int somalinha2 = 0, somacoluna2 = 0;

            //for (int i = 0; i < 3; i++)

            //{

            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.WriteLine("informe um valor para a linha " + i + ",da coluna: " + j);
            //        matriz[i, j] = int.Parse(Console.ReadLine());

            //        if (i == 0)
            //        {
            //            somalinha0 = somalinha0 + matriz[i, j];
            //        }
            //        if (i == 1)
            //        {
            //            somalinha1 = somalinha1 + matriz[i, j];
            //        }
            //        if (i == 2)
            //        {
            //            somalinha2 = somalinha2 + matriz[i, j];
            //        }


            //        if (j == 0)
            //        {
            //            somacoluna0 = somacoluna0 + matriz[i, j];
            //        }
            //        if (j == 1)
            //        {
            //            somacoluna1 = somacoluna1 + matriz[i, j];
            //        }
            //        if (j == 2)
            //        {
            //            somacoluna2 = somacoluna2 + matriz[i, j];
            //        }
            //    }

            //}
            //Console.Clear();
            //for (int i = 0; i < 3; i++)

            //{

            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write(matriz[i, j] + " || ");
            //    }
            //    Console.WriteLine();

            //}
            //        Console.WriteLine("Soma das linhas:\n " + "Linha 0: " + somalinha0 + "  Linha 1  " + somalinha1 + "  Linha 2  " + somalinha2);
            //Console.WriteLine("Soma das colunas:\n " + "Coluna 0: " + somacoluna0 + "  Coluna 1: " + somacoluna1 + "  Coluna 2: " + somacoluna2);

            // Questao 03 
            /*
            int[,] matriz = new int[4, 4];
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write("Informe o valor [{0},{1}]: ", i, j);
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine();
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        Console.Write("[{0},{1}]: {2} ", i, j, matriz[i,j]);
                    }
                }                
            }
            */

            // Questao 04
            /*
            int[,] matriz = new int[5, 5];
            int pares = 0, impares = 0, positivos = 0, negativos = 0, zeros = 0;
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write("Informe o valor [{0},{1}]: ", i, j);
                    matriz[i, j] = int.Parse(Console.ReadLine());
                    if (matriz[i, j] % 2 == 0) { pares++; }
                    if (matriz[i, j] % 2 != 0) { impares++; }
                    if (matriz[i, j] >= 0) { positivos++; }
                    if (matriz[i, j] < 0) { negativos++; }
                }
            }
            Console.WriteLine("\nQuantidade de pares: " + pares);
            Console.WriteLine("Quantidade de ímpares: " + impares);
            Console.WriteLine("Quantidade de positivos: " + positivos);
            Console.WriteLine("Quantidade de negativos: " + negativos);
            */

            // Questao 05
            /*
            double[,] matrizA = new double[2, 3], matrizB = new double[2,3], matrizC = new double[2,3];
            for (int i = 0; i < matrizA.GetLength(0); i++)
            {
                for (int j = 0; j < matrizA.GetLength(1); j++)
                {
                    Console.Write("Informe o valor [{0},{1}] da Matriz A: ", i, j);
                    matrizA[i, j] = double.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine();
            for (int i = 0; i < matrizB.GetLength(0); i++)
            {
                for (int j = 0; j < matrizB.GetLength(1); j++)
                {
                    Console.Write("Informe o valor [{0},{1}] da Matriz B: ", i, j);
                    matrizB[i, j] = double.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < matrizA.GetLength(0); i++)
            {
                for (int j = 0; j < matrizA.GetLength(1); j++)
                {
                    matrizC[i, j] = matrizA[i, j] + matrizB[i, j];
                }
            }
            Console.WriteLine("Soma dos valores: ");
            for (int i = 0; i < matrizC.GetLength(0); i++)
            {
                for (int j = 0; j < matrizC.GetLength(1); j++)
                {
                    Console.Write(matrizC[i,j] + " ");
                }
            }
            */


            // Questao 06
            /*
            int[,] M = new int[4, 4];
            Random random = new Random();
            int maior=0;
            for (int i = 0; i < M.GetLength(0); i++)
            {
                for (int j = 0; j < M.GetLength(1); j++)
                {
                    M[i, j] = random.Next(0, 100);
                }
            }
            for (int i = 0; i < M.GetLength(0); i++)
            {
                for (int j = 0; j < M.GetLength(1); j++)
                {
                    if (M[i, j] > maior)
                    {
                        maior = M[i, j];
                    }
                    Console.WriteLine("[{0},{1}]: {2}",i, j, M[i,j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("O maior valor da matriz M é " + maior);
            */


            // Questao 07
            /*
            Random random = new Random();   //usando Random para não precisar digitar...
            int[,] matrizA = new int[2, 3], matrizB = new int[2, 3], matrizC = new int[2, 3];
                        
            for (int i = 0; i < matrizA.GetLength(0); i++)
            {
                for (int j = 0; j < matrizA.GetLength(1); j++)
                {
                    //Console.Write("Informe o valor [{0},{1}] da Matriz A: ", i, j);
                    //matrizA[i, j] = int.Parse(Console.ReadLine());
                    matrizA[i, j] = random.Next(0, 20);
                    Console.WriteLine("[{0},{1}]: {2}", i, j, matrizA[i, j]);
                }
                Console.WriteLine();
            }
            
            for (int i = 0; i < matrizB.GetLength(0); i++)
            {
                for (int j = 0; j < matrizB.GetLength(1); j++)
                {
                    //Console.Write("Informe o valor [{0},{1}] da Matriz B: ", i, j);
                    //matrizB[i, j] = int.Parse(Console.ReadLine());
                    matrizB[i, j] = random.Next(0, 20);
                    Console.WriteLine("[{0},{1}]: {2}", i, j, matrizB[i, j]);
                }
                Console.WriteLine();
            }
            for (int i = 0; i < matrizA.GetLength(0); i++)
            {
                for (int j = 0; j < matrizA.GetLength(1); j++)
                {
                    matrizC[i, j] = matrizA[i, j] - matrizB[i, j];                    
                }
            }
            Console.WriteLine("Subtração dos valores: ");
            for (int i = 0; i < matrizC.GetLength(0); i++)
            {
                for (int j = 0; j < matrizC.GetLength(1); j++)
                {
                    Console.Write(matrizC[i, j] + " ");
                }
            }
            */

            // Questao 09
            /*
            Random random = new Random();   //usando Random para não precisar digitar...
            int[,] matriz = new int[4, 4];
            Console.WriteLine("==== Lista na ordem digitada ====");
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    //Console.Write("Informe o valor [{0},{1}] da Matriz A: ", i, j);
                    //matrizA[i, j] = int.Parse(Console.ReadLine());
                    matriz[i, j] = random.Next(0, 20);
                    Console.WriteLine("[{0},{1}]: {2}", i+1, j+1, matriz[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("==== Lista na ordem invertida ====");
            
            for (int i = matriz.GetLength(0) - 1; i >= 0; i--)
            {
                for (int j = matriz.GetLength(1) - 1; j >= 0 ; j--)
                {                    
                    Console.WriteLine("[{0},{1}]: {2}", i+1, j+1, matriz[i, j]);
                }
                Console.WriteLine();
            }
            */

            // Questao 10
            /*
            Random random = new Random();   //usando Random para não precisar digitar...
            int[,] matriz = new int[3, 3];
            int numeroSelecionado = random.Next(0, 20);
            bool numeroExiste = false;
            Console.WriteLine("Número selecionado: {0}\n", numeroSelecionado);
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    //Console.Write("Informe o valor [{0},{1}] da Matriz A: ", i, j);
                    //matrizA[i, j] = int.Parse(Console.ReadLine());
                    matriz[i, j] = random.Next(0, 20);
                    Console.WriteLine("[{0},{1}]: {2}", i + 1, j + 1, matriz[i, j]);
                }
                Console.WriteLine();
            }
            
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (matriz[i, j] == numeroSelecionado) { 
                        numeroExiste = true;
                        break;
                    } else
                    {
                        numeroExiste = false;
                    }
                }
            }
            if (numeroExiste)
            {
                Console.WriteLine("O número existe no vetor");
            }
            else
            {
                Console.WriteLine("Número inexistente");
            }
            */

            // Questao 11:
            /*
            Random random = new Random();   //usando Random para não precisar digitar...
            int[,] matrizA = new int[4,4], matrizB = new int[4,4];
            int mediaA=0, mediaB=0, abaixoA=0, abaixoB=0, acimaA=0, acimaB=0, naMediaA=0, naMediaB=0;
            Console.WriteLine("Elementos da Matriz A:");
            for (int i = 0; i < matrizA.GetLength(0); i++)
            {
                for (int j = 0; j < matrizA.GetLength(1); j++)
                {
                    //Console.Write("Informe o valor [{0},{1}] da Matriz A: ", i, j);
                    //matrizA[i, j] = int.Parse(Console.ReadLine());
                    matrizA[i, j] = random.Next(0, 20);
                    Console.WriteLine("[{0},{1}]: {2}", i + 1, j + 1, matrizA[i, j]);
                    mediaA += matrizA[i, j];
                }
                Console.WriteLine();
            }
            Console.WriteLine("Elementos da Matriz B:");
            for (int i = 0; i < matrizB.GetLength(0); i++)
            {
                for (int j = 0; j < matrizB.GetLength(1); j++)
                {
                    //Console.Write("Informe o valor [{0},{1}] da Matriz A: ", i, j);
                    //matrizB[i, j] = int.Parse(Console.ReadLine());
                    matrizB[i, j] = random.Next(0, 20);
                    Console.WriteLine("[{0},{1}]: {2}", i + 1, j + 1, matrizB[i, j]);
                    mediaB += matrizB[i, j];
                }
                Console.WriteLine();
            }
            mediaA /= 16;
            mediaB /= 16;
            for (int i = 0; i < matrizA.GetLength(0); i++)
            {
                for (int j = 0; j < matrizA.GetLength(1); j++)
                {
                    //verifica os elementos da MatrizA
                    if (matrizA[i, j] == mediaA) 
                    {
                        naMediaA++;
                    }
                    else if (matrizA[i, j] > mediaA)
                    {
                        acimaA++;
                    }
                    else if (matrizA[i,j] < mediaA)
                    {
                        abaixoA++;
                    }
                    //verifica os elementos da MatrizB
                    if (matrizB[i, j] == mediaB)
                    {
                        naMediaB++;
                    }
                    else if (matrizB[i, j] > mediaB)
                    {
                        acimaB++;
                    }
                    else if (matrizB[i, j] < mediaB)
                    {
                        abaixoB++;
                    }
                }
            }
            Console.WriteLine("====================");
            Console.WriteLine("Média da Matriz A: " + mediaA);
            Console.WriteLine("Média da Matriz B: " + mediaB);
            Console.WriteLine("\nElementos na média na Matriz A: " + naMediaA);
            Console.WriteLine("Elementos na média na Matriz B: " + naMediaB);
            Console.WriteLine("\nElementos na acima da média na Matriz A: " + acimaA);
            Console.WriteLine("Elementos na acima da média na Matriz B: " + acimaB);
            Console.WriteLine("\nElementos na abaixo da média na Matriz A: " + acimaA);
            Console.WriteLine("Elementos na abaixo da média na Matriz B: " + acimaB);
            Console.WriteLine("====================");
            */

            // Questao 12
            /*
            Random random = new Random();   //usando Random para não precisar digitar...
            double[,] matrizA = new double[3, 3], matrizResult = new double[3, 3];
            string excesoes="";
            Console.WriteLine("Matriz A:\n");
            for (int i = 0; i < matrizA.GetLength(0); i++)
            {
                for (int j = 0; j < matrizA.GetLength(1); j++)
                {
                    //Console.Write("Informe o valor [{0},{1}] da Matriz A: ", i, j);
                    //matrizA[i, j] = double.Parse(Console.ReadLine());
                    matrizA[i, j] = random.Next(0, 20);
                    Console.Write("[{0},{1}]: {2} ", i + 1, j + 1, matrizA[i, j]);
                    
                    if (matrizA[i, j] == 0 || (i + j) == 0)
                    {
                        excesoes += "O elemento [" + i + "," + j + "] não pode ser dividido por ser zero\n";
                        matrizA[i, j] = 0;
                    }
                    else
                    {
                        matrizResult[i,j] = matrizA[i, j] / (i + j);
                    }
                    Console.WriteLine();
                }
            }
            Console.WriteLine("\nMatriz resultante:\n");
            for (int i = 0; i < matrizA.GetLength(0); i++)
            {
                for (int j = 0; j < matrizA.GetLength(1); j++)
                {
                    Console.Write("[{0},{1}] = {2:F} ", i, j, matrizResult[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n" + excesoes);
            */


        }
    }
}