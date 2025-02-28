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

        public DateTime Created_At { get; set; }
        public DateTime Updated_At { get; set; }
        public DateTime? Deleted_At { get; set; }
    }

    public enum Format 
    { 
        Liga, 
        Eliminasi, 
        Grup 
    }
}
