using System;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;

namespace StringExercise
{
    public class SumIntFromString
    {
        const string delimiterPatter = @"\[(.*?)\]";
        public SumIntFromString()
        {
        }

        public int Add(string numbers)
        {
            //in case no match or string empty this is default result
            int result = 0;

            //how numbers are distincted
            var delimiters = Regex.Matches(numbers, delimiterPatter);

            //dinamic pattern to split the number portion of the string
            string splitPattern = @"";
            if (delimiters.Count > 0)
            {
                foreach (Match d in delimiters)
                {
                    splitPattern += string.IsNullOrEmpty(splitPattern) ? d.Value : ("|" + d.Value);
                }
            }
            else
            {
                splitPattern = @",";
            }

            //getting the number portion of the string
            var stringOfNumbers = numbers.Split(new string[] { "//" }, StringSplitOptions.None);

            //splitting tehe string in an array of numbers rapresented as a string
            var stringOfNumbersArray = Regex.Split(stringOfNumbers[stringOfNumbers.Length - 1], splitPattern);

            //iterating over the array to sum each number
            foreach (var stringNumber in stringOfNumbersArray)
            {
                var n = int.Parse(stringNumber);
                if (n < 0)
                {
                    throw new NegativeNotAllowedException();
                }
                if (n < 1000)
                {
                    result += n;
                }
            }
            return result;
        }
    }

    [Serializable]
    public class NegativeNotAllowedException : Exception
    {
        public NegativeNotAllowedException()
        {
        }

        public NegativeNotAllowedException(string message) : base(message)
        {
        }

        public NegativeNotAllowedException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NegativeNotAllowedException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
