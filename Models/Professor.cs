using System.Data.SqlTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public sealed class Professor : Pessoa // classe selada, não permite ninguem herdar dela
    {
        public Professor()
        {
            
        }
        public Professor(string nome) : base(nome) //construtor
        {

        }
        public decimal Salario { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos, sou um professor e ganho {Salario}");
        }
    }
}