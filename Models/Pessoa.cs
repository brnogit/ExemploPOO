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
        public string Email { get; set; }

        public virtual void Apresentar() //metodo-ação //virtual significa que o metodo pode ser sobrescrito se a classe filha desejar
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos! E meu email é {Email}");
        }
    }
}