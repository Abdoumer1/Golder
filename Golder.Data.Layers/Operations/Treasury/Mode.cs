using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Golder.Data.Layers.Operations.Treasury
{
    public class Mode
    {
        [Key]
        public int Id { get; set; }

        public int Cod { get; set; }

        public string Label { get; set; }
        public ICollection<OperationTreasury> OperationTreasury { get; set; }
    }
}
