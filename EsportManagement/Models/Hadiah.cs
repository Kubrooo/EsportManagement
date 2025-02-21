using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsportManagement.Models
{
    class Hadiah
    {
        public int Id { get; set; }
        public int Sponsor_Id { get; set; }
        public enum Jenis_Hadiah { Uang, ItemInGame, Marchandise }
        public float Nilai { get; set; }
        public int Turnament_Id { get; set; }
        public int Tim_id {  get; set; }
    }
}
