using ChallengeSevenSegment.Class;
using System;
using System.Text;

namespace ChallengeSevenSegment
{
    public class File : IFile
    {
        private readonly string path;
        private const int MATRIX_ROWS = 3;
        private const int MATRIX_COLUMNS = 3;

        public File(string path)
        {
            this.path = path;
        }

        public string ProcessFile()
        {
            if (!System.IO.File.Exists(path))
                return Resources.LocalResource.Error_File_No_Exist;

            string[] content = System.IO.File.ReadAllLines(path);
            Console.WriteLine("\nSe procede a descifrar el siguiente contenido:\n");
            PrintContentFile(content);
            return DoWork(content);
        }

        private void PrintContentFile(string[] content)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = 0; i < content.Length; i++)
            {
                Console.WriteLine(content[i]);
            }
            Console.WriteLine("\n");
        }

        private string DoWork(string[] content)
        {
            StringBuilder message = new StringBuilder();
            string[] rowOne = content[0].Split(' ');
            string[] rowTwo = content[1].Split(' ');
            string[] rowThree = content[2].Split(' ');

            if (!ValidateLengthAllRows(rowOne, rowTwo, rowThree, message))
                return message.ToString();

            for (int i = 0; i < rowOne.Length; i++)
            {
                string[,] matrix = new string[MATRIX_ROWS, MATRIX_COLUMNS];
                ValidateAndFillRowMatrix(rowOne[i].ToCharArray(), matrix, 0, message);
                ValidateAndFillRowMatrix(rowTwo[i].ToCharArray(), matrix, 1, message);
                ValidateAndFillRowMatrix(rowThree[i].ToCharArray(), matrix, 2, message);
                NumberType numberType = new NumberType(matrix);
                if (message.ToString().Contains("Error"))
                    return string.Format(message.ToString(), i + 1);
                message.Append(DecodeNumber(numberType));
            }
            return message.ToString();
        }

        private bool ValidateLengthAllRows(string[] rowOne, string[] rowTwo, string[] rowThree, StringBuilder errorMessage)
        {
            if ((rowOne.Length != rowTwo.Length) || (rowOne.Length != rowThree.Length)
                || (rowTwo.Length != rowThree.Length))
            {
                errorMessage.Append(Resources.LocalResource.Error_NumberLength);
                return false;
            }

            return true;
        }

        private void ValidateAndFillRowMatrix(char[] charactersRow, string[,] matrix, int row, StringBuilder errorMessage)
        {
            if (charactersRow.Length != 3)
            {
                errorMessage.Append(" - ");
                errorMessage.Append(Resources.LocalResource.Error_InconsistentRow);
                return;
            }

            for (int m = 0; m < charactersRow.Length; m++)
            {
                if (charactersRow[m].ToString() != null && (charactersRow[m].ToString().Equals(".") ||
                    charactersRow[m].ToString().Equals("|") || charactersRow[m].ToString().Equals("_")))
                    matrix[row, m] = charactersRow[m].ToString();
                else
                {
                    errorMessage.Append(" - ");
                    errorMessage.Append(Resources.LocalResource.Error_IncorrectCharacters);
                    return;
                }
            }
        }

        private string DecodeNumber(NumberType numberType)
        {
            if (numberType.IsNumberOne())
                return "1";

            if (numberType.IsNumberTwo())
                return "2";

            if (numberType.IsNumberThree())
                return "3";

            if (numberType.IsNumberFour())
                return "4";

            if (numberType.IsNumberFive())
                return "5";

            if (numberType.IsNumberSix())
                return "6";

            if (numberType.IsNumberSeven())
                return "7";

            if (numberType.IsNumberEight())
                return "8";

            if (numberType.IsNumberNine())
                return "9";

            if (numberType.IsNumberZero())
                return "0";

            return Resources.LocalResource.Error_Decoding_Number;
        }
    }
}