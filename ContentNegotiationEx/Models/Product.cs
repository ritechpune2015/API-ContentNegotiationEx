using System.Reflection.Metadata.Ecma335;

namespace ContentNegotiationEx.Models
{
    public class Product
    {
        public Int64 ProductID { get; set; }
        public string ProductName { get; set; }
        public string MfgName { get; set; }
        public decimal Price { get; set; }
    }
}

