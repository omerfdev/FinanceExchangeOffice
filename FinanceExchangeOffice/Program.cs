﻿using System;

namespace FinanceExchangeOffice
{
    class Program
    {
        static void Main(string[] args)
        {
            Double US_Dollar = 7.97, Euro = 8.22, Pound = 11.02;
            Double Dollarlimit = 100000, Eurolimit = 100000, Poundlimit = 100000;
            double Sale = 0;
            char Mainpage = '0', Lowpage = '0', UpdateFinance = '0', Saletype = '0';
            OMERFDEV:
            Console.WriteLine("Finance Exchange Office"); 
            Console.WriteLine("-----------------------");
            Console.WriteLine("1-Show Unit Price List");
            Console.WriteLine("2-Update Unit Price List");
            Console.WriteLine("3-Sold Unit Money");
            Console.WriteLine("4-Show Unit Money Stock Level");
            Console.WriteLine("5-Show All Sold Information List");
            Console.WriteLine("6-Exit");
            Console.WriteLine("Select 1 2 3 4 5 6");
            Mainpage = Convert.ToChar(Console.ReadLine());
            if (Mainpage == '1');
            {
                Console.Clear();
                Console.WriteLine("Show Unit Price List");
                Console.WriteLine("--------------------");
                Console.WriteLine("US_Dollar:{0} Turkish Lira",US_Dollar);
                Console.WriteLine("Euro:{0} Turkish Lira",Euro);
                Console.WriteLine("Pound:{0} Turkish Lira",Pound);
                LOWPAGE:
                Console.WriteLine("1-Return Main Page");
                Console.WriteLine("2-Exit");
                Console.WriteLine("Select 1 or 2");
                Lowpage = Convert.ToChar(Console.ReadLine());
                if (Lowpage== '1')
                {
                    Console.Clear();
                    goto OMERFDEV;
                }
                else if(Lowpage== '2')
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Wrong Command.");
                    Console.WriteLine("Press Any Tutton To Quit....");
                    Console.ReadKey();
                }
            }
        }       

    }
}
