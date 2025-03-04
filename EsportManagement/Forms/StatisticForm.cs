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
        }

        private void LoadStatistics()
        {
            // Ambil semua turnamen
            var turnamenList = _context.Tournaments
                .Select(t => new
                {
                    t.Judul,
                    Status = t.Tgl_Berakhir.HasValue ? "Selesai" : "Belum Selesai",
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

            // Buat DataTable untuk di-bind ke DataGridView
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
    }
}
