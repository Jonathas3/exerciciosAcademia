namespace AnotacoesRicardo
{
    internal class Program
    {
        //static void Main(string[] args)
        //{
        //    int i;
        //    int[] b = new int[5];
        //    Console.WriteLine("------ - Leitura dos valores:--------");
        //    for (i = 0; i < 5; i++)
        //    {
        //        Console.WriteLine("Digite o valor" + i + ";");
        //        b[i] = int.Parse(Console.ReadLine());
        //    }



        //    for (i = 0; i < 5; i++)
        //    {
        //        Console.WriteLine("Valor indice" + i + "e igual a " + b[i]);
        //    }


        //static void Main(string[] args)
        //{
        //    double[] notas = new double[50];
        //    double media;
        //    int i;

        //    Console.WriteLine("------Leitura dos valores:------");
        //    for (i = 0; i < 50; i++)
        //    {
        //        Console.WriteLine("Digite a nota do aluno" + i + ":");
        //        notas[i] = double.Parse(Console.ReadLine());
        //    }

        //    media = 0;
        //    Console.WriteLine("------Calculo da media sendo feito:-------");
        //    for(i = 0; i < 50; i++)
        //    {
        //        media += notas[i];
        //    }
        //    media = media / 50;

        //    Console.WriteLine("-------Mostra a media:-------");
        //    Console.WriteLine("A media de notas e igual "+media);

        //}


        //static void Main(string[] args)
        //{
        //    int[] idade = new int[40];
        //    int i, conta = 0;
        //    Console.WriteLine("Informe as idades dos alunos da turma:");
        //    for (i = 0; i < 40; i++)
        //    {
        //        idade[i] = int.Parse(Console.ReadLine());
        //        if (idade[i] >= 18)
        //        {
        //            conta++;
        //        }
        //    }
        //    Console.WriteLine("Existem " + conta + "alunos com idade maior ou igual a 18 anos");
        //    for (i =; i < 40; i++)
        //    {
        //        Console.WriteLine("aluno " + i + " tem " + idade[i] + " anos");
        //    }
        //}

        //static void Main(string[] args)
        //{
        //    int[] vetor = new int[10];
        //    int i, maior, pos;
        //    //laco para leitura dos elementos
        //    for (i =0; i < 10; i++)
        //    {
        //        Console.WriteLine("Digite o valor do elemento " + i);
        //        vetor[i] = int.Parse(Console.ReadLine());
        //    }
        //    maior = vetor[0]; //defino que o primeiro elemento e o maior
        //    pos = 0;
        //    for (i = 0; i < 10; i++)
        //    {
        //        if (vetor[i] > maior)
        //        {
        //            maior = vetor[i];
        //            pos = i;

        //        }


        //    }

        //    Console.WriteLine("O maior elemento e: " + maior+" e esta na posicao "+pos);


        //}

        static void Main(string[] args)
        {
            int[] vetor = new int[10];
            int i, maior, pos;
            //laco para leitura dos elementos
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("digite o valor do elemento " + i);
                vetor[i] = int.Parse(Console.ReadLine());
            }
            maior = vetor[0]; //defino que o primeiro elemento e o maior
            pos = 0;
            for (i = 0; i < 10; i++)
            {
                if (vetor[i] > maior)
                {
                    maior = vetor[i];
                    pos = i;

                }


            }

            Console.WriteLine("o maior elemento e: " + maior + " e esta na posicao " + pos);

        }
    }
}