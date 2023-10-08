using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Managemnet_System.Model
{
    public class Prescription
    {
        public int Id { get; set; }
        [ForeignKey("Doctor")]
        public int DoctorID { get; set; }
        public Doctor Doctor { get; set; }
        [ForeignKey("Patient")]
        public int PatientID { get; set; }
        public Patient Patient { get; set; }

        public DateTime IssueDate { get; set; }
        public Status Status { get; set; }
        public List<Medication> medications { get; set; }
        [ForeignKey("Staff")]
        public int StaffID { get; set; }
        public User Staff { get; set; }
        public bool IsDeleted { get; set; }
    }
    public enum Status
    {
        Opened,
        Colsed,
        InQuee
    }
}
