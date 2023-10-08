using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Managemnet_System.Model
{
    public class DoctorSpecialization
    {
        public int Id { get; set; }
        [MaxLength(20, ErrorMessage = "Maximum length can't exceed 20 chars")]
        [MinLength(3, ErrorMessage = "Minimum length can't be less than 3 chars")]
        public string Name { get; set; }
    }
}
