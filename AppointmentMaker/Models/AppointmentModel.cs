using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AppointmentMaker.Models
{
    public class AppointmentModel
    {
        [StringLength(20, MinimumLength =4)]
        [DisplayName("Patient's full name")]
        public required string PatientName { get; set; }
        [DataType(DataType.Date)]
        [DisplayName("Appointment Request Date")]
        public DateTime AppointmentDate { get; set; }
        [DataType(DataType.Currency)]
        [Range(90000, maximum:Int32.MaxValue)]
        [DisplayName("Patient's Approximate Net Worth")]
        public decimal PatientNetWorth { get; set; }
        [DisplayName("Patient's Doctor's Last Name")]
        public required string DoctorName { get; set; }
        [Range(6,10)]
        [DisplayName("Patient's Perceived Level of Pain (1 low to 10 high)")]
        public int PainLevel { get; set; }
    }
}
