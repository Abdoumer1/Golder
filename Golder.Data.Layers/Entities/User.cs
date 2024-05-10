using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Golder.Data.Layers.Entities
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int Creator { get; set; }
        public int Modifier { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public ICollection<Profile> Profiles { get; set; }
    }
}
