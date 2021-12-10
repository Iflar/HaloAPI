using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaloAPI.Models.FactionModels
{
    public class FactionDetail
    {
        public int Id { get; set; }
        public string FactionName { get; set; }
        public int YearActive { get; set; }
        public string Motto { get; set; }
        public string Engagements { get; set; }
    }
}
