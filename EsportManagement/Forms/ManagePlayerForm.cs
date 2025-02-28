using EsportManagement.Models;
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
    public partial class ManagePlayerForm : Form
    {
        BindingSource bindingSource = new BindingSource();
        private string operation, selectedPlayerName, dgClick;
        public ManagePlayerForm()
        {
            InitializeComponent();
        }

        private void ManagePlayerForm_Load(object sender, EventArgs e)
        {
            loadViewData();
            loadComboBoxData();
            disableField();
        }

        private async void loadViewData()
        {
            using (var _context = new DataContext())
            {
                var data = await _context.Pemains
                    .Include(p => p.Tim)
                    .Select(p => new ViewPlayerSummary
                    {
                        PlayerName = p.Nama,
                        RolePemain = p.RolePemain.ToString(),
                        Kill = p.Kill,
                        Assist = p.Assist,
                        Death = p.Death,
                        TeamName = p.Tim.Nama
                    })
                    .ToListAsync();

                bindingSource.DataSource = data;
                dgvPlayer.DataSource = bindingSource;
            }
        }


        private void loadComboBoxData()
        {
            using (var _context = new DataContext())
            {
                var teams = _context.Tims.Select(t => new { t.Id, t.Nama }).ToList();
                cbTeam.DataSource = teams;
                cbTeam.DisplayMember = "Nama";
                cbTeam.ValueMember = "Id";
            }
        }

        private void disableField()
        {
            tbPlayerName.Enabled = false;
            cbRole.Enabled = false;
            numKill.Enabled = false;
            numAssist.Enabled = false;
            numDeath.Enabled = false;
            cbTeam.Enabled = false;
            btnCancel.Enabled = false;
            btnSave.Enabled = false;
        }

        private void enableField()
        {
            tbPlayerName.Enabled = true;
            cbRole.Enabled = true;
            numKill.Enabled = true;
            numAssist.Enabled = true;
            numDeath.Enabled = true;
            cbTeam.Enabled = true;
            btnCancel.Enabled = true;
            btnSave.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            enableField();
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;

            operation = "Add";
        }

        private async void actionCreate()
        {
            using (var _context = new DataContext())
            {
                if (Enum.TryParse<Role>(cbRole.Text, out Role role))
                {
                    // Debugging
                    if (cbTeam.SelectedValue == null)
                    {
                        MessageBox.Show("Pilih tim terlebih dahulu.");
                        return;
                    }

                    int selectedTeamId;
                    if (!int.TryParse(cbTeam.SelectedValue.ToString(), out selectedTeamId))
                    {
                        MessageBox.Show("Error: ID Tim tidak valid.");
                        return;
                    }

                    // Pastikan tim benar-benar ada di database
                    var existingTeam = await _context.Tims.FindAsync(selectedTeamId);
                    if (existingTeam == null)
                    {
                        MessageBox.Show("Error: Tim yang dipilih tidak ditemukan di database.");
                        return;
                    }

                    Pemain pemain = new Pemain
                    {
                        Nama = tbPlayerName.Text,
                        RolePemain = role,
                        Kill = (int)numKill.Value,
                        Assist = (int)numAssist.Value,
                        Death = (int)numDeath.Value,
                        Tim_Id = selectedTeamId
                    };

                    _context.Pemains.Add(pemain);
                    await _context.SaveChangesAsync();
                    loadViewData();
                    MessageBox.Show("Pemain berhasil ditambahkan!");
                }
                else
                {
                    MessageBox.Show("Role yang dipilih tidak valid.");
                }
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "Add":
                    actionCreate();
                    break;
                case "Edit":
                    actionEdit();
                    break;
                case "Delete":
                    actionDelete();
                    break;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgClick == null)
            {
                MessageBox.Show("Please select the data first");
                return;
            }
            else
            {
                enableField();
                btnAdd.Enabled = false;
                btnDelete.Enabled = false;
                btnEdit.Enabled = false;
                operation = "Edit";

            }
        }

        private async void actionEdit()
        {
            using (var _context = new DataContext())
            {
                if (Enum.TryParse<Role>(cbRole.Text, out Role role))
                {
                    // Debugging
                    if (cbTeam.SelectedValue == null)
                    {
                        MessageBox.Show("Pilih tim terlebih dahulu.");
                        return;
                    }
                    int selectedTeamId;
                    if (!int.TryParse(cbTeam.SelectedValue.ToString(), out selectedTeamId))
                    {
                        MessageBox.Show("Error: ID Tim tidak valid.");
                        return;
                    }
                    // Pastikan tim benar-benar ada di database
                    var existingTeam = await _context.Tims.FindAsync(selectedTeamId);
                    if (existingTeam == null)
                    {
                        MessageBox.Show("Error: Tim yang dipilih tidak ditemukan di database.");
                        return;
                    }
                    var pemain = await _context.Pemains.Where(p => p.Nama == selectedPlayerName).FirstOrDefaultAsync();
                    pemain.Nama = tbPlayerName.Text;
                    pemain.RolePemain = role;
                    pemain.Kill = (int)numKill.Value;
                    pemain.Assist = (int)numAssist.Value;
                    pemain.Death = (int)numDeath.Value;
                    pemain.Tim_Id = selectedTeamId;
                    _context.Pemains.Update(pemain);
                    await _context.SaveChangesAsync();
                    loadViewData();
                    MessageBox.Show("Pemain berhasil diubah!");
                }
                else
                {
                    MessageBox.Show("Role yang dipilih tidak valid.");
                }
            }
        }

        private void dgvPlayer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow row = dgvPlayer.Rows[index];
            var selectedPlayer = (ViewPlayerSummary)bindingSource.List[index];
            selectedPlayerName = selectedPlayer.PlayerName;

            tbPlayerName.Text = selectedPlayer.PlayerName;
            cbRole.Text = selectedPlayer.RolePemain;
            numKill.Value = selectedPlayer.Kill;
            numAssist.Value = selectedPlayer.Assist;
            numDeath.Value = selectedPlayer.Death;
            cbTeam.Text = selectedPlayer.TeamName;

            dgClick = "Clicked";
            disableField();
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(dgClick == null)
            {
                MessageBox.Show("Please select the data first");
                return;
            }
            else
            {
                disableField();
                btnAdd.Enabled = false;
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
                btnSave.Enabled = true;
                btnCancel.Enabled = true;
                operation = "Delete";
            }
        }

        private async void actionDelete()
        {
            using(var _context = new DataContext())
            {
                if(selectedPlayerName != null)
                {
                   var deleteTargetPemain = await _context.Pemains.Where(p => p.Nama == selectedPlayerName).FirstOrDefaultAsync();
                   
                   if(MessageBox.Show($"Are you sure you want to delete {deleteTargetPemain.Nama}?", "Delete Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        _context.Pemains.Remove(deleteTargetPemain);
                        await _context.SaveChangesAsync();
                        loadViewData();
                        disableField();
                        MessageBox.Show("Data has been deleted");
                        btnAdd.Enabled = true;
                        btnEdit.Enabled = true;
                        btnDelete.Enabled = true;
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Please select the data first");
                }
            }
        }
    }
}
