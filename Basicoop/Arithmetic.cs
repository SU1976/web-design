using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basicoop
{
   public  class Arithmetic:Multiply, IDivision
    {
        //member variables
        int x = 0;
        int y = 0;

        //Methods
        public int Add(int a, int b)
        {
            x = a;
            y = b;
            int sum = x+y;
            return sum;
        }

        public float Div(int a, int b)
        {
            return a / b;
        }

        public  int Subtract(int a, int b)
        {
            return a - b;
        }
    }
}
