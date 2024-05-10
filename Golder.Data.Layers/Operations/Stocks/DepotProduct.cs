using System;
using System.ComponentModel.DataAnnotations;

namespace Golder.Data.Layers.Operations.Stocks
{
    public class DepotProduct
    {
        [Key]
        public int ID { get; set; }
        public string Label { get; set; }
        public int Quantity { get; set; }
        public float PurchasePrice { get; set; }
        public float SalePrice { get; set; }
        public int Creator { get; set; }
        public int Modifier { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public Depot Depot { get; set; }
        public Product Product { get; set; }
    }
}
