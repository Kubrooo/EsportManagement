using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsportManagement.Models
{
    class Sponsor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Nilai_Hadiah { get; set; }

        [ForeignKey("Turnament")]
        public int TournamentId { get; set; }
        public Turnament Turnament { get; set; }
    }
}
