using System;
using System.ComponentModel.DataAnnotations;

namespace Golder.Data.Layers.Entities
{
    public class Profile
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Creator { get; set; }
        public int Modifier { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public User User { get; set; }
        public PrivilegeProfile PrivilegeProfile { get; set; }
    }
}
