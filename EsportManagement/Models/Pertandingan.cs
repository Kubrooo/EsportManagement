using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsportManagement.Models
{
    class Pertandingan
    {
        public int Id { get; set; }

        [ForeignKey("Tim1")]
        public int Tim_Id1 { get; set; }
        public Tim Tim1 { get; set; }

        [ForeignKey("Tim2")]
        public int Tim_Id2 { get; set; }
        public Tim Tim2 { get; set; }

        [ForeignKey("Pemenang")]
        public int? Pemenang_Id { get; set; }
        public Tim? Pemenang { get; set; }

        [ForeignKey("Turnament")]
        public int Turnament_Id { get; set; }
        public Turnament Turnament { get; set; }

        public int Skor_Tim1 { get; set; }
        public int Skor_Tim2 { get; set; }
    }
}
