using System;

namespace whileLoopExitConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool closer = true;
            void choice() {
                Console.WriteLine("");
                Console.WriteLine("Skriv dit input");
                Console.WriteLine("hvis du skriver 1, starter en 'lommeregner'");
                Console.WriteLine("tryk 2 for skolelommeregneren");
            }
            void calc2()
            {
                int plus(int tal1, int tal2)
                {
                    return (tal1 +tal2);
                }
                int minus(int tal1, int tal2)
                {
                    return (tal1- tal2);
                }
                int Gange(int tal1, int tal2)
                {
                    return (tal1 * tal2);
                }
                int Dividere(int tal1, int tal2)
                {
                    return (tal1 /tal2);
                }

                Console.WriteLine("vil du plus eller minus?");
                Console.WriteLine("1 = plus");
                Console.WriteLine("2 = minus");
                Console.WriteLine("3 = gange");
                Console.WriteLine("4 = dividere");

                int listener = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("første tal");
                int tal1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("andet tal");
                int tal2 = Convert.ToInt32(Console.ReadLine());
                int result = 0 ;
                if (listener == 1)
                {
                   result = plus(tal1 , tal2);
                }
                else if (listener == 2)
                {
                    result = minus(tal1, tal2);
                }
                else if (listener == 3)
                {
                    result = Gange(tal1,tal2);
                }
                else if (listener == 4)
                {
                    result = Dividere(tal1,tal2);
                }
                else
                {
                    Console.WriteLine("Denne funtktion eksistere ikke");
                }
                Console.WriteLine("Dit resultat er " + result);
                
            }
            void calc()
            {
                bool calcOpen  = true;
                while (calcOpen)
                {
                    bool calcOpen1 = true;
                    Console.WriteLine("Skriv dit første tal");
                    string value1 = Console.ReadLine();
                    int tal1;
                    if (int.TryParse(value1, out tal1))
                    {
                        int value3 = Convert.ToInt32(value1);
                        tal1 = value3;
                    }
                    else
                    {
                        Console.WriteLine("Det er ikke kun et tal");
                        calcOpen1 = false;
                    }
                    while (calcOpen1)
                    {
                        Console.WriteLine("skriv dit andet tal");
                        string value2 = Console.ReadLine();
                        int tal2;
                        if (int.TryParse(value2, out tal2))
                        {
                            int value3 = Convert.ToInt32(value2);
                            tal2 = value3;


                            Console.WriteLine("hvad skal disse tal?" +
                                "ganges = '*' " +
                                "divideres = '/' " +
                                "Pluses = '+'" +
                                "minuses = '-'");
                            string reader = Console.ReadLine();
                            if (reader == "")
                            {
                                calcOpen = false;
                                calcOpen1 = false;
                            }
                            else if (reader == "+" | reader == "'+'")
                            {
                                tal1 = tal1 + tal2;
                                Console.WriteLine("Dit samlede tal er: " + tal1);
                            }
                            else if (reader == "/" | reader == "'/'")
                            {
                                tal1 = tal1 / tal2;
                                Console.WriteLine("Dit samlede tal er: " + tal1);
                            }
                            else if (reader == "-" | reader == "'-'")
                            {
                                tal1 = tal1 - tal2;
                                Console.WriteLine("Dit samlede tal er: " + tal1);
                            }
                            else if (reader == "*" | reader == "'*'")
                            {
                                tal1 = tal1 * tal2;
                                Console.WriteLine("Dit samlede tal er: " + tal1);
                            }
                            else
                            {
                                Console.WriteLine("Ønsker du at lukke?" +
                                    "y/n default = y");
                                string yn = Console.ReadLine();
                                if (yn == "y" | yn == "")
                                {
                                    calcOpen = false;
                                    calcOpen1 = false;
                                }
                            }
                            bool calcOpen2 = true;
                            while (calcOpen2)
                            {

                                Console.WriteLine("Ønsker du at fortætte med samme tal, lukke lommeregneren eller restarte lommeregneren?");
                                Console.WriteLine("restart");
                                Console.WriteLine("luk");
                                Console.WriteLine("fortsæt");
                                string reader1 = Console.ReadLine();
                                if (reader1 == "restart")
                                {
                                    calcOpen1 = false;
                                    calcOpen2 = false;
                                }
                                else if (reader1 == "luk")
                                {
                                    calcOpen = false;
                                    calcOpen1 = false;
                                    calcOpen2 = false;

                                }
                                else if (reader1 == "fortsæt")
                                {
                                    calcOpen2 = false;
                                }
                                else
                                {
                                    Console.WriteLine("Sorry wrong input");
                                }
                            }
                        }
                        else {
                            Console.WriteLine("Det er ikke kun et tal");
                        }

                    }
                }
            }
            while (closer)
            {
                choice();
                string reader = Console.ReadLine();
                if (reader == "exit")
                {
                    closer = false;
                }
                else if (reader == "")
                {
                    Console.WriteLine("Please tell me to exit");
                }
                else if (reader == "1")
                {
                    calc();
                }
                else if (reader == "2")
                {
                    calc2();
                }
                else
                {
                    Console.WriteLine("Denne funtkion eksistere ikke. prøv en anden");
                    Console.WriteLine("");
                }
            }
        }
    }
}
