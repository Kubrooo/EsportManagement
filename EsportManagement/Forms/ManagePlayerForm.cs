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
        private string operation;
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
                var data = await _context.ViewPlayerSummaries.ToListAsync();
                bindingSource.DataSource = data;
                dgvPlayer.DataSource = bindingSource;
            }
        }

        private async void loadComboBoxData()
        {
            using (var _context = new DataContext())
            {
                cbTeam.DataSource = await _context.Tims.ToListAsync();
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
    }
}
