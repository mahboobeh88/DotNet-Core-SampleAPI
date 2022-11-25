using sampleAPI.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sampleAPI.Models.Entities
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public Enums.ProductTypes Type { get; set; }
        public double Price { get; set; }
        public Enums.Colors Color { get; set; }
    }
}
