using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomApp.Models
{
    public class GoodType
    {
        public int GoodTypeId { get; set; }
        public string TypeName { get; set; }
        public string Measurement { get; set; }
        public double AmountOfFee { get; set; }
    }
}
