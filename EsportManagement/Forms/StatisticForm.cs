using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace EsportManagement.Forms
{
    public partial class StatisticForm: Form
    {
        private readonly DataContext _context;
        public StatisticForm()
        {
            InitializeComponent();
            _context = new DataContext();
            LoadStatistics();
            LoadTeamStatistics();
        }

        private void LoadStatistics()
        {
            DateTime today = DateTime.Now.Date;

            var turnamenList = _context.Tournaments
                .Select(t => new
                {
                    t.Judul,
                    Status = today < t.Tgl_Mulai ? "Belum Dimulai" :
                             (t.Tgl_Berakhir.HasValue && today > t.Tgl_Berakhir) ? "Selesai" :
                             "Sedang Berlangsung",
                    TotalTim = _context.Pertandingans.Count(p => p.Turnament_Id == t.Id) * 2,
                    Pemenang = _context.Pertandingans
                        .Where(p => p.Turnament_Id == t.Id && p.Pemenang_Id != null)
                        .Select(p => p.Pemenang.Nama)
                        .Distinct()
                        .ToList(),
                    TotalHadiah = _context.Hadiahs
                        .Where(h => h.TurnamentId == t.Id)
                        .Sum(h => h.Nilai)
                }).ToList();

            DataTable dt = new DataTable();
            dt.Columns.Add("Judul Turnamen");
            dt.Columns.Add("Status");
            dt.Columns.Add("Total Tim Berpartisipasi");
            dt.Columns.Add("Pemenang");
            dt.Columns.Add("Total Hadiah");

            foreach (var turnamen in turnamenList)
            {
                dt.Rows.Add(
                    turnamen.Judul,
                    turnamen.Status,
                    turnamen.TotalTim,
                    string.Join(", ", turnamen.Pemenang),
                    turnamen.TotalHadiah
                );
            }

            dataGridViewStatistics.DataSource = dt;
        }


        private void LoadTeamStatistics()
        {
            var teamList = _context.Tims
                .Select(t => new
                {
                    t.Nama,
                    TotalTurnamen = _context.Pertandingans
                        .Count(p => p.Tim_Id1 == t.Id || p.Tim_Id2 == t.Id),
                    Menang = _context.Pertandingans.Count(p => p.Pemenang_Id == t.Id),
                    Kalah = _context.Pertandingans
                        .Count(p => (p.Tim_Id1 == t.Id || p.Tim_Id2 == t.Id) && p.Pemenang_Id != t.Id),
                    t.Total_Poin
                })
                .OrderByDescending(t => t.Total_Poin)
                .ToList();

            DataTable dt = new DataTable();
            dt.Columns.Add("Nama Tim");
            dt.Columns.Add("Turnamen Diikuti");
            dt.Columns.Add("Menang");
            dt.Columns.Add("Kalah");
            dt.Columns.Add("Total Poin");

            foreach (var team in teamList)
            {
                dt.Rows.Add(
                    team.Nama,
                    team.TotalTurnamen,
                    team.Menang,
                    team.Kalah,
                    team.Total_Poin
                );
            }

            dataGridViewTeamStats.DataSource = dt;
        }
    }
}

