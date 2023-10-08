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
    public class Medication
    {
        public int Id { get; set; }
        [MaxLength(30, ErrorMessage = "Maximum length can't exceed 30 chars")]
        [MinLength(7, ErrorMessage = "Minimum length can't be less than 7 chars")]
        public string Name { get; set; }

        [ForeignKey("company")]
        public int ManufacturerID { get; set; }
        public Company company { get; set; }
        public string Dose { get; set; }
        public decimal BuyPrice { get; set; }
        public decimal SalePrice { get; set; }
        [ForeignKey("drugConcentrationPrice")]
        public int UnitPriceID { get; set; }
        public DrugConcentrationPrice drugConcentrationPrice { get; set; }
        public decimal Discount { get; set; }
        public int Quantity { get; set; }
        public string Barcode { get; set; }
        public string LocationOnShelf { get; set; }
        public byte[] Photo { get; set; }
        public bool IsDeleted { get; set; }
        public string Description { get; set; }
        public MedicineCategory medicineCategory { get; set; }
    }
    public enum MedicineCategory
    {
        Tablets,
        Capsules,
        Pills,
        Liquids,
        Inhalers,
        TopicalCreams,
        Suppositories,
        Patches,
        Drops,
        sprays,
        Powders,
        Injectables
    }
}
