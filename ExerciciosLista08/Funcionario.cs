using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLista08
{
    abstract class Funcionario
    {
        private string _nome { get; set; }
        private string _departamento { get; set; }
        private double _salario { get; set; }
        private string _dataEntrada { get; set; }
        private string _rg { get; set; }
        private bool _ativo { get; set; }
        public Funcionario() { }
        public Funcionario(string _nome, string _departamento, double _salario, string _dataEntrada, string _rg, bool _ativo)
        {
            Nome = _nome;
            Departamento = _departamento;
            Salario = _salario;
            DataEntrada = _dataEntrada;
            Rg = _rg;
            Ativo = _ativo;
        }

        public string Nome { get => _nome; set => _nome = value; }
        public string Departamento { get => _departamento; set => _departamento = value; }
        public double Salario { get => _salario; set => _salario = value; }
        public string DataEntrada { get => _dataEntrada; set => _dataEntrada = value; }
        public string Rg { get => _rg; set => _rg = value; }
        public bool Ativo { get => _ativo; set => _ativo = value; }

        public abstract void ExecutaTrabalho();
        public void Bonifica(double valor)
        {
            Salario += valor;
        }
        public void Demite()
        {
            this._ativo = false;
            Console.Clear();
            Console.WriteLine($"Funcionário '{Nome}' demitido...\n");
        }

        public void MostrarDados()
        {
            Console.WriteLine($"Funcionário: {_nome}  |  Departamento: {Departamento}  |  Salário: {Salario:C}");
            Console.Write($"Contratado em: {DataEntrada}  |  RG: {Rg}  |  ");
            if (Ativo)
            {
                Console.WriteLine($"Situação atual: 'Admitido'");
            }
            else
            {
                Console.WriteLine($"Situação atual: 'Demitido'");
            }
        }

    }
}