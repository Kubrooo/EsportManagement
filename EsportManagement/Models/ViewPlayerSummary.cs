using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsportManagement.Models
{
    class ViewPlayerSummary
    {
        public string PlayerName { get; set; }
        public string RolePemain { get; set; }
        public int Kill { get; set; }
        public int Assist { get; set; }
        public int Death { get; set; }
        public string TeamName { get; set; }
    }
}
