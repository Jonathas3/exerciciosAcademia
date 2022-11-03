using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosOrientacaoObjeto8
{
    class PlaySatation : Eletronico
    {
        public override void ligar()
        {
            Console.WriteLine("Ligando o PlayStation");
            //_ligado = true;
            this.Ligado = true;
        }
    
    }
}
