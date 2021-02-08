using System;

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
            if (Mainpage=='1')
            {
                Console.Clear();
                Console.WriteLine("Show Unit Price List");
                Console.WriteLine("--------------------");
                Console.WriteLine("US_Dollar:{0} Turkish Lira", US_Dollar);
                Console.WriteLine("Euro:{0} Turkish Lira", Euro);
                Console.WriteLine("Pound:{0} Turkish Lira", Pound);
                Console.WriteLine("1-Return Main Page");
                Console.WriteLine("2-Exit");
                Console.WriteLine("Select 1 or 2");
                Lowpage = Convert.ToChar(Console.ReadLine());
                if (Lowpage == '1')
                {
                    Console.Clear();
                    goto OMERFDEV;
                }
                else if (Lowpage == '2')
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Wrong Command.");
                    goto OMERFDEV;
                    
                }
            }
            else if (Mainpage=='2')
            {
                Console.Clear();
                UPDATEMONEY:
                Console.WriteLine("Update Unit Price List");
                Console.WriteLine("Choose Money Type US Dollar:D Euro:E Pound:P");
                Console.WriteLine("Please Enter D , E  ,P ");
                UpdateFinance = Convert.ToChar(Console.ReadLine());
                if (UpdateFinance == 'D' || UpdateFinance == 'd') 
                {
                    Console.Clear();
                    Console.WriteLine("US Dollar :{0} Turkish Lira", US_Dollar);
                    Console.WriteLine("Please Enter New US Dollar Value");
                    US_Dollar = Convert.ToDouble(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("Update Completed.");
                    Console.WriteLine("US Dollar : {0} Turkish lira", US_Dollar);
                    Console.WriteLine("1-Another Update Unit List");
                    Console.WriteLine("2-Return Main Page");
                    Console.WriteLine("3-Exit");
                    Console.WriteLine("Select 1 , 2 , 3");
                    Lowpage = Convert.ToChar(Console.ReadLine());
                    if (Lowpage == '1')
                    {
                        Console.Clear();
                        goto UPDATEMONEY;
                    }
                    else if (Lowpage == '2')
                    {
                        Console.Clear();
                        goto OMERFDEV;

                    }
                    else if(Lowpage =='3')
                    {
                        Console.Clear();
                        Environment.Exit(0);

                    }
                    Console.ReadKey();

                }

                else if (UpdateFinance == 'E' || UpdateFinance == 'e') 
                {
                    Console.Clear();
                    Console.WriteLine("Euro :{0} Turkish Lira", Euro);
                    Console.WriteLine("Please Enter New Euro Value");
                    Euro = Convert.ToDouble(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("Update Completed.");
                    Console.WriteLine("Euro : {0} Turkish lira", Euro);
                    Console.WriteLine("1-Another Update Unit List");
                    Console.WriteLine("2-Return Main Page");
                    Console.WriteLine("3-Exit");
                    Console.WriteLine("Select 1 , 2 , 3");
                    Lowpage = Convert.ToChar(Console.ReadLine());
                    if (Lowpage == '1')
                    {
                        Console.Clear();
                        goto UPDATEMONEY;
                    }
                    else if (Lowpage == '2')
                    {
                        Console.Clear();
                        goto OMERFDEV;

                    }
                    else if (Lowpage == '3')
                    {
                        Console.Clear();
                        Environment.Exit(0);

                    }


                }
                else if (UpdateFinance == 'P' || UpdateFinance == 'p')
                {
                    Console.Clear();
                    Console.WriteLine("Pound :{0} Turkish Lira", Pound);
                    Console.WriteLine("Please Enter New Pound Value");
                    US_Dollar = Convert.ToDouble(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("Update Completed.");
                    Console.WriteLine("Pound : {0} Turkish lira", Pound);
                    Console.WriteLine("1-Another Update Unit List");
                    Console.WriteLine("2-Return Main Page");
                    Console.WriteLine("3-Exit");
                    Console.WriteLine("Select 1 , 2 , 3");
                    Lowpage = Convert.ToChar(Console.ReadLine());
                    if (Lowpage == '1')
                    {
                        Console.Clear();
                        goto UPDATEMONEY;
                    }
                    else if (Lowpage == '2')
                    {
                        Console.Clear();
                        goto OMERFDEV;

                    }
                    else if (Lowpage == '3')
                    {
                        Console.Clear();
                        Environment.Exit(0);

                    }

                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Wrong Command.");
                    goto OMERFDEV;
                }

            }
            else if (Mainpage=='3')
            {
                SELL:
                Console.Clear();
                Console.WriteLine("Sold Unit Money");
                Console.WriteLine("Choose To  Be Sold Money Type");
                Console.WriteLine("1-US Dollar");
                Console.WriteLine("2-Euro");
                Console.WriteLine("3-Pound");
                Saletype = Convert.ToChar(Console.ReadLine());
                if (Saletype=='1')
                {
                    if (Dollarlimit==0)
                    {
                        Console.WriteLine("No US Dollar To Sell");
                        goto OMERFDEV;
                    }
                    else
                    {
                        Console.WriteLine("How Much US Dollar Will You Sell");
                        Sale = Convert.ToDouble(Console.ReadLine());
                        if (Dollarlimit<Sale)
                        {
                            Console.WriteLine("There Are {0} US Dollar.",Dollarlimit);
                            goto SELL;
                        }
                        else if (Dollarlimit>=Sale)
                        {
                            Dollarlimit = Dollarlimit - Sale;
                            Console.WriteLine("Trade Succesfull.");
                            Console.WriteLine("There Are {0} US Dollar.",Dollarlimit);
                            Console.WriteLine("1-Another Sell US Dollar");
                            Console.WriteLine("2-Return Main Page");
                            Console.WriteLine("3-Exit");
                            Console.WriteLine("Select 1 , 2 , 3");
                            Lowpage = Convert.ToChar(Console.ReadLine());
                            if (Lowpage == '1')
                            {
                                Console.Clear();
                                goto SELL;
                            }
                            else if (Lowpage == '2')
                            {
                                Console.Clear();
                                goto OMERFDEV;

                            }
                            else if (Lowpage == '3')
                            {
                                Console.Clear();
                                Environment.Exit(0);

                            }

                        }
                    }
                }
                else if (Saletype=='2')
                {
                    if (Eurolimit==0)
                    {
                        Console.WriteLine("No Euro To Sell");
                        goto OMERFDEV;
                    }

                    else
                    {
                        Console.WriteLine("How Much US Euro Will You Sell");
                        Sale = Convert.ToDouble(Console.ReadLine());
                        if (Eurolimit<Sale)
                        {
                            Console.WriteLine("There Are {0} Euro.", Eurolimit);
                            goto SELL;
                        }
                        else if (Eurolimit>=Sale)
                        {
                            Eurolimit = Eurolimit - Sale;
                            Console.WriteLine("Trade Succesfull.");
                            Console.WriteLine("There Are {0} Euro.", Eurolimit);
                            Console.WriteLine("1-Another Sell Euro");
                            Console.WriteLine("2-Return Main Page");
                            Console.WriteLine("3-Exit");
                            Console.WriteLine("Select 1 , 2 , 3");
                            Lowpage = Convert.ToChar(Console.ReadLine());
                            if (Lowpage == '1')
                            {
                                Console.Clear();
                                goto SELL;
                            }
                            else if (Lowpage == '2')
                            {
                                Console.Clear();
                                goto OMERFDEV;

                            }
                            else if (Lowpage == '3')
                            {
                                Console.Clear();
                                Environment.Exit(0);

                            }
                        }
                    }

                }
                else if (Saletype=='3')
                {
                    if (Poundlimit==0)
                    {
                        Console.WriteLine("No Pound To Sell");
                        goto OMERFDEV;
                    }
                    else
                    {
                        Console.WriteLine("How Much Pound Will You Sell");
                        Sale = Convert.ToDouble(Console.ReadLine());
                    }
                    if (Poundlimit<Sale)
                    {
                        Console.WriteLine("There Are {0} Pound.", Poundlimit);
                        goto SELL;
                    }
                    else if (Poundlimit>=Sale)
                    {
                        Poundlimit = Poundlimit - Sale;
                        Console.WriteLine("Trade Succesfull.");
                        Console.WriteLine("There Are {0} Pound.", Poundlimit);
                        Console.WriteLine("1-Another Sell Pound");
                        Console.WriteLine("2-Return Main Page");
                        Console.WriteLine("3-Exit");
                        Console.WriteLine("Select 1 , 2 , 3");
                        Lowpage = Convert.ToChar(Console.ReadLine());
                        if (Lowpage == '1')
                        {
                            Console.Clear();
                            goto SELL;
                        }
                        else if (Lowpage == '2')
                        {
                            Console.Clear();
                            goto OMERFDEV;

                        }
                        else if (Lowpage == '3')
                        {
                            Console.Clear();
                            Environment.Exit(0);

                        }

                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Wrong Command.");
                    goto OMERFDEV;

                }

            }
            else if (Mainpage=='4')
            {
                Console.WriteLine("There Are {0} US Dollar.", Dollarlimit);
                Console.WriteLine("There Are {0} Euro.", Eurolimit);
                Console.WriteLine("There Are {0} Pound.", Poundlimit);
                Console.WriteLine("1-Return Main Page");
                Console.WriteLine("2-Exit");
                Console.WriteLine("Select 1 , 2 ");
                Lowpage = Convert.ToChar(Console.ReadLine());
                if (Lowpage == '1')
                {
                    Console.Clear();
                    goto OMERFDEV;
                }
                else if (Lowpage == '2')
                {
                    Console.Clear();
                    Environment.Exit(0);

                }
                else  
                {
                    Console.Clear();
                    Console.WriteLine("Wrong Command.");
                    goto OMERFDEV;

                }
            }
            else if (Mainpage=='5')
            {
                Console.WriteLine("US Dollar Sold Price {0} Turkish Lira. ", (100000 - Dollarlimit) * US_Dollar);
                Console.WriteLine("US Dollar Sold List {0}", 100000 - Dollarlimit);
                Console.WriteLine("Euro Sold Price {0} Turkish Lira. ", (100000 - Eurolimit) * Euro);
                Console.WriteLine("Euro Sold List {0}", 100000 - Eurolimit);
                Console.WriteLine("Pound Sold Price {0} Turkish Lira. ", (100000 - Poundlimit) * Pound);
                Console.WriteLine("Pound Sold List {0}", 100000 - Poundlimit);
                Console.WriteLine("1-Return Main Page");
                Console.WriteLine("2-Exit");
                Console.WriteLine("Select 1 , 2 ");
                Lowpage = Convert.ToChar(Console.ReadLine());
                if (Lowpage == '1')
                {
                    Console.Clear();
                    goto OMERFDEV;
                }
                else if (Lowpage == '2')
                {
                    Console.Clear();
                    Environment.Exit(0);

                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Wrong Command.");
                    goto OMERFDEV;

                }

            }
            else if (Mainpage=='6')
            {
                Console.Clear();
                Environment.Exit(0);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Wrong Command.");
                goto OMERFDEV;
            }
        }   
       }
}
