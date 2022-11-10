using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class Pessoa
    {
        public string Nome { get; set; } // atributos
        public int Idade { get; set; }

        public void Apresentar() //metodo-ação
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos!");
        }
    }
}