using System;
using System.Collections.Generic;
using v4._8_Sqlite_Tester.Models;

namespace Sqlite_EF_Tester.Models
{
    public partial class Zone
    {
        public int Id { get; set; }

        public int ZoneNo { get; set; }

        public int SiteId { get; set; }

        public string Name { get; set; } //= null!; (nullable)

        public int? LinkViewId { get; set; }

        public virtual View LinkView { get; set; } //= null!; (nullable)

        public virtual Site Site { get; set; } //= null!; (nullable)
    }
}
