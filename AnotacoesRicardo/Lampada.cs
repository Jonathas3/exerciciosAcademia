using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnotacoesRicardo
{
    internal class Lampada
    {
        private bool ligada;
        private double potencia;
        //public int teste;
        public void ligar()
        {
            ligada = true;
            Console.WriteLine("Ligando Lampada!");
        }
        public void desligar() 
        { 
            ligada = false;
            Console.WriteLine("Desligando Lampada!");
        }
        public bool estaLigada()
        {
            return ligada;
        }
    
    }
}
