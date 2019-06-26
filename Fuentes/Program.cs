using System;
using System.IO;

namespace ChallengeSevenSegment
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            PrintInstructions();
            PrintOptions(out string option);
            string pathFile;
            if (option.Equals("S"))
                pathFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources\\SevenSegementTest.txt");
            else
                PrintPath(out pathFile);

            string results = new File(Path.Combine(pathFile)).ProcessFile();
            PrintResults(results);
            Console.ReadKey();
        }

        private static void PrintResults(string results)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\n\n*************** Resultados! ***************\n");
            Console.WriteLine(results);
            Console.WriteLine("\n\n");
        }

        private static void PrintPath(out string path)
        {
            Console.Write("\n>>> Por favor digite la ruta completa (con extensión txt) " +
                            "del archivo que se descifrará: ");
            path = Console.ReadLine();
            while (string.IsNullOrEmpty(path))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Por favor, digite una ruta válida\n");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\n>>> Por favor digite la ruta completa (con extensión txt)" +
                "del archivo que se descifrará: ");
                path = Console.ReadLine();
            }
        }

        private static void PrintOptions(out string option)
        {
            Console.WriteLine("***************** Inicio de la aplicación *****************\n");
            Console.Write("\n>>> Situó el archivo a descifrar en la ruta relativa? (S/N): ");
            option = Console.ReadLine();
            while (string.IsNullOrEmpty(option) || (!option.Equals("S") && !option.Equals("N")))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Por favor, digite una opción válida\n");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\n>>> Situó el archivo a descifrar en la ruta relativa? (S/N): ");
                option = Console.ReadLine();
            }
        }

        private static void PrintInstructions()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("***************** Bienvenido *****************\n");
            Console.WriteLine("***************** Instrucciones *****************\n");
            Console.WriteLine("1. Para la correcta ejecución de esta aplicación " +
                              "necesitamos que sitúe el archivo a descifrar en la " +
                              "siguiente ruta relativa al proyecto: 'Fuentes/Resources/SevenSegementTest.txt' " +
                              "es importante que se mantenga el mismo nombre del archivo.\n");
            Console.WriteLine("2. Se debió haber compilado la aplicación con el " +
                              "archivo en la ruta indicada.\n");
            Console.WriteLine("3. En caso de elegir una ruta diferente asegúrese de " +
                              "que pondrá la ruta completa (con extensión) cuando se " +
                              "le indique.\n");
        }
    }
}