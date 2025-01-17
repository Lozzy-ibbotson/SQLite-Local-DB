using System;
using System.Collections.Generic;

namespace v4._8_Sqlite_Tester.Models
{
    public partial class Hotspot
    {
        public int Id { get; set; }

        public int Color { get; set; }

        public string Name { get; set; } //= null!; (nullable)

        public int PlanId { get; set; }

        public int? LinkViewId { get; set; }

        public bool HasWarning { get; set; }

        public virtual ICollection<Coordinate> Coordinates { get; set; } = new List<Coordinate>();

        public virtual ICollection<LinkZone> LinkZones { get; set; } = new List<LinkZone>();

        public virtual Plan Plan { get; set; } //= null!; (nullable)
    }
}
