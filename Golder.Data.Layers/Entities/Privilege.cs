using System;
using System.ComponentModel.DataAnnotations;

namespace Golder.Data.Layers.Entities
{
    public class Privilege
    {
        public int Id { get; set; }
        public string Label { get; set; }
        public int Creator { get; set; }
        public int Modifier { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public PrivilegeProfile PrivilegeProfile { get; set; }
    }
}
