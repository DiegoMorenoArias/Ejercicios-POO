using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            if (AppointmentService.CreateAppointment("Steven Jhonson", "986782342", "1.212.121-2", 19, "Carlos Dominica", "Gynecologist", "1.234.567-2" , "Wall Street", DateTime.Now))
            {
                Patient Steven = new Patient("Steven Jhonson", "986782342", "1.212.121-2", 19);
                Doctor Carlos = new Doctor("Carlos Dominica", "Gynecologist", "1.234.567-2");
                Cita Cita1 = new Cita (Steven, Carlos, "Wall Street", DateTime.Now);
                CitaPrinter.ImprimirCita(Cita1);
            }
            else
            {
                Console.WriteLine("\nAppointment could not be scheduled. Please correct the missing parts indicated above.")
            }
        }
    }
}
