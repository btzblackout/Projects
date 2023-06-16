using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppointmentMaker.Models
{
    public class AppointmentModel
    {
        [Required]
        [DisplayName("Patient's Full Name")]
        [StringLength(20, MinimumLength = 4)]
        public string patientName { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayName("Appointment Request Date")]
        public DateTime dateTime { get; set; }

        [DisplayName("Patient's approximate net worth")]
        [Range(90000, Int32.MaxValue, ErrorMessage ="The net worth must be at least $90,000")]
        [DataType(DataType.Currency)]
        
        public decimal PatientNetWorth { get; set; }

        [DisplayName("Primary Doctor's Last Name")]
        public string DoctorName { get; set; }

        [Required]
        [Range(6,10, ErrorMessage = "Pain must be over 5.")]
        [DisplayName("Patient's perceived level of pain (1 low to 10 high)")]
        public int PainLevel { get; set; }

        [Required]
        [DisplayName("Patient's street address")]
        public string Street { get; set; }

        [Required]
        [DisplayName("Patient's city")]
        public string City { get; set; }

        [Required]
        [DisplayName("Patients zipcode")]
        public int Zipcode { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [DisplayName("Patient's email address")]
        public string Email { get; set; }

        [Required (ErrorMessage = "You must provide a phone number")]
        [DataType(DataType.PhoneNumber)]
        [DisplayName("Patient's phone number")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
        public string PhoneNumber { get; set; }




        public AppointmentModel()
        {

        }

        public AppointmentModel(string patientName, DateTime dateTime, decimal patientNetWorth, string doctorName, int painLevel, string street, string city, int zipcode, string email, string phoneNumber)
        {
            this.patientName = patientName;
            this.dateTime = dateTime;
            PatientNetWorth = patientNetWorth;
            DoctorName = doctorName;
            PainLevel = painLevel;
            Street = street;
            City = city;
            Zipcode = zipcode;
            Email = email;
            PhoneNumber = phoneNumber;
        }
    }
}
