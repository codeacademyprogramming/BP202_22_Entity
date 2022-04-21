using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityApp.Data.Entites
{
    internal class Group
    {
        public int Id { get; set; }
        public string No { get; set; }
        public byte StudentLimit { get; set; }
        public DateTime StartDate { get; set; }
        public int LimitPoint { get; set; }

    }
}
