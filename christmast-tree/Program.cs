using System;

namespace Weihnachtsbaum
{
    internal class Program
    {
        public static void Main()
        {
            int iAnzahl;

            Console.Write("Christmas tree height: ");
            string input;
            input = Console.ReadLine();
            if (input == null)
                return;
            iAnzahl = int.Parse(input);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("");

            for(int i = 1; i <= iAnzahl; i++)
            {
                for(int e = 1; e <= (iAnzahl - i); e++)
                {
                    Console.Write(" ");
                }
                for(int h = 1; h <= (i * 2 - 1); h++)
                {
                    Console.Write("#");
                }
                Console.WriteLine("");
            }

            Console.ForegroundColor = ConsoleColor.DarkRed;
            for(int i = 1; i <= iAnzahl / 3; i++)
            {
                for(int e = 1; e <= (iAnzahl - (iAnzahl / 3)); e++)
                {
                    Console.Write(" ");
                }
                for(int h = 1; h <= (iAnzahl / 3 * 2 - 1); h++)
                {
                    Console.Write("#");
                }
                Console.WriteLine("");
            }
            
            Console.WriteLine("");
            Console.WriteLine("");
            
            string sentence = "Happy Christmas!";
            char[] charArr = sentence.ToCharArray();
            
            for(int e = 1; e <= (iAnzahl - ((charArr.Length + 1) / 2)); e++)
            {
                Console.Write(" ");
            }
            for (int s = 0; s < charArr.Length; s++) {
                if (s % 2 == 0)
                    Console.ForegroundColor = ConsoleColor.Red;
                if ((s + 1) % 2 == 0)
                    Console.ResetColor();
                Console.Write(charArr[s]);
            }
            
            Console.WriteLine("");
            Console.WriteLine("");
            
            for(int e = 1; e <= (iAnzahl - ((charArr.Length + 1) / 2)); e++)
            {
                Console.Write(" ");
            }
            for (int s = 0; s < charArr.Length; s++) {
                if ((s + 1) % 2 == 0)
                    Console.ForegroundColor = ConsoleColor.Red;
                if (s % 2 == 0)
                    Console.ResetColor();
                Console.Write(charArr[s]);
            }
            
            Console.WriteLine("");
            Console.WriteLine("");
            
            for(int e = 1; e <= (iAnzahl - ((charArr.Length + 1) / 2)); e++)
            {
                Console.Write(" ");
            }
            for (int s = 0; s < charArr.Length; s++) {
                if (s % 2 == 0)
                    Console.ForegroundColor = ConsoleColor.Red;
                if ((s + 1) % 2 == 0)
                    Console.ResetColor();
                Console.Write(charArr[s]);
            }
            
            Console.WriteLine("");
            Console.WriteLine("");
        }
    }
}