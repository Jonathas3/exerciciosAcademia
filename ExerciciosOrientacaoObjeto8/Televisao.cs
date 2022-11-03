using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosOrientacaoObjeto8
{
    class Televisao : Eletronico
    {
        public override void ligar()
        {
            Console.WriteLine("WebOS iniciando");
            //_ligado = true;
            this.Ligado = true;
        }
    }
}
