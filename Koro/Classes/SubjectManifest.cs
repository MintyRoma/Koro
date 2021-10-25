using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Koro.Classes
{
    class SubjectManifest
    {
        public bool Randomize { get; set; }
        public bool ShowRight { get; set; }
        public bool UseTimer { get; set; }
        public bool AllowRemake { get; set; }
        public bool LimitTasks { get; set; }
        public int Timer { get; set; }
        public int Tasks { get; set; }
        public string Name { get; set; }
    }
}
