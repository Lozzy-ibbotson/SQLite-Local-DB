using System;
using System.Collections.Generic;

namespace v4._8_Sqlite_Tester.Models
{
    public partial class LinkZone
    {
        public int Id { get; set; }

        public int HotspotId { get; set; }

        public int ZoneNo { get; set; }

        public virtual Hotspot Hotspot { get; set; } //= null!; (nullable)
    }
}
