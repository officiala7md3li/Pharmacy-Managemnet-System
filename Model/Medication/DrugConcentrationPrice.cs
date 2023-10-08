using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Managemnet_System.Model
{
    public class DrugConcentrationPrice
    {
        public int Id { get; set; }
        public string  DoseConcentration { get; set; }
        public decimal Price { get; set; }

    }
}
