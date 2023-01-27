using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sa01.aplicaçao7
{
    internal class Program
    {
        static void Main(string[] args)
        {
                    
            decimal subtotal1;
            decimal subtotal2;
            decimal subtotal3;
            decimal subtotal4;
            decimal subtotal5;

            decimal totalGeral;

            Console.WriteLine("VoeAirlaines!");
            Console.WriteLine("Qual e o valor da peça1?");
            decimal valor1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine($"o valor digitado foi:{valor1}");
            
            Console.WriteLine("VoeAirlaines!");
            Console.WriteLine("Qual e o valor da peça2?");
            decimal valor2 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine($"o valor digitado foi:{valor2}");

            Console.WriteLine("VoeAirlaines!");
            Console.WriteLine("Qual e o valor da peça3?");
            decimal valor3 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine($"o valor digitado foi:{valor3}");

            Console.WriteLine("VoeAirlaines!");
            Console.WriteLine("Qual e o valor da peça4?");
            decimal valor4 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine($"o valor digitado foi:{valor4}");

            Console.WriteLine("VoeAirlaines!");
            Console.WriteLine("Qual e o valor da peça5?");
            decimal valor5 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine($"o valor digitado foi:{valor5}");

            Console.WriteLine("Qual e o valor das peça1 + peça2 + peça3 + peça4 + peça5?");
            totalGeral = (valor1 + valor2 + valor3 + valor4 + valor5);
            Console.WriteLine($"o total é:R$ {totalGeral}");
            Console.ReadKey();
        }
    }
}
