namespace ExerciciosDicionary
{
    internal class Program
    {
        static void Main(string[] args)
        { //{
          //    IDictionary<int, string> disc1 = new Dictionary<int, string>();
          //    disc1.Add(1, "Maria");
          //    disc1.Add(1, "Paulo");
          //    disc1.Add(1, "Pedro");

            //}
            Dictionary<int, string> dic1 = new Dictionary<int, string>()
            {
                                {1, "Banana"},
                                {2, "Laranja"},
                                {3, "Manga"},
                                {4, "Abacate"},
                                {5, "Maca"}

            };

            //Console.WriteLine(dic1.ContainsKey(1)); // retorna true
            //Console.WriteLine(dic1.ContainsKey(6)); // retorna false

            //Console.WriteLine(dic1.ContainsValue("Manga"));

            //Console.ReadKey();
            //Console.ReadKey();
            foreach(KeyValuePair<int, string> item in dic1)
            {
                Console.WriteLine("Ite,: "+item.Key + " " + item.Value);
            }
            // keyValuePair<int, string> i = new keyValuePair<int, string>(1, "Morango");
            string fruta;
            dic1.Remove(3, out fruta);
            Console.WriteLine(fruta+ " Removida com sucesso!");
            Console.WriteLine("Atualizacao 2: ");
            foreach (KeyValuePair<int, string> item in dic1)
            {
                Console.WriteLine("Item: " + item.Key + " " + item.Value);
            }
            //Cosnole.WriteLine(dic1.ContainsKey(1));

            //Console.WriteLine(dic1.ContainsValue("Manga"));
        }
    }
}