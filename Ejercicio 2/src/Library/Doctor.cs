using System;

namespace Library;

public class Doctor
{   
    public string doctorName {get;}
    public string doctorArbeit {get;}
    public string doctorId {get;}
    public Doctor (string DoctorName, string DoctorArbeit, string DoctorId)
    {
        this.doctorName = DoctorName;
        this.doctorArbeit = DoctorArbeit;
        this.doctorId = DoctorId;
    }
}
