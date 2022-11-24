using System;

namespace Hádání_čísel_s_volitelnou_obtížností
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vyberte si obtížnost\n1 - lehká\n2 - střední\n3 - těžká");
            int pokus = 1;
            int obtiznost = int.Parse(Console.ReadLine());
            Hádání(obtiznost);
            Random r = new Random();
            switch (obtiznost)
            {
                case 1:
                    {
                        Console.WriteLine("Zadejte číslo od 1 do 10");
                        int vstup = int.Parse(Console.ReadLine());
                        if (vstup < 1 || vstup > 10)
                        {
                            Console.WriteLine("Neplatný vstup");
                            Console.ReadLine();
                        }
                        else
                        {
                            int n;
                            n = r.Next(1, 10);
                            while (vstup != n)
                            {
                                pokus++;
                                if (vstup < n)
                                {
                                    Console.WriteLine("Zadejte větší číslo");
                                }
                                else if (vstup > n)
                                {
                                    Console.WriteLine("Zadejte menší číslo");
                                }
                                vstup = int.Parse(Console.ReadLine());
                            }
                            if (vstup == n)
                            {
                                Console.WriteLine("Uhodl(a) jste hádané číslo {0} po {1} pokusech", n, pokus);
                            }
                            Console.ReadLine();
                        }
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Zadejte číslo od 1 do 50");
                        int vstup = int.Parse(Console.ReadLine());
                        if (vstup < 1 || vstup > 50)
                        {
                            Console.WriteLine("Neplatný vstup");
                            Console.ReadLine();
                        }
                        else
                        {
                            int n;
                            n = r.Next(1, 50);
                            while (vstup != n)
                            {
                                pokus++;
                                if (vstup < n)
                                {
                                    Console.WriteLine("Zadejte větší číslo");
                                }
                                else if (vstup > n)
                                {
                                    Console.WriteLine("Zadejte menší číslo");
                                }
                                vstup = int.Parse(Console.ReadLine());
                            }
                            if (vstup == n)
                            {
                                Console.WriteLine("Uhodl(a) jste hádané číslo {0} po {1} pokusech", n, pokus);
                            }
                            Console.ReadLine();
                        }
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Zadejte číslo od 1 do 100");
                        int vstup = int.Parse(Console.ReadLine());
                        if (vstup < 1 || vstup > 100)
                        {
                            Console.WriteLine("Neplatný vstup");
                            Console.ReadLine();
                        }
                        else
                        {
                            int n;
                            n = r.Next(1, 100);
                            while (vstup != n)
                            {
                                pokus++;
                                if (vstup < n)
                                {
                                    Console.WriteLine("Zadejte větší číslo");
                                }
                                else if (vstup > n)
                                {
                                    Console.WriteLine("Zadejte menší číslo");
                                }
                                vstup = int.Parse(Console.ReadLine());
                            }
                            if (vstup == n)
                            {
                                Console.WriteLine("Uhodl(a) jste hádané číslo {0} po {1} pokusech", n, pokus);
                            }
                            Console.ReadLine();
                        }
                        break;
                    }
            }
        }

        static int Hádání(int obtiznost)
        {
            while (obtiznost < 1 || obtiznost > 3)
            {
                Console.WriteLine("Chyba zadání");
                obtiznost = int.Parse(Console.ReadLine());
            }
            return obtiznost;
        }
    }
}