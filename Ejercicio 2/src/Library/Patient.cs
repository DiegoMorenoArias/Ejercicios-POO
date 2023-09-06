using System;

namespace Library;

public class Patient
{
    public string patientName { get;} // Nombre del paciente
    public string patientID { get;} // Cédula del paciente
    public string phoneNumber { get;} // Teléfono del paciente
    public int patientAge { get;} // Edad del paciente
    public Patient(string Name, string Id, string PhoneNumber, int PatientAge) // Recibe las informaciones correspondientes y crea el objeto paciente
    {
        this.patientName = Name;
        this.patientID = Id;
        this.phoneNumber = PhoneNumber;
        this.patientAge = PatientAge;
    }
}