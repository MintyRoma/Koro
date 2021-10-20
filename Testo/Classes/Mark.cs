using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;

namespace Testo.Classes
{
    public class Mark
    {
        public string Name;
        public double Percentage;

        public Mark(string nam, double percentage)
        {
            Name = nam;
            Percentage = percentage;
        }
        public Mark()
        {
            Name = "";
            Percentage = 1;
        }
    }
}
