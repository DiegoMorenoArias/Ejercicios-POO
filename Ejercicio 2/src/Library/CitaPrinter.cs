using System;

namespace Library
{
    public class CitaPrinter
    {
        public static void ImprimirCita (Cita CitaDatos) // Imprime todos los datos del objeto Cita que contiene todos los datos de la misma.
        {
            Console.WriteLine ($"\nAppointment was successfully scheduled.\n\nPatient's name: {CitaDatos.patientData.patientName} \nPatient's ID: {CitaDatos.patientData.patientID}\nPatient's phone number: {CitaDatos.patientData.phoneNumber}\nPatient's age: {CitaDatos.patientData.patientAge}\n\nDoctor's name: {CitaDatos.doctorData.doctorName}\nDoctor's speciality: {CitaDatos.doctorData.doctorArbeit}\nDoctor's ID: {CitaDatos.doctorData.doctorId}\n\nAppointmentPlace: {CitaDatos.appointmentPlace}\nAppointmentDate: {CitaDatos.appointmentTime}\n");
        }
    }
}