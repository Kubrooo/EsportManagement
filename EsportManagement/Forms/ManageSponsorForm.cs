using EsportManagement.Models;
using Microsoft.CSharp.RuntimeBinder;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsportManagement.Forms
{
    public partial class ManageSponsorForm : Form
    {
        BindingSource bindingSource = new BindingSource();
        private string selectedSponsorName, dgClick, operation;
        public ManageSponsorForm()
        {
            InitializeComponent();
            loadSponsorData();
            loadComboBoxData();
            disableField();
        }

        private void loadSponsorData()
        {
            using (var _context = new DataContext())
            {
                var dataSponsor = _context.ViewSponsorTournaments
                    .Select(s => new
                    {
                        s.Nama_Sponsor,
                        s.Nilai_Hadiah,
                        s.Nama_Tournament
                    })
                    .ToList();
                dgvSponsors.DataSource = dataSponsor;
            }
        }

        private void loadComboBoxData()
        {
            using (var _context = new DataContext())
            {
                var dataTournament = _context.Tournaments.ToList();
                cbTournament.DataSource = dataTournament;
                cbTournament.DisplayMember = "Judul";
                cbTournament.ValueMember = "Id";
            }
        }

        private void disableField()
        {
            tbSponsorName.Enabled = false;
            numNilaiHadiah.Enabled = false;
            cbTournament.Enabled = false;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void enableField()
        {
            tbSponsorName.Enabled = true;
            numNilaiHadiah.Enabled = true;
            cbTournament.Enabled = true;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void clearField()
        {
            tbSponsorName.Text = "";
            cbTournament.Text = "";
            numNilaiHadiah.Value = 0;
        }

        private void loadTournament(bool showDeleted = false)
        {
            using (var _context = new DataContext())
            {
                dgvTournament.DataSource = null; // Reset data biar gak nyangkut

                var tournaments = _context.Tournaments
                    .Where(t => showDeleted ? t.Deleted_At != null : t.Deleted_At == null) // Filter sesuai kondisi
                    .Select(t => new TurnamentDTO
                    {
                        Id = t.Id,
                        Judul = t.Judul,
                        Tgl_Mulai = t.Tgl_Mulai,
                        Tgl_Berakhir = t.Tgl_Berakhir,
                        Format = t.FormatTurnamen.ToString()
                    })
                    .ToList();

                bindingSource.DataSource = tournaments;
                dgvTournament.DataSource = bindingSource; // Refresh data
            }
        }

        private void dgvSponsors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgvSponsors.Rows.Count == 0) return;

            int index = e.RowIndex;
            var row = dgvSponsors.Rows[index];

            dynamic selectedSponsor = row.DataBoundItem; // Pakai dynamic agar fleksibel
            selectedSponsorName = selectedSponsor.Nama_Sponsor;

            try
            {
                tbSponsorName.Text = selectedSponsor.Nama_Sponsor;
                numNilaiHadiah.Value = (decimal)selectedSponsor.Nilai_Hadiah;
                cbTournament.Text = selectedSponsor.Nama_Tournament;
            }
            catch (RuntimeBinderException ex)
            {
                MessageBox.Show("❌ Error: Properti tidak ditemukan dalam data.\n" + ex.Message);
            }

            dgClick = "Clicked";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            enableField();
            operation = "add";
        }

        private async void actionAdd()
        {
            using (var _context = new DataContext())
            {
                var sponsor = new Sponsor
                {
                    Name = tbSponsorName.Text,
                    Nilai_Hadiah = (float)numNilaiHadiah.Value,
                    TournamentId = (int)cbTournament.SelectedValue

                };
                _context.Sponsors.Add(sponsor);
                await _context.SaveChangesAsync();
                loadSponsorData();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(dgClick == null)
            {
                MessageBox.Show("Please the data first");
                return;
            }
            else
            {
                enableField();
                operation = "Edit";
            }
        }

        private async void actionEdit()
        {
            using (var _context = new DataContext())
            {
                var selectedSponsorEdit = _context.Sponsors.FirstOrDefault(s => s.Name == selectedSponsorName);

                if (selectedSponsorEdit == null)
                {
                    MessageBox.Show("❌ Sponsor tidak ditemukan! Pastikan nama sponsor sudah benar.");
                    return;
                }

                selectedSponsorEdit.Name = tbSponsorName.Text;
                selectedSponsorEdit.Nilai_Hadiah = (float)numNilaiHadiah.Value;
                selectedSponsorEdit.TournamentId = (int)cbTournament.SelectedValue;

                await _context.SaveChangesAsync();
                loadSponsorData();
                disableField();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(dgClick == null)
            {
                MessageBox.Show("Please select the data first"); return;
            }
            else
            {
                btnSave.Enabled = true;
                btnCancel.Enabled = true;
                btnDelete.Enabled = false;
                btnAdd.Enabled = false;
                btnEdit.Enabled = false;
            }

            operation = "Delete";
        }

        private async void actionDelete()
        {
            using (var _context = new DataContext()) 
            {
                var sponsor = _context.Sponsors.FirstOrDefault(s => s.Name == selectedSponsorName);
                _context.Sponsors.Remove(sponsor);
                await _context.SaveChangesAsync();
                loadSponsorData();
                disableField();
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            switch (operation) 
            {
                case "add":
                    actionAdd();
                    break;
                case "Edit":
                    actionEdit(); 
                    break;
                case "Delete":
                    actionDelete(); 
                    break;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            disableField();
            clearField();
        }
    }
}
