using ChallengeSevenSegment.Interfaces;

namespace ChallengeSevenSegment.Class
{
    public class NumberType : INumberType
    {
        private readonly string[,] encryptedMatrix;

        public NumberType(string[,] encryptedMatrix)
        {
            this.encryptedMatrix = encryptedMatrix;
        }

        public bool IsNumberZero()
        {
            return (encryptedMatrix[0, 0].Equals(".") && encryptedMatrix[0, 1].Equals("_") && encryptedMatrix[0, 2].Equals(".")
                && encryptedMatrix[1, 0].Equals("|") && encryptedMatrix[1, 1].Equals(".") && encryptedMatrix[1, 2].Equals("|")
                && encryptedMatrix[2, 0].Equals("|") && encryptedMatrix[2, 1].Equals("_") && encryptedMatrix[2, 2].Equals("|"));
        }

        public bool IsNumberNine()
        {
            return (encryptedMatrix[0, 0].Equals(".") && encryptedMatrix[0, 1].Equals("_") && encryptedMatrix[0, 2].Equals(".")
                && encryptedMatrix[1, 0].Equals("|") && encryptedMatrix[1, 1].Equals("_") && encryptedMatrix[1, 2].Equals("|")
                && encryptedMatrix[2, 0].Equals(".") && encryptedMatrix[2, 1].Equals(".") && encryptedMatrix[2, 2].Equals("|"));
        }

        public bool IsNumberEight()
        {
            return (encryptedMatrix[0, 0].Equals(".") && encryptedMatrix[0, 1].Equals("_") && encryptedMatrix[0, 2].Equals(".")
                && encryptedMatrix[1, 0].Equals("|") && encryptedMatrix[1, 1].Equals("_") && encryptedMatrix[1, 2].Equals("|")
                && encryptedMatrix[2, 0].Equals("|") && encryptedMatrix[2, 1].Equals("_") && encryptedMatrix[2, 2].Equals("|"));
        }

        public bool IsNumberSeven()
        {
            return (encryptedMatrix[0, 0].Equals(".") && encryptedMatrix[0, 1].Equals("_") && encryptedMatrix[0, 2].Equals(".")
                && encryptedMatrix[1, 0].Equals(".") && encryptedMatrix[1, 1].Equals(".") && encryptedMatrix[1, 2].Equals("|")
                && encryptedMatrix[2, 0].Equals(".") && encryptedMatrix[2, 1].Equals(".") && encryptedMatrix[2, 2].Equals("|"));
        }

        public bool IsNumberSix()
        {
            return (encryptedMatrix[0, 0].Equals(".") && encryptedMatrix[0, 1].Equals("_") && encryptedMatrix[0, 2].Equals(".")
                && encryptedMatrix[1, 0].Equals("|") && encryptedMatrix[1, 1].Equals("_") && encryptedMatrix[1, 2].Equals(".")
                && encryptedMatrix[2, 0].Equals("|") && encryptedMatrix[2, 1].Equals("_") && encryptedMatrix[2, 2].Equals("|"));
        }

        public bool IsNumberFive()
        {
            return (encryptedMatrix[0, 0].Equals(".") && encryptedMatrix[0, 1].Equals("_") && encryptedMatrix[0, 2].Equals(".")
                && encryptedMatrix[1, 0].Equals("|") && encryptedMatrix[1, 1].Equals("_") && encryptedMatrix[1, 2].Equals(".")
                && encryptedMatrix[2, 0].Equals(".") && encryptedMatrix[2, 1].Equals("_") && encryptedMatrix[2, 2].Equals("|"));
        }

        public bool IsNumberFour()
        {
            return (encryptedMatrix[0, 0].Equals(".") && encryptedMatrix[0, 1].Equals(".") && encryptedMatrix[0, 2].Equals(".")
                && encryptedMatrix[1, 0].Equals("|") && encryptedMatrix[1, 1].Equals("_") && encryptedMatrix[1, 2].Equals("|")
                && encryptedMatrix[2, 0].Equals(".") && encryptedMatrix[2, 1].Equals(".") && encryptedMatrix[2, 2].Equals("|"));
        }

        public bool IsNumberThree()
        {
            return (encryptedMatrix[0, 0].Equals(".") && encryptedMatrix[0, 1].Equals("_") && encryptedMatrix[0, 2].Equals(".")
                && encryptedMatrix[1, 0].Equals(".") && encryptedMatrix[1, 1].Equals("_") && encryptedMatrix[1, 2].Equals("|")
                && encryptedMatrix[2, 0].Equals(".") && encryptedMatrix[2, 1].Equals("_") && encryptedMatrix[2, 2].Equals("|"));
        }

        public bool IsNumberTwo()
        {
            return (encryptedMatrix[0, 0].Equals(".") && encryptedMatrix[0, 1].Equals("_") && encryptedMatrix[0, 2].Equals(".")
                && encryptedMatrix[1, 0].Equals(".") && encryptedMatrix[1, 1].Equals("_") && encryptedMatrix[1, 2].Equals("|")
                && encryptedMatrix[2, 0].Equals("|") && encryptedMatrix[2, 1].Equals("_") && encryptedMatrix[2, 2].Equals("."));
        }

        public bool IsNumberOne()
        {
            return (encryptedMatrix[0, 0].Equals(".") && encryptedMatrix[0, 1].Equals(".") && encryptedMatrix[0, 2].Equals(".")
                && encryptedMatrix[1, 0].Equals(".") && encryptedMatrix[1, 1].Equals(".") && encryptedMatrix[1, 2].Equals("|")
                && encryptedMatrix[2, 0].Equals(".") && encryptedMatrix[2, 1].Equals(".") && encryptedMatrix[2, 2].Equals("|"));
        }
    }
}