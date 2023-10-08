using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Managemnet_System.Model
{
    public class PatientPayment:IPayment
    {
        public int Id { get; set; }
        [ForeignKey("patient")]
        public int PersonID { get; set; }
        public Patient patient { get; set; }
        public decimal Debit { get; set; }
        public decimal Credit { get; set; }
        public string Details { get; set; }
        public DateTime TransactionTime { get; set; }
        public IPaymentMethod paymentMethod { get; set; }

        public string Name { get; set; }
        [ForeignKey("users")]
        public int StaffID { get; set; }
        public User users { get; set; }
    }
}
