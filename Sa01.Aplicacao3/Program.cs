using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sa01.Aplicacao3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declarar quantidade de assento
            int quan, assen, multiplicação;
            //entrada de dados
            quan = 2;
            assen = 17;
            //processamento de dados
            multiplicação = (quan * assen);
            //saida de dados
            Console.WriteLine(multiplicação);
            //parar a tela
            Console.ReadLine();
        }
    }
}
