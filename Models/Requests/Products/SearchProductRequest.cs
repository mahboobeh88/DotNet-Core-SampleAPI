using Newtonsoft.Json.Converters;
using sampleAPI.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace sampleAPI.Models.Requests.Products
{
    public class SearchProductRequest
    {
        public Enums.ProductTypes? ProductType { get; set; }
        public Enums.Colors? ProductColor { get; set; }
    }
}
