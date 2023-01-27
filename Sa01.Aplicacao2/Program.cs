using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sa01.Aplicacao2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declarar subitração da idade
            int atual, lança, subitração;
            //entrada de dados
            atual = 2023;
            lança = 1968;
            //processamento de dados
            subitração = (atual - lança);
            //saida de dados
            Console.WriteLine(subitração);
            //parar a tela
            Console.ReadLine();

        }
    }
}
