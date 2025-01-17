using System;
using System.Collections.Generic;

namespace v4._8_Sqlite_Tester.Models
{
    public partial class Location
    {
        public int Id { get; set; }

        public string Name { get; set; } //= null!; (nullable)

        public string Description { get; set; } //= null!; (nullable)

        public int SiteId { get; set; }

        public int? LocationIdParent { get; set; }

        public virtual ICollection<Location> InverseLocationIdParentNavigation { get; set; } = new List<Location>();

        public virtual Location LocationIdParentNavigation { get; set; } //= null!; (nullable)

        public virtual ICollection<Plan> Plans { get; set; } = new List<Plan>();

        public virtual Site Site { get; set; } //= null!; (nullable)
    }
}
