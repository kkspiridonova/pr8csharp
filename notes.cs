using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practocsharp8
{
    internal class notes
    {
        public string title { get; set; }
        public string description { get; set; }
        public string date;

        public notes() { }
        public notes(string title, string description, string date)
        {
            this.title = title;
            this.description = description;
            this.date = date;
        }
    }
}
