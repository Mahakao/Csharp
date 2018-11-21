using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CZYTAJCIE KOMENTARZE ;)"); 
            //komentarz


            /*
             * 
             * Komentarz
             * 
             */

            //inicjalizacja zmiennych i przypisanie wartosci
            byte nr = 255;
            int liczba = 5;
            float zmienna = 2.00f; 
            float z2=3.00f;
            char c = '/';
            string tekst = "ala ma kota";

            //wyswietlenie zmiennych w konsoli
            Console.WriteLine("byte: " + nr);
            Console.WriteLine("int: " + liczba);
            Console.WriteLine("char: " + c);
            Console.WriteLine("string: " + tekst);

            //zmniejszenie zmiennej nr o 5
            //nr=nr-5
            nr -= 5;
            Console.WriteLine("zmniejszone nr: "+nr);
            //wyswietlenie wyniku dzielenia z ograniczeniem do trzech miejsc po przecinku 
            Console.WriteLine(Math.Round(zmienna/z2,3));
            //wyswietlenie komunikatu, pobranie wartosci od użytkownika oraz wypisanie tekstu
            Console.WriteLine("wprowadz tekst: ");
            tekst = Console.ReadLine();
            Console.WriteLine(tekst);


            //operatory relacyjne
            Console.WriteLine(5 > 3);
            Console.WriteLine(5 < 3);
            Console.WriteLine(5 >= 3);
            Console.WriteLine(5 != 3);
            Console.WriteLine(5 == 3);

            /*operatory logiczne
            koninkcja
            (true)&&(true)=(true)
            (true)&&(false)=(false)
            (false)&&(false)=(false)

            alternatywa
            (true)&&(true)=(true)
            (true)&&(false)=(true)
            (false)&&(false)=(false)

            negacja
            !(false)&&(true)=(true)
            !(false)||(false)=(true)
            */
            Console.WriteLine((5==5)&&(5>10));
            Console.WriteLine((5 == 5) || (5 > 10));
            Console.WriteLine((5 == 5) && !(5 > 10));

            /*operatory bitowe
             * 
             * 
             * 
             * zamiana z 10-tnego na 2-jkowy
               
              10 | 0
               5 | 1
               2 | 0
               1 | 1
               1 |
                 |
            10-sietny     2-kowy
            10       =     1010
             0-false
             1-true
             koninkcja &
             1 0 1 0     10
             0 0 1 0     2
             ----------
             0 0 1 0     2

            alternatywa |
            1 0 1 0
            0 0 1 0
            ---------
            1 0 1 0

            alternatywa wykluczająca ^
            1 0 1 0
            0 0 1 0
            ----------
            1 0 0 0
            */

            Console.WriteLine( 10&2);
            Console.WriteLine(10 | 2);
            Console.WriteLine(10 ^ 2);
            //pobranie znaku od użytkownika
            Console.WriteLine("wybierz dzialanie: ");
             c = Convert.ToChar(Console.ReadLine());

            //kalkulator w switch  oraz if 
            switch (c)
            {
                case '+':
                    Console.WriteLine(zmienna+z2);
                    break;
                case '-':
                    Console.WriteLine(zmienna-z2);
                    break;
                case '/':
                    Console.WriteLine(zmienna/z2);
                    break;
                case '*':
                    Console.WriteLine(zmienna*z2);
                    break;
            }

            if(c=='+')
                Console.WriteLine(zmienna+z2);
            if (c == '-')
                Console.WriteLine(zmienna - z2);
            if (c == '/')
                Console.WriteLine(zmienna / z2);
            if (c == '*')
                Console.WriteLine(zmienna * z2);
                

            //operator warunkowy
            Console.WriteLine((zmienna>z2)?zmienna:z2);

            Console.ReadLine();
        }
    }
}
