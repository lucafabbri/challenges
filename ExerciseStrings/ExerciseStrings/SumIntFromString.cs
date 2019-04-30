using System;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;

namespace ExerciseStrings
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
            if (string.IsNullOrEmpty(numbers))
            {
                return result;
            }

            //how numbers are distincted
            var delimiters = Regex.Matches(numbers, delimiterPatter);

            //dinamic pattern to split the number portion of the string
            string[] splitPattern = new string[(delimiters.Count > 0) ? delimiters.Count : 1];
            if (delimiters.Count > 0)
            {
                for (int i = 0; i < delimiters.Count; i++)
                {
                    splitPattern[i] = delimiters[i].Value.Replace("[", "").Replace("]", "");
                }
            }
            else
            {
                splitPattern[0] = ",";
            }

            //getting the number portion of the string
            var stringOfNumbers = numbers.Split(new string[] { "//" }, StringSplitOptions.None);

            //splitting tehe string in an array of numbers rapresented as a string
            var stringOfNumbersArray = stringOfNumbers[stringOfNumbers.Length - 1].Split(splitPattern, StringSplitOptions.None);

            //iterating over the array to sum each number
            foreach (var stringNumber in stringOfNumbersArray)
            {
                var parse = int.TryParse(stringNumber, out int n);
                if (parse)
                {
                    if (n < 0)
                    {
                        throw new NegativeNotAllowedException();
                    }
                    if (n < 1000)
                    {
                        result += n;
                    }
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
