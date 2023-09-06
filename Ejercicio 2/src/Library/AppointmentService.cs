using System;
using System.Text;

namespace Library
{
    public class AppointmentService
    {
        public static bool CreateAppointment(string name, string id, string phoneNumber, int patientAge, string doctorName, string doctorSpeciality, string doctorID, string appoinmentPlace,  DateTime date)
        {
            Boolean isValid = true;

            if (!ValidateString(name, "Patient's name"))
            {
                isValid = false;
            }

            if (!ValidateString(id, "Patient's ID"))
            {
                isValid = false;
            }

            if (!ValidateString(phoneNumber, "Patient's phone number"))
            {
                isValid = false;
            }
            
            if (!ValidateInt(patientAge, "Patient's age"))
            {
                isValid = false;
            }

            if (!ValidateString(doctorName, "Doctor's name"))
            {
                isValid = false;
            }

            if (!ValidateString (doctorID, "Doctor's ID"))
            {
                isValid = false;
            }

            if (!ValidateString (doctorSpeciality, "Doctor's speciality"))
            {
                isValid = false;
            }

            if (!ValidateString(appoinmentPlace, "Appointment place"))
            {
                isValid = false;
            }

            if (!ValidateString(date.ToString(), "Date Time"))
            {
                isValid = false;
            }

            return isValid;
        }

    }
}
