using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsportManagement.Models
{
    class Hadiah
    {
        public int Id { get; set; }

        [ForeignKey("Sponsor")]
        public int SponsorId { get; set; }
        public Sponsor Sponsor { get; set; }

        public float Nilai { get; set; }

        [ForeignKey("Turnament")]
        public int TurnamentId { get; set; }
        public Turnament Turnament { get; set; }

        [ForeignKey("Tim")]
        public int TimId { get; set; }
        public Tim Tim { get; set; }
        public Jenis_Hadiah JenisHadiah { get; set; } 
    }

    public enum Jenis_Hadiah 
    { 
        Uang, 
        ItemInGame, 
        Marchandise 
    }
}
