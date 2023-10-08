using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Managemnet_System.Model
{
    public class Patient: IPerson
    {
        
        public int Id { get; set; }
        [MaxLength(30, ErrorMessage ="Max length can't exceed 30 chars")]
        [MinLength(7,ErrorMessage ="Minimum length can't be less than 7 chars")]
        public string Name { get; set; }
        public string Address { get; set; }
        [StringLength(11, ErrorMessage = "Number must be 11 digits", MinimumLength = 11)]

        public string Phone { get; set; }
        public bool IsDeleted { get; set; }
        public bool Insurance { get; set; }
    }
}
