using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sa01.aplicaçao6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double aviao1;
            double aviao2;
            double aviao3;
            double aviao4;

            int quantAviao;

            double valorUnit;

            double subtotal1;
            double subtotal2;
            double subtotal3;
            double subtotal4;

            double totalGeral;

            Console.WriteLine("Qual o valor do avião1?");
            aviao1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Quantos aviões voce deseja?");
            quantAviao = int.Parse(Console.ReadLine());
            subtotal1 = aviao1 * quantAviao;


            Console.WriteLine("Qual o valor do avião2?");
            aviao2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Quantos aviões voce deseja?");
            quantAviao = int.Parse(Console.ReadLine());
            subtotal2 = aviao2 * quantAviao;

            Console.WriteLine("Qual o valor do avião3?");
            aviao3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Quantos aviões voce deseja?");
            quantAviao = int.Parse(Console.ReadLine());
            subtotal3 = aviao3 * quantAviao;

            Console.WriteLine("Qual o valor do avião4?");
            aviao4 = double.Parse(Console.ReadLine());
            Console.WriteLine("Quantos aviões voce deseja?");
            quantAviao = int.Parse(Console.ReadLine());
            subtotal4 = aviao4 * quantAviao;

            totalGeral = subtotal1 + subtotal2 + subtotal3 + subtotal4;
            Console.WriteLine($"o total é:R$ {totalGeral}");
            Console.ReadKey();





        }
    }
}
