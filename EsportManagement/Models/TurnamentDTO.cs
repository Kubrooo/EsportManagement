using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsportManagement.Models
{
    class TurnamentDTO
    {
        public int Id { get; set; }
        public string Judul { get; set; }
        public DateTime Tgl_Mulai { get; set; }
        public DateTime? Tgl_Berakhir { get; set; }
        public string Format { get; set; }
    }
}
