using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaloAPI.Models.FactionModels
{
    public class FactionCreate
    {
        public string FactionName { get; set; }

        public string Motto { get; set; }

        public int YearActive { get; set;}

        public string Engagements { get; set; }


    }
}
