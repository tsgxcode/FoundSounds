using System;

namespace FoundSounds
{
    class Program
    {
        static void Main()

        {
            /* Found Sound - exploring the world of sound.
           A library of found sounds and the tools used to find them.
         */

            string author = "T. Scott George (C) Sept - 2020";
            string appName = "Found Sound Library";
            string appVersion = "1.0";

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("{1} {0} {2}", author, appName, appVersion);
            Console.ResetColor();

            Console.WriteLine("A world of found sounds");
        }
    }
}
