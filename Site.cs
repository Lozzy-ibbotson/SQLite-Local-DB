using Sqlite_EF_Tester.Models;
using System;
using System.Collections.Generic;

namespace v4._8_Sqlite_Tester.Models
{
    public partial class Site
    {
        public int Id { get; set; }

        public string Notes { get; set; } //= null!; (nullable)

        public virtual ICollection<Location> Locations { get; set; } = new List<Location>();

        public virtual ICollection<Zone> Zones { get; set; } = new List<Zone>();
    }
}
