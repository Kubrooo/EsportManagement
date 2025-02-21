using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsportManagement.Models
{
    class Pertandingan
    {
        public int Id { get; set; }
        public int Tim_Id1 { get; set; }
        public int Tim_Id2 { get; set; }
        public int Pemenang_Id { get; set; } // Tournament Id
        public int Turnament_Id { get; set; }
        public int Skor_Tim1 { get; set; }
        public int Skor_Tim2 { get; set; }

        public Tim Tim { get; set; }
    }
}
