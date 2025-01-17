using Sqlite_EF_Tester.Models;
using System;
using System.Collections.Generic;

namespace v4._8_Sqlite_Tester.Models
{
    public partial class View
    {
        public int Id { get; set; }

        public int PlanId { get; set; }

        public int ZoomLevel { get; set; }

        public string Name { get; set; } //= null!; (nullable)

        public int X { get; set; }

        public int Y { get; set; }

        public virtual Plan Plan { get; set; } //= null!; (nullable)

        public virtual ICollection<Zone> Zones { get; set; } = new List<Zone>();
    }
}
