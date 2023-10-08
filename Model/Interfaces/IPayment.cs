using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Managemnet_System.Model
{
    internal interface IPayment
    {
         int Id { get; set; }



         int PersonID { get; set; }

         decimal Debit { get; set; }
         decimal Credit { get; set; }
         string Details { get; set; }
         DateTime TransactionTime { get; set; }
         IPaymentMethod paymentMethod { get; set; }

         string Name { get; set; }
        [ForeignKey("users")]
         int StaffID { get; set; }
         User users { get; set; }
    }
    public enum IPaymentMethod
    {
        Cash,
        Visa,
        POS,
        Cheque
    }
}
