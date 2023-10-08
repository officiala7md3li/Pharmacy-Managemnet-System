using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Managemnet_System.Model
{
    public class Doctor: IPerson
    {

        public int Id { get; set; }
        [MaxLength(30, ErrorMessage = "Maximum length can't exceed 30 chars")]
        [MinLength(7, ErrorMessage = "Minimum length can't be less than 7 chars")]
        public string Name { get; set; }
        public DoctorSpecialization DoctorSpecialization { get; set; }
        [ForeignKey("DoctorSpecialization")]
        public int SpecializationID { get; set; }
        [StringLength(11,ErrorMessage ="Number must be 11 digits",MinimumLength =11)]
        public string Phone { get; set; }
        public string Address { get; set; }
        public bool IsDeleted { get; set; }
    }
}
