using System;
namespace Library
{
    public class Validation
    {
        public static bool ValidateString(string Parameter, string ParameterName)
        {
            if (string.IsNullOrWhiteSpace(Parameter))
            {
                Console.WriteLine($"Unable to process. {ParameterName} is required.");
                return false;
            }
            return true;
        }

        public static bool ValidateInt(int Parameter, string ParameterName)
        {
            if (Parameter < 0)
            {
                Console.WriteLine($"Unable to process. {ParameterName} must be valid.");
                return false;
            }
            return true;
        }
    }
}
