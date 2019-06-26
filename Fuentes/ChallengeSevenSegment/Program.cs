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
                pathFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources\\SevenSegement.txt");
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
            Console.WriteLine("\n***************** Bienvenido *****************\n");
            Console.WriteLine("Este proyecto está construido en .NetCore 2.2 Console Application, por lo cual " +
                              "el SDK debe de estar instalado para su correcto funcionamiento.\n");
            Console.WriteLine("***************** Instrucciones *****************\n");
            Console.WriteLine("1. Para la correcta ejecución de esta aplicación " +
                              "necesitamos que sitúe el archivo a descifrar en la " +
                              "siguiente ruta relativa al proyecto: 'Fuentes/ChallengeSevenSegment/Resources/SevenSegementTest.txt', " +
                              "es importante que se mantenga el mismo nombre del archivo.\n"+
                              "Actualmente ya hay un archivo situado allí que cumple con las características solicitadas, por lo " +
                              "cual se puede dar uso de este.\n");
            Console.WriteLine("2. Se debió haber compilado la aplicación con el " +
                              "archivo en la ruta indicada.\n");
            Console.WriteLine("3. En caso de elegir una ruta diferente asegúrese de " +
                              "que pondrá la ruta completa (con extensión) cuando se " +
                              "le indique.\n");
            Console.WriteLine("4. Para ejecutar las pruebas unitarias hay dos alternativas:.\n");
            Console.WriteLine("   >> 4.1 Abrir el proyecto 'ChallengeSevenSegment.Tests' desde VisualStudio, " +
                                         "compilar el proyecto y desde el TestExplorer ejecutarlas.\n");
            Console.WriteLine("   >> 4.2 Compilar el proyecto 'ChallengeSevenSegment.Tests' y situarse " +
                                         "desde el explorador de windows/linux/mac en la raíz " +
                                         "del proyecto 'ChallengeSevenSegment.Tests' desde la ventana" +
                                         "de comandos y ejecutar el siguiente comando: 'dotnet test'.\n" +
                                         "De forma inmediata se ejecutarán las pruebas programadas.\n\n");

        }
    }
}