using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1_operadores
{
    class Program
    {
        static void Main(string[] args)
        {
            double num, pot, res;
            Console.WriteLine("Dame un número "); //sop
            num = Convert.ToDouble(Console.ReadLine()); //Cast porque lo que leo es un string //num = Console.ReadLine(); //scanf
            Console.WriteLine("Dame la potencia ");
            pot = Convert.ToDouble(Console.ReadLine());
            res = Math.Pow(num, pot);
            Console.WriteLine("El resultado es " + res);
            Console.ReadKey();//Es para que se cierre el programa hasta dar un teclazo, asi se evita que no vea el resultado
        }
    }
}
