using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Managemnet_System.Model
{
    public class Company
    {
        [MaxLength(40, ErrorMessage = "Maximum length can't exceed 40 chars")]
        [MinLength(7, ErrorMessage = "Minimum length can't be less than 7 chars")]
        public string Name { get; set; }
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
        public List<Supplier> Suppliers { get; set; }
        public List<Medication> medications { get; set; }
    }
}
