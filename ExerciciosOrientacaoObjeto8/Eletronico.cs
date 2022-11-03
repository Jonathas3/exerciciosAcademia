using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosOrientacaoObjeto8
{
    abstract class Eletronico
    
    {
        //https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/keywords/get


        private int _volts;
        private int _potencia;
        private bool _ligado;
        //Public Eletronico()
        //{
        //}

        public bool Ligado
        {
            get => _ligado;
            set => _ligado = value;
        }
        public abstract void ligar();
        
        public void desligar()
        {
            _ligado = false;
            Console.WriteLine("Desligando o equipamento");

        }

        //public bool VerificaLigado()
        //{
        //    return ligado;  
        //}
        

        
    }
}
