using System;
using System.Collections.Generic;

namespace v4._8_Sqlite_Tester.Models
{
    public partial class Level
    {
        public int Id { get; set; }

        public int PlanId { get; set; }

        public int LevelNo { get; set; }

        public int Width { get; set; }

        public int Height { get; set; }

        public int Columns { get; set; }

        public int Rows { get; set; }

        public virtual Plan Plan { get; set; } //= null!;
    }
}
