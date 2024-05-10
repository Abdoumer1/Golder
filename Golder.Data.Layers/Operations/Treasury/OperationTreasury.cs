using Golder.Data.Layers.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace Golder.Data.Layers.Operations.Treasury
{
    public class OperationTreasury
    {
        [Key]
        public int ID { get; set; }

        public string Code { get; set; }

        public string Label { get; set; }

        public float Amount { get; set; }

        public float Debit { get; set; }

        public float Credit { get; set; }

        public float Rest { get; set; }

        public DateTime Date { get; set; }
        public JournalTreasury JournalTreasury { get; set; }

        public Account Account { get; set; }

        public Supplier Supplier { get; set; }

        public Tierstype Tierstype { get; set; }

        public Mode Mode { get; set; }

    }
}
