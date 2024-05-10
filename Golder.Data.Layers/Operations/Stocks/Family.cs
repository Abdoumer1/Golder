using System;
using System.ComponentModel.DataAnnotations;

namespace Golder.Data.Layers.Operations.Stocks
{
    public class Family
    {
        [Key]
        public int ID { get; set; }
        public string Label { get; set; }
        public int Creator { get; set; }
        public int Modifier { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
    }
}
