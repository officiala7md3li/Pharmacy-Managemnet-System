using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Managemnet_System.Model
{
    public class InvoiceHeader
    {
        public int Id { get; set; }

        [ForeignKey("staff")]
        public int StaffID { get; set; }
        public User staff { get; set; }

        [ForeignKey("patient")]
        public int PatientID { get; set; }
        public Patient patient { get; set; }
        [ForeignKey("doctor")]
        public int DoctorID { get; set; }
        public Doctor doctor { get; set; }

        public int QuantitySold { get; set; }
        public DateTime IssueTime { get; set; }
        public decimal TotalPrice { get; set; }
        public PaymentMethod paymentMethod { get; set; }
        public PaymentStatus paymentStatus { get; set; }
        [ForeignKey("PatientPayment")]
        public int PaymentID { get; set; }
        public PatientPayment PatientPayment { get; set; }

        public bool IsDeleted { get; set; }

    }
    public enum PaymentStatus
    {
       Completed,
       Pending,
       Failed
    }
    public enum PaymentMethod
    {
        Cash,
        Credit,
        Visa,
        POS
    }
}
