using System;

namespace Library;

public class Cita
{
    public Patient patientData {get;set;}
    public Doctor doctorData {get;set;}
    public DateTime appointmentTime {get;set;}
    public string appointmentPlace {get;set;}
    
    public Cita (Patient PatientData, Doctor DoctorData, string AppointmentPlace, DateTime AppointmentTime) // Recibe el objeto Paciente y Doctor
    // y las informaciones correspondientes a la cita. Teniendo así un objeto con todos los detalles de la cita.
    {
        this.patientData = PatientData;
        this.doctorData = DoctorData;
        this.appointmentTime = AppointmentTime;
        this.appointmentPlace = AppointmentPlace;
    }
}
