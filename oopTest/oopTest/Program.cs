using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace oopTest
{
    class Program
    {
        static void Main(string[] args)
        {
            PeopleSay peopleSay = new PeopleSay();
            peopleSay.TypesRandom();
            Console.ReadKey();
        }
    }
}
