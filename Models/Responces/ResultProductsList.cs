using sampleAPI.Models.Entities;
using sampleAPI.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sampleAPI.Models.Responces
{
    public class ResultProductsList
    {
        public List<Product> ProductsList { get; set; }
        public int TotalCount { get; set; }
    }
}
