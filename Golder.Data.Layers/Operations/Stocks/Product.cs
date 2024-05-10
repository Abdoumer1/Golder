using System;
using System.ComponentModel.DataAnnotations;

namespace Golder.Data.Layers.Operations.Stocks
{
    public class Product
    {
        [Key]
        public int ID { get; set; }
        public int Cod { get; set; }
        public string Label { get; set; }
        public int Creator { get; set; }
        public int Modifier { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public Category Category { get; set; }
        public Family Family { get; set; }
        public Collection Collection { get; set; }
    }
}
