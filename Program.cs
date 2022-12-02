using System.Security.Cryptography;

namespace program2_zgadywanie_liczb_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Grasz w odgadywanie liczby?");
            string i;
            do
            {

                    Console.WriteLine("t/n");
                    i = Console.ReadLine();
                    string t;

                    Random r = new Random();
                    int a = r.Next(1, 11);

                    int x;
                    Console.WriteLine("Podaj liczbę z zakresu 1-10");
                    do
                    {
                        string xs = Console.ReadLine();
                        x = int.Parse(xs);
                        if (x < 11 || x < 1)
                        {
                            if (x < a)
                            {
                                Console.WriteLine("Za mała Liczba");
                            }
                            else if (x > a)
                            {
                                Console.WriteLine("Za duża liczba");
                            }
                            else
                            {
                                Console.WriteLine("Gratulacje!!");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Podałeś liczbę z poza zakresu");
                            Console.WriteLine("Podaj liczbę z zakresu 1-10");
                        }
                    }
                    while (a != x);
          
            }
            while(i != "t");

            Console.WriteLine("Do zobaczenia");

        Console.ReadKey();

        }
    }
}