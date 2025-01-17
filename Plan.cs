using System;
using System.Collections.Generic;

namespace v4._8_Sqlite_Tester.Models
{
    public partial class Plan
    {
        public int Id { get; set; }

        public string Name { get; set; } //= null!; (nullable)

        public int ImageFolderId { get; set; }

        public int? LinkViewId { get; set; }

        public int ZoomLevelPreferred { get; set; }

        public int LocationId { get; set; }

        public virtual ICollection<Hotspot> Hotspots { get; set; } = new List<Hotspot>();

        public virtual ICollection<Level> Levels { get; set; } = new List<Level>();

        public virtual Location Location { get; set; } //= null!; (nullable)

        public virtual ICollection<View> Views { get; set; } = new List<View>();
    }
}
