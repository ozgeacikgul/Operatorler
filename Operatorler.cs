﻿using System;

namespace Operatorler_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Atama ve islemli atama
            int x = 3;
            int y = 3;
            y = y + 2;

            Console.WriteLine(y);
            y += 2;
            Console.WriteLine(y);
            y /= 1;
            Console.WriteLine(x);
            x *= 2;

            //Mantıksal Operatorler
            // ||,&&,!
            bool isSuccess = true;
            bool isCompleted = false;

            if (isSuccess && isCompleted)
                Console.WriteLine("Perfect!");

            if (isSuccess || isCompleted)
                Console.WriteLine("Great!");

            if (isSuccess && ! isCompleted)
                Console.WriteLine("Fine!");

            //Iliskisel operatorler
            //>,<,>=,<=, ==, !=

            int a = 3;
            int b = 4;
            bool sonuc = a < b;
            Console.WriteLine(sonuc);
            sonuc = a > b;
            Console.WriteLine(sonuc);
            sonuc = a >= b;
            Console.WriteLine(sonuc);
            sonuc = a == b;
            Console.WriteLine(sonuc);
            sonuc = a != b;
            Console.WriteLine(sonuc);

            //Aritmatik Operatorler
            // /,*,+,-

            int sayi1 = 10;
            int sayi2 = 5;
            int sonuc1 = sayi1 / sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1 * sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1 + sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 =sayi1++;
            Console.WriteLine(sayi1);

            //% mod alır

            int sonuc2 = 20 % 3;
            Console.WriteLine(sonuc2);












        }
    }
}
