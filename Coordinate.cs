using System;
using System.Collections.Generic;

namespace v4._8_Sqlite_Tester.Models
{
    public partial class Coordinate
    {
        public int Id { get; set; }

        public int X { get; set; }

        public int Y { get; set; }

        public int HotspotId { get; set; }

        public virtual Hotspot Hotspot { get; set; } //= null!; (nullable)
    }
}
