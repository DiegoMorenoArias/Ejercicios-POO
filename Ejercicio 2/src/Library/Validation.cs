using System;
namespace Library
{
    public class Validation
    {
        public static bool ValidateString(string Parameter, string ParameterName)
        {
            if (string.IsNullOrWhiteSpace(Parameter)) // Si el parámetro es nulo o un espacio vacío devolverá false y dirá que no se pudo
            //procesar y qué es lo que falta.
            {
                Console.WriteLine($"Unable to process. {ParameterName} is required.");
                return false;
            }
            return true;
        }

        public static bool ValidateInt(int Parameter, string ParameterName) // Misma forma de validación, pero en vez de recibir un string,
        // recibe un entero.
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
