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

        private async void loadViewData()
        {
            using (var _context = new DataContext())
            {
                var teams = await _context.Tims.ToListAsync();
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
            if(dgClick == null)
            {
                MessageBox.Show("Please select the data first");
            }
            else
            {
                disableField();
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
                } else
                {
                    MessageBox.Show("Please select the data first");
                }
            }
        }
    }
}
