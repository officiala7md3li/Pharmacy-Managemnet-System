using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Managemnet_System.Model
{
    public class User: IPerson
    {
        public int Id { get; set; }
        [Index(IsUnique = true)]
        [MaxLength(20, ErrorMessage = "Maximum length can't exceed 20 chars")]
        [MinLength(3, ErrorMessage = "Minimum length can't be less than 3 chars")]
        public string UserName { get; set; }
        
        [MaxLength(30, ErrorMessage = "Maximum length can't exceed 30 chars")]
        [MinLength(7, ErrorMessage = "Minimum length can't be less than 7 chars")]
        public string Name { get; set; }
        [MinLength(3,ErrorMessage ="Recovery Word can't be less than 3 chars")]
        public string RecoverWord { get; set; }
        public string Position { get; set; }
        [StringLength(11, ErrorMessage = "Number must be 11 digits", MinimumLength = 11)]
        public string Phone { get; set; }
        [ForeignKey("branch")]
        public int BranchID { get; set; }
        public Branch branch { get; set; }
        //todo: add authorization object to map to
        public int AuthorizationProfileID { get; set; }
        public string Password { get; set; }
        public byte[] Photo { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }

    }
}
