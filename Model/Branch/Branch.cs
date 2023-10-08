using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Managemnet_System.Model
{
    public class Branch
    {
        public int Id { get; set; }
        [MaxLength(15, ErrorMessage = "Maximum length can't exceed 15 chars")]
        [MinLength(3, ErrorMessage = "Minimum length can't be less than 3 chars")]
        public string Name { get; set; }
        public string Address { get; set; }
        [StringLength(11, ErrorMessage = "Number must be 11 digits", MinimumLength = 11)]
        public string Phone { get; set; }
        public List<User> Users { get; set; }
        public bool IsDeleted { get; set; }

    }
}
