using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdatElérés.Osztályok
{
    public class DolgozóSzedései
    {
        public Int64 DolgozóId { get; set; }
        public string DolgozóNév { get; set; }
        public DateTime MérésIdeje { get; set; }
        public string MérésHelye { get; set; }
        public int MérésDbSzám { get; set; }
        public decimal ÖszMértLádaTömeg { get; set; }
    }
}
