using System;

namespace Library;

public class Patient
{
    public string patientName { get;}
    public string patientID { get;}
    public string phoneNumber { get;}
    public int patientAge { get;}
    public Patient(string Name, string Id, string PhoneNumber, int PatientAge)
    {
        this.patientName = Name;
        this.patientID = Id;
        this.phoneNumber = PhoneNumber;
        this.patientAge = PatientAge;
    }
}