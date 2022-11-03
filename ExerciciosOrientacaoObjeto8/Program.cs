namespace ExerciciosOrientacaoObjeto8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int op;
            Televisao t = new Televisao();
            while (true)
            {
                Console.WriteLine("Ola, Boa tarde\nDeseja ligar o equipamento?");
                Console.WriteLine("Digite 1 para ligar\nDigote 2 para desligar\nDigite 3 para verificar se esta ligado\nDigite 4 para sair");
                op = int.Parse(Console.ReadLine());
                //Eletronico e = new Eletronico();
                
                if (op == 1)
                {
                    //if (t.VerificaLigado())
                    if(t.Ligado)
                    {
                        Console.WriteLine("Ja esta ligado!");

                    }
                    else
                    {
                        t.ligar();
                    }

                }
                else if (op == 2)
                {
                    //if (!t.VerificaLigado())
                    if (t.Ligado)
                    {
                        Console.WriteLine("Ja esta desligado!");
                    }
                    else
                    {
                        t.desligar();
                    }
                }
                else if (op == 3)
                {
                    //if(t.VerificaLigado())
                    if (!t.Ligado)
                    {
                        Console.WriteLine("Esta ligado!");
                    }
                    else
                    {
                        Console.WriteLine("Esta Desligado");
                    }
                }
                else if (op == 4)
                {
                    break;
                }
                
                
            }
        }
    }
}