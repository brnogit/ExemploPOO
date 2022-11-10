using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class Aluno : Pessoa // aluno herda de pessoa
    {
        public double Nota { get; set; }

        public override void Apresentar() //override é sobrescrever
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos, e sou um aluno nota {Nota}. E-mail{Email}");
        }
    }
}