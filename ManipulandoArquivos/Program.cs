namespace ManipulandoArquivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string frase;

            while (true)
            {
                Console.WriteLine("Digite uma frase qualquer ou sair: ");
                frase = Console.ReadLine();

                if (frase.ToUpper() == "SAIR")
                {
                    break;
                }
                //

            }
            
            
        }
    }
}