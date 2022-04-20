using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basicoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            //instantiate
            Arithmetic arith = new Arithmetic();

            //declaration

            int sum = 0;
            
            sum = arith.Add(3, 4);
            Console.WriteLine("sum is: {0}", sum);

            int product = 0;
            product = arith.Mult(3, 4);
            Console.WriteLine("product is: {0}", product);

            float qoutient = 0.0f;
            qoutient = arith.Div(12, 3);
            Console.WriteLine("qoutient is: {0}", qoutient);

            Console.ReadLine();
        }
    }
}
