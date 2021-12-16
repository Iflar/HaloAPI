using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaloAPI.Models.FactionModels
{
    public class FactionListItem
    {
        public int FactionId { get; set; }
        public string FactionName { get; set; }
        public string YearActive { get; set; }
        public string Motto { get; set; }
        public string Engagements { get; set; }
    }
}
