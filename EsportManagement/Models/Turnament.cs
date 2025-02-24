using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsportManagement.Models
{
    class Turnament
    {
        public int Id { get; set; }
        public string Judul {  get; set; }
        public DateTime Tgl_Mulai { get; set; }
        public DateTime? Tgl_Berakhir { get; set; }
        public Format FormatTurnamen { get; set; }
    }

    public enum Format 
    { 
        Liga, 
        Eliminasi, 
        Grup 
    }
}
