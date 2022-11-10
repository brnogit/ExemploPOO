using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Interfaces
{
    public interface ICalculadora
    {
        int Somar(int num1, int num2); // metodos que não tem corpo são obrigatorios para implementação
        int Subtrair(int num1, int num2);
        int Multiplicar(int num1, int num2);
        int Dividir(int num1, int num2) //metodos que tem corpo são opcionais para implementação
        {
            return num1 / num2;
        }
    }
}