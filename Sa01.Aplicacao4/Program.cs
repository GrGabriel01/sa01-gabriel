using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sa01.Aplicacao4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declarar divisão de valores
            decimal valor, cli, dividir;
            //entrada de dados
            valor = 5000;
            cli = 10;
            //processamento de dados
            dividir = (valor / cli);
            //saida de dados
            Console.WriteLine(dividir);
            //parar a tela
            Console.ReadLine();
        }
    }
}
