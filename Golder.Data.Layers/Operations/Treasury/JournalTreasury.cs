using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Golder.Data.Layers.Operations.Treasury
{
    public class JournalTreasury
    {
        [Key]
        public int ID { get; set; }
        public string Label { get; set; }
        public int Creator { get; set; }
        public int Modifier { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public ICollection<OperationTreasury> OperationTreasury { get; set; }
    }
}
