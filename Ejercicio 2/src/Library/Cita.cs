using System;

namespace Library;

public class Cita
{
    public Patient patientData {get;set;}
    public Doctor doctorData {get;set;}
    public DateTime appointmentTime {get;set;}
    public string appointmentPlace {get;set;}
    
    public Cita (Patient PatientData, Doctor DoctorData, DateTime AppointmentTime, string AppointmentPlace)
    {
        this.patientData = PatientData;
        this.doctorData = DoctorData;
        this.appointmentTime = AppointmentTime;
        this.appointmentPlace = AppointmentPlace;
    }
}
