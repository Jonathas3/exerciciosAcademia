using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosOrientacaoObjeto8
{
    class Celular : Eletronico
    {
        public override void ligar()
        {
            Console.WriteLine("Iniciando o Android");
            //_ligado = true;
            this.Ligado = true;
        }
    
    }
}
