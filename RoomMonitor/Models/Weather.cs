using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomMonitor.Models
{
    internal class Weather
    {
        public int id { get; set; }
        public DateTime Date { get; set; }
        public string DayOfWeek { get; set; }
        public string Outlook { get; set; }
        public float Temperature { get; set; }
    }
}
