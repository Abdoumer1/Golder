using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Golder.Data.Layers.Entities
{
    public class PrivilegeProfile
    {
        public int Id { get; set; }
        public string Label { get; set; }
        public int Creator { get; set; }
        public int Modifier { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public ICollection<Privilege> Privileges { get; set; }
        public Profile Profile { get; set; }
    }
}
