using EsportManagement.Models;
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
    public partial class ManageTournamentForm : Form
    {
        BindingSource bindingSource = new BindingSource();
        private int selectedTournamentId;
        private string operation, dgClick;
        public ManageTournamentForm()
        {
            InitializeComponent();
            loadTournament();
            disableField();
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



        private void disableField()
        {
            tbTournamentTitle.Enabled = false;
            dtEndDate.Enabled = false;
            dtStartDate.Enabled = false;
            cbFormatTournament.Enabled = false;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
        }
        private void enableField()
        {
            tbTournamentTitle.Enabled = true;
            dtEndDate.Enabled = true;
            dtStartDate.Enabled = true;
            cbFormatTournament.Enabled = true;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void clearField()
        {
            tbTournamentTitle.Text = "";
            dtEndDate.Value = DateTime.Now;
            dtStartDate.Value = DateTime.Now;
            cbFormatTournament.SelectedIndex = -1;
        }

        private void dgvTournament_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var selectedTournament = (TurnamentDTO)bindingSource[e.RowIndex]; // ✅ Bisa di-cast

            selectedTournamentId = selectedTournament.Id;
            tbTournamentTitle.Text = selectedTournament.Judul;
            dtStartDate.Value = selectedTournament.Tgl_Mulai;
            dtEndDate.Value = selectedTournament.Tgl_Berakhir ?? DateTime.Now;
            cbFormatTournament.SelectedItem = selectedTournament.Format;

            dgClick = "Clicked";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            enableField();
            operation = "Add";
        }

        private async void actionAdd()
        {
            using (var _context = new DataContext())
            {
                if (Enum.TryParse<Format>(cbFormatTournament.SelectedItem.ToString(), out var format))
                {
                    var tournament = new Turnament
                    {
                        Judul = tbTournamentTitle.Text,
                        Tgl_Mulai = dtStartDate.Value,
                        Tgl_Berakhir = dtEndDate.Value,
                        FormatTurnamen = format,
                        Created_At = DateTime.Now,
                        Updated_At = DateTime.Now
                    };
                    _context.Tournaments.Add(tournament);
                    await _context.SaveChangesAsync();
                    loadTournament();
                    MessageBox.Show("Tournament added successfully");
                    disableField();
                    clearField();
                    btnAdd.Enabled = true;
                    btnEdit.Enabled = true;
                    btnDelete.Enabled = true;
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgClick == null)
            {
                MessageBox.Show("Please select a tournament first");
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
                var tournament = _context.Tournaments.Where(t => t.Id == selectedTournamentId).FirstOrDefault();
                if (Enum.TryParse<Format>(cbFormatTournament.SelectedItem.ToString(), out var format))
                {
                    tournament.Judul = tbTournamentTitle.Text;
                    tournament.Tgl_Mulai = dtStartDate.Value;
                    tournament.Tgl_Berakhir = dtEndDate.Value;
                    tournament.FormatTurnamen = format;
                    tournament.Updated_At = DateTime.Now;
                    await _context.SaveChangesAsync();
                    loadTournament();
                    MessageBox.Show("Tournament updated successfully");
                    disableField();
                    btnAdd.Enabled = true;
                    btnEdit.Enabled = true;
                    btnDelete.Enabled = true;
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgClick == null)
            {
                MessageBox.Show("Please select a tournament first");
                return;
            }
            else
            {
                operation = "Delete";
                btnSave.Enabled = true;
                btnCancel.Enabled = true;
                btnDelete.Enabled = false;
                btnEdit.Enabled = false;
                btnAdd.Enabled = false;
            }
        }

        private async void actionDelete()
        {
            using (var _context = new DataContext())
            {
                var targetDeleteTournament = _context.Tournaments
                    .Where(t => t.Id == selectedTournamentId && t.Deleted_At == null)
                    .FirstOrDefault();

                if (targetDeleteTournament == null)
                {
                    MessageBox.Show("Tournament not found or already deleted");
                    return;
                }

                if (MessageBox.Show("Are you sure you want to delete this tournament?",
                    "Delete Tournament", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    targetDeleteTournament.Deleted_At = DateTime.Now;
                    await _context.SaveChangesAsync();
                    MessageBox.Show("Tournament deleted successfully");

                    loadTournament(); // Hanya tampilkan yang belum dihapus
                    disableField();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "Add":
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
            clearField();
            disableField();
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;

        }

        private void btnShowDeleted_Click(object sender, EventArgs e)
        {
            loadTournament(true);
        }

        private async void btnRestoreDeleted_Click(object sender, EventArgs e)
        {
            if (dgClick == null)
            {
                MessageBox.Show("Please select a tournament first");
                return;
            }

            using (var _context = new DataContext())
            {
                var tournament = _context.Tournaments
                    .Where(t => t.Id == selectedTournamentId)
                    .FirstOrDefault();

                if (tournament != null)
                {
                    tournament.Deleted_At = null;
                    await _context.SaveChangesAsync();
                    MessageBox.Show("Tournament restored successfully");

                    loadTournament(false); // Kembali ke daftar yang aktif setelah restore
                }
            }
        }
    }
}
