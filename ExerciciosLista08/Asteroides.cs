using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLista08
{
    public class Asteroides
    {
      
        private float _posX { get; set; }
        private float _posY { get; set; }
        private int _tamanho { get; set; }
        private int _velocidade { get; set; }
        private int _energia { get; set; }

        public Asteroides() { }

        public Asteroides(float posX, float posY, int tamanho, int velocidade, int energia)
        {
            _posX = posX;
            _posY = posY;
            _tamanho = tamanho;
            _velocidade = velocidade;
            _energia = energia;

            Console.WriteLine("Asteroide cadastrado!");
        }

        public Asteroides(float posX, float posY)
        {
            _posX = posX;
            _posY = posY;
        }

        public static void getAsteroides(List<Asteroides> a)
        {
            Console.WriteLine("Asteróides:");
            foreach (Asteroides ast in a)
            {
                Console.WriteLine("X: {0}   Y: {1}   Tamanho: {2}   Velocidade: {3} Mph   Energia: {4}", ast._posX, ast._posY, ast._tamanho, ast._velocidade, ast._energia);
            }
        }

    }
}
