using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexatorHW
{
    class Program
    {
        static void Main(string[] args)
        {
            Array array = new Array(3);
            array[0] = 1;
            array[1] = 2;
            array[2] = 3;
            for (int i = 0; i < array.Size; i++)
            {
                Console.WriteLine(array[i]+" ");
            }
            Console.ReadLine();
        }
    }
}
