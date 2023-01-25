using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Assignment15
{
    public class Program
    {
        static void Swap(ref int x, ref int y) //  ref - Pass the address of variable 
        {
                int temp;
                temp = x;
                x = y;
                y = temp;
        }

        static void Calculation(int x, int y,out int sum,out int sub, out int mul) // out - when we want to out or return multiple values from the method

        {
            sum = x + y;
            sub = x - y;
            mul = x - y;
        }




        static void Main(string[] args)
        {
            int x = 5;
            int y = 15;

            Swap(ref x, ref y);
            Console.WriteLine($"x = {x} y = {y} ");

            Calculation(x, y, out int sum, out int sub, out int mul);
            Console.WriteLine($" \n Sum = {sum} \n Sub = {sub} \n Mul = {mul}");

        }
    }
}
