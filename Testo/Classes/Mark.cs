using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;

namespace Testo.Classes
{
    public class Mark
    {
        private string id;

        public string ID => id;
        public string Name;
        public double Percentage;

        public Mark(string nam, double percentage)
        {
            Name = nam;
            Percentage = percentage;
        }

        public Mark(string id_value, string name_value, double percentage)
        {
            id = id_value;
            Name = name_value;
            Percentage = percentage;
        }
    }
}
