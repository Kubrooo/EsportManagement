using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsportManagement.Models
{
    class Pemain
    {
        public int Id { get; set; }
        public string Nama {  get; set; }
        public Role RolePemain { get; set; }
        public int Kill { get; set; }
        public int Assist { get; set; }
        public int Death { get; set; }

        [ForeignKey("Tim")]
        public int Tim_Id {  get; set; }    
        public Tim Tim { get; set; }
    }

        public enum Role
        {
            Tank,
            Support,
            DPS,
            Sniper,
            Assassin
        } 
}   

