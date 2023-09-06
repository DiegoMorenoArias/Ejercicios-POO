using System;
using System.Text;

namespace Library
{
    public class AppointmentService
    {
        public static bool CreateAppointment(string name, string id, string phoneNumber, int patientAge, string doctorName, string doctorSpeciality, string doctorID, string appoinmentPlace,  DateTime date)
        {
            Boolean isValid = true;

            if (!Validation.ValidateString(name, "Patient's name"))
            {
                isValid = false;
            }

            if (!Validation.ValidateString(id, "Patient's ID"))
            {
                isValid = false;
            }

            if (!Validation.ValidateString(phoneNumber, "Patient's phone number"))
            {
                isValid = false;
            }
            
            if (!Validation.ValidateInt(patientAge, "Patient's age"))
            {
                isValid = false;
            }

            if (!Validation.ValidateString(doctorName, "Doctor's name"))
            {
                isValid = false;
            }

            if (!Validation.ValidateString (doctorID, "Doctor's ID"))
            {
                isValid = false;
            }

            if (!Validation.ValidateString (doctorSpeciality, "Doctor's speciality"))
            {
                isValid = false;
            }

            if (!Validation.ValidateString(appoinmentPlace, "Appointment place"))
            {
                isValid = false;
            }

            if (!Validation.ValidateString(date.ToString(), "Date Time"))
            {
                isValid = false;
            }

            return isValid;
        }

    }
}
