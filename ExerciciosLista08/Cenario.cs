using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLista08
{
    class Cenario
    {

        private string _descricao { get; set; }
        private DateTime _data { get; set; }
        private float _altura { get; set; }

        public Cenario(string descricao, DateTime data, float altura)
        {
            Descricao = descricao;
            Data = data;
            Altura = altura;
        }

        public string Descricao { get => _descricao; set => _descricao = value; }
        public DateTime Data { get => _data; set => _data = value; }
        public float Altura { get => _altura; set => _altura = value; }

        public static void DetalhesCenario(List<Cenario> c, int index)
        {
            Console.WriteLine("Descrição: {0}", c[index].Descricao);
            Console.WriteLine("Criado em: {0}", c[index].Data);
            Console.WriteLine("{0}m\n", c[index].Altura);
        }

        public static void TempoItem(List<Cenario> c, int index)
        {
            DateTime agora = DateTime.Now;
            TimeSpan dif = agora.Subtract(c[index].Data);

            int dias = (int)dif.TotalDays;
            int horas = (int)dif.TotalHours;
            int min = (int)dif.TotalMinutes;
            int seg = (int)dif.TotalSeconds;
            //int dias = (int)agora.Subtract(c[index].Data).TotalDays;
            //int horas = (int)agora.Subtract(c[index].Data).TotalHours;
            //int min = (int)agora.Subtract(c[index].Data).TotalMinutes;
            Console.Write("\nO cenário possui ");
            if (dias > 0)
            {
                if (dias == 1)
                {
                    Console.Write($"{dias} dia, ");
                }
                else if (dias > 1)
                {
                    Console.Write($"{dias} dias, ");
                }
            }
            if (horas > 0)
            {
                if (horas == 1)
                {
                    Console.Write($"{horas} hora, ");
                }
                else if (horas > 1)
                {
                    Console.Write($"{horas} horas, ");
                }
            }
            if (min > 0)
            {
                if (min == 1)
                {
                    Console.Write($"{min} minuto, ");
                }
                else if (min > 1)
                {
                    Console.Write($"{min} minutos, ");
                }
            }
            if (seg > 0)
            {
                if (seg == 1)
                {
                    Console.Write($"{seg} segundo ");
                }
                else if (seg > 1)
                {
                    Console.Write($"{seg} segundos ");
                }
            }
            Console.WriteLine("de criação.");
        }
    }
}
