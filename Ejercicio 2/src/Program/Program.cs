using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            if (AppointmentService.CreateAppointment("Steven Jhonson", "986782342", "1.212.121-2", 19, "Carlos Dominica", "Gynecologist", "1.234.567-2" , "Wall Street", DateTime.Now))
            // Si todo es valido entonces la función CreateAppointment devolverá True. En dicho caso creamos el paciente, el doctor y la cita.
            // Si cualquier información no es válida entonces no creamos ningún objeto y se imprimirá por qué y que no se pudo procesar ni agendar.
            {
                Patient Steven = new Patient("Steven Jhonson", "986782342", "1.212.121-2", 19);
                Doctor Carlos = new Doctor("Carlos Dominica", "Gynecologist", "1.234.567-2");
                Cita Cita1 = new Cita (Steven, Carlos, "Wall Street", DateTime.Now);
                CitaPrinter.ImprimirCita(Cita1);
            }
            else
            {
                Console.WriteLine("\nAppointment could not be scheduled. Please correct the missing parts indicated above."); // Si sale false se imprime eso.
            }
        }
    }
}
