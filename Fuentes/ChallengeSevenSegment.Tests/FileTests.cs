using System;
using System.IO;
using Xunit;

namespace ChallengeSevenSegment.Tests
{
    public class FileTests
    {
        [Fact]
        public void FileNotFoundTest()
        {
            string expected = "Error: El archivo no existe. Por favor verifique e intente nuevamente.";
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "SevenSegement.txt");
            File file = new File(path);
            string actual = file.ProcessFile();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void DecodeNumberTest()
        {
            string expected = "12345678901234";
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources\\SevenSegement.txt");
            File file = new File(path);
            string actual = file.ProcessFile();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FileWithDataCorruptedTest()
        {
            string expected = " - Error decifrando bloque número 1: Solo se permiten los valores: '.' , '_' y '|'.";
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources\\SevenSegementCorrupted_1.txt");
            File file = new File(path);
            string actual = file.ProcessFile();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void NumberNotMeetPatternTest()
        {
            string expected = "12Error: No fue posible decodificar el número.";
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources\\SevenSegementCorrupted_2.txt");
            File file = new File(path);
            string actual = file.ProcessFile();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void PatternNotMeetLengthTest()
        {
            string expected = "1 - Error decifrando bloque número 2: El tamaño de la fila y columna tiene que ser de tres (3).";
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources\\SevenSegementCorrupted_3.txt");
            File file = new File(path);
            string actual = file.ProcessFile();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void PatternNotMeetLengthNumberTest()
        {
            string expected = "Error: Todas las filas y columnas deben de contener la misma longitud (3x3) respectivamente.";
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources\\SevenSegementCorrupted_4.txt");
            File file = new File(path);
            string actual = file.ProcessFile();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void EmptyFileTest()
        {
            string expected = "Error: El archivo no contiene tres (3) files o está vacío.";
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources\\SevenSegementCorrupted_5.txt");
            File file = new File(path);
            string actual = file.ProcessFile();
            Assert.Equal(expected, actual);
        }
    }
}