using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace sampleAPI.Utilities
{
    public class Enums
    {
        public enum ProductTypes
        {
            [Display(Name ="Laptop")]
            Laptop = 0,
            [Display(Name ="SmartPhone")]
            SmartPhone = 1,
            [Display(Name = "SmartWatch")]
            SmartWatch = 2
        }
        public enum Colors
        {
            [Display(Name = "White")]
            White =0,
            [Display(Name = "Black")]
            Black =1,
            [Display(Name = "Beige")]
            Beige =2,
            [Display(Name = "Gold")]
            Gold =3,
            [Display(Name = "GoldBeige")]
            GoldBeige =4
        }
    }
}
