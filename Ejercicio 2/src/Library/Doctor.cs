using System;

namespace Library;

public class Doctor
{   
    public string doctorName {get;} // Nombre del doctor
    public string doctorArbeit {get;} // Especialidad del doctor
    public string doctorId {get;} // Cédula del doctor
    public Doctor (string DoctorName, string DoctorArbeit, string DoctorId) // Recibe los tres parámetros y crea el objeto doctor.
    {
        this.doctorName = DoctorName;
        this.doctorArbeit = DoctorArbeit;
        this.doctorId = DoctorId;
    }
}
