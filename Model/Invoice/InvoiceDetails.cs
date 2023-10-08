using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Managemnet_System.Model
{
    public class InvoiceDetails
    {
        public int Id { get; set; }
        [ForeignKey("Medication")]
        public int MedicationID { get; set; }
        public Medication Medication { get; set; }
        [MaxLength(20, ErrorMessage = "Maximum length can't exceed 20 chars")]
        [MinLength(5, ErrorMessage = "Minimum length can't be less than 5 chars")]
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string DoseConcentration { get; set; }
        public decimal Discount { get; set; }
        public string Dosage { get; set; }
        public bool IsDeleted { get; set; }
    }
   
}
