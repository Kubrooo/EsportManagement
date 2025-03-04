using EsportManagement.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsportManagement.Forms
{
    public partial class ManageTeamForm : Form
    {
        private string operation;
        BindingSource bindingSource = new BindingSource();
        private string? dgClick;
        private int? selectedTeamId;
        public ManageTeamForm()
        {
            InitializeComponent();
        }

        private void ManageTeamForm_Load(object sender, EventArgs e)
        {
            loadViewData();
            disableField();
        }

        private async void loadViewData(string searchKeyword = "", string sortBy = "")
        {
            using (var _context = new DataContext())
            {
                var query = _context.Tims
                    .Select(t => new
                    {
                        t.Id,
                        t.Nama,
                        t.Negara,
                        t.Total_Poin,
                        TotalTurnamen = _context.Pertandingans.Count(p => p.Tim_Id1 == t.Id || p.Tim_Id2 == t.Id),
                        TotalMenang = _context.Pertandingans.Count(p => p.Pemenang_Id == t.Id),
                        TotalHadiahItem = _context.Hadiahs.Count(h => h.TimId == t.Id)
                    });

                // Filter berdasarkan nama tim
                if (!string.IsNullOrWhiteSpace(searchKeyword))
                {
                    query = query.Where(t => t.Nama.Contains(searchKeyword));
                }

                // Sorting berdasarkan pilihan user
                switch (sortBy)
                {
                    case "TotalTurnamen":
                        query = query.OrderByDescending(t => t.TotalTurnamen);
                        break;
                    case "TotalMenang":
                        query = query.OrderByDescending(t => t.TotalMenang);
                        break;
                    case "TotalHadiahItem":
                        query = query.OrderByDescending(t => t.TotalHadiahItem);
                        break;
                    default:
                        query = query.OrderBy(t => t.Nama);
                        break;
                }

                var teams = await query.ToListAsync();
                bindingSource.DataSource = teams;
                dgvTeam.DataSource = bindingSource;
            }
        }


        private void disableField()
        {
            tbTeam.Enabled = false;
            tbCountry.Enabled = false;
            numTotalPoint.Enabled = false;
            btnCancel.Enabled = false;
            btnSave.Enabled = false;
        }

        private void enableField()
        {
            tbTeam.Enabled = true;
            tbCountry.Enabled = true;
            numTotalPoint.Enabled = true;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
        }

        private void clearField()
        {
            tbTeam.Text = "";
            tbCountry.Text = "";
            numTotalPoint.Value = 0;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            clearField();
            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            enableField();

            operation = "Create";
        }

        private async void actionCreate()
        {
            using (var _context = new DataContext())
            {
                if (tbCountry.Text.Length <= 0 || tbTeam.Text.Length <= 0 || numTotalPoint.Value < 0)
                {
                    MessageBox.Show("Please fill all the input field");
                }
                else
                {
                    Tim newTeam = new Tim
                    {
                        Nama = tbTeam.Text,
                        Negara = tbCountry.Text,
                        Total_Poin = numTotalPoint.Value.ToString()
                    };

                    _context.Tims.Add(newTeam);
                    await _context.SaveChangesAsync();
                    loadViewData();
                    disableField();
                    clearField();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "Create":
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
            }
            else
            {
                btnAdd.Enabled = false;
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
                enableField();
                operation = "Edit";
            }
        }

        private async Task actionEdit()
        {
            using (var _context = new DataContext())
            {
                if (selectedTeamId != null)
                {
                    Tim editTargetTim = await _context.Tims.FindAsync(selectedTeamId);
                    if (editTargetTim != null)
                    {
                        editTargetTim.Nama = tbTeam.Text;
                        editTargetTim.Negara = tbCountry.Text;
                        editTargetTim.Total_Poin = numTotalPoint.Value.ToString();

                        _context.Tims.Update(editTargetTim);
                        await _context.SaveChangesAsync();
                        loadViewData();
                        dgvTeam.Refresh();
                        MessageBox.Show("Data has been updated");
                        clearField();
                        disableField();
                        btnAdd.Enabled = true;
                        btnEdit.Enabled = true;
                        btnDelete.Enabled = true;
                    }
                }
            }
        }

        private void dgvTeam_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow row = dgvTeam.Rows[index];
            var selectedTeam = (Tim)bindingSource.List[index];
            selectedTeamId = selectedTeam.Id;

            tbCountry.Text = selectedTeam.Negara;
            tbTeam.Text = selectedTeam.Nama;
            numTotalPoint.Value = Convert.ToDecimal(selectedTeam.Total_Poin);

            dgClick = "Clicked";
            disableField();
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgClick == null)
            {
                MessageBox.Show("Please select the data first");
            }
            else
            {
                disableField();
                btnAdd.Enabled = false;
                btnDelete.Enabled = false;
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
                btnCancel.Enabled = true;
                btnSave.Enabled = true;

                operation = "Delete";
            }
        }

        private async void actionDelete()
        {
            using (var _context = new DataContext())
            {
                if (selectedTeamId != null)
                {
                    var deleteTargetTeam = await _context.Tims.Where(e => e.Id == selectedTeamId).FirstOrDefaultAsync();

                    if (MessageBox.Show("Are you sure want to delete this data?", "Delete Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        _context.Tims.Remove(deleteTargetTeam);
                        await _context.SaveChangesAsync();
                        loadViewData();
                        clearField();
                        disableField();
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

        private async void showByNama()
        {
            string searchKeyword = tbSearch.Text;
            loadViewData(searchKeyword);
        }

        private async void showByTotalTurnamen()
        {
            loadViewData("", "TotalTurnamen");
        }

        private async void showByTotalMenang()
        {
            loadViewData("", "TotalMenang");
        }

        private async void showByTotalHadiahItem()
        {
            loadViewData("", "TotalHadiahItem");
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            showByNama();
        }

        private void cbSortOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbSortOptions.SelectedItem.ToString())
            {
                case "Total Turnamen":
                    showByTotalTurnamen();
                    break;
                case "Total Menang":
                    showByTotalMenang();
                    break;
                case "Total Hadiah Item":
                    showByTotalHadiahItem();
                    break;
            }
        }
    }
}
