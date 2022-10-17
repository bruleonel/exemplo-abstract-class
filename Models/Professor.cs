using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClasseAbstrata.Models
{
    public class Professor : Pessoa
    {
        public Professor(string nome) : base(nome)
        {

        }
        
        public double Salario { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos, sou professor e ganho  {Salario}");
        }
    }
}