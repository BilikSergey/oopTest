using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace oopTest
{
    class PeopleSay:People
    {
        public enum Types { Формаліст, Неформал, Реаліст }
        public void NameRandom()
        {
            
            Random rnd = new Random();
            string[] randoms = new string[5];
            randoms[0] = "Вася";
            randoms[1] = "Петя";
            randoms[2] = "Коля";
            randoms[3] = "Миколявач";
            randoms[4] = "Геодезiйко";

            string randsror = randoms[rnd.Next(0, randoms.Length)];
            name1 = randsror;
            string randsror2 = randoms[rnd.Next(0, randoms.Length)];
            name2 = randsror2;
            string randsror3 = randoms[rnd.Next(0, randoms.Length)];
            name3 = randsror3;
            string randsror4 = randoms[rnd.Next(0, randoms.Length)];
            name4 = randsror4;
            string randsror5 = randoms[rnd.Next(0, randoms.Length)];
            name5 = randsror5;  
        }
        public void AgeRandom()
        {
            Random rnd = new Random();
            int value1 = rnd.Next(20, 40);
            age1 = value1;
            int value2 = rnd.Next(20, 40);
            age2 = value2;
            int value3 = rnd.Next(20, 40);
            age3 = value3;
            int value4 = rnd.Next(20, 40);
            age4 = value4;
            int value5 = rnd.Next(20, 40);
            age5 = value5;

        }
        public void TypesRandom()
        {
            Types c = (Types) (new Random()).Next(0, 3);
            AgeRandom();
            NameRandom();
            Random rnd = new Random();
            string[] randoms = new string[3];
            randoms[0] = "Формаліст";
            randoms[1] = "Неформал";
            randoms[2] = "Реаліст";
            string randsror = randoms[rnd.Next(0, randoms.Length)];
            types1 = randsror;
            switch (c)
            {
                case Types.Неформал:
                    Console.WriteLine("Привіт, "+ age2);
                    break;                
            }
            if (types1 == "Формаліст")
            {
                Console.WriteLine("Добрий день, " + name2);
                Console.WriteLine("Добрий день, " + name3);
                Console.WriteLine("Добрий день, " + name4);
                Console.WriteLine("Добрий день, " + name5);
            }
            else if (types1 == "Неформал")
            {
                Console.WriteLine("Привіт, " + name2);
                Console.WriteLine("Привіт, " + name3);
                Console.WriteLine("Привіт, " + name4);
                Console.WriteLine("Привіт, " + name5);
            }
           else if (types1 == "Реаліст")
            {
                if (age1 + 5 > age2)
                    Console.WriteLine("Привіт, " + name2);
                else { Console.WriteLine("Добрий день, " + name2); }
            }
        }
    }
}
