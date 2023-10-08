using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Managemnet_System.Model
{
    public class Supplier: IPerson
    {
        public int Id { get; set; }
        [MaxLength(30, ErrorMessage = "Maximum length can't exceed 30 chars")]
        [MinLength(7, ErrorMessage = "Minimum length can't be less than 7 chars")]
        public string Name { get; set; }
        [StringLength(11, ErrorMessage = "Number must be 11 digits", MinimumLength = 11)]

        public string Phone { get; set; }
        public string Notes { get; set; }
        public bool IsDeleted { get; set; }
        [ForeignKey("company")]
        public int CompanyID { get; set; }
        public Company company { get; set; }
    }
}
