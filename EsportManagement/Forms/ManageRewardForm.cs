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
    public partial class ManageRewardForm : Form
    {
        BindingSource bindingSource = new BindingSource();
        private string operation, dgClick, selectedRewardName;
        public ManageRewardForm()
        {
            InitializeComponent();
            loadViewData();
            loadComboboxData();
            disableField();
        }

        private void loadViewData()
        {
            using (var _context = new DataContext())
            {
                var rewardDetails = _context.ViewHadiahDetails
                .Select(r => new
                {

                    r.Nama_Sponsor,
                    Nilai_Hadiah = r.Nilai_Hadiah,
                    r.Nama_Turnamen,
                    r.Nama_Tim_Penerima,
                    Jenis_Hadiah = ((Jenis_Hadiah)r.Jenis_Hadiah).ToString()
                })
                .ToList();

                dgvRewards.DataSource = rewardDetails;
            }
        }

        private void loadComboboxData()
        {
            using (var _context = new DataContext())
            {
                var dataSponsor = _context.Sponsors.ToList();
                cbSponsorName.DataSource = dataSponsor;
                cbSponsorName.DisplayMember = "Name";
                cbSponsorName.ValueMember = "Id";

                var dataTournament = _context.Tournaments.ToList();
                cbNamaTournament.DataSource = dataTournament;
                cbNamaTournament.DisplayMember = "Judul";
                cbNamaTournament.ValueMember = "Id";

                var dataTeam = _context.Tims.ToList();
                cbNamaTeamPenerima.DataSource = dataTeam;
                cbNamaTeamPenerima.DisplayMember = "Nama";
                cbNamaTeamPenerima.ValueMember = "Id";
            }
        }

        private void disableField()
        {
            numNilaiHadiah.Enabled = false;
            cbJenisHadiah.Enabled = false;
            cbNamaTeamPenerima.Enabled = false;
            cbNamaTournament.Enabled = false;
            cbSponsorName.Enabled = false;
            btnAdd.Enabled = true;
            btnDelete.Enabled = true;
            btnEdit.Enabled = true;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
        }

        private void enableField()
        {
            numNilaiHadiah.Enabled = true;
            cbJenisHadiah.Enabled = true;
            cbNamaTeamPenerima.Enabled = true;
            cbNamaTournament.Enabled = true;
            cbSponsorName.Enabled = true;
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
        }

        private void dgvRewards_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow row = dgvRewards.Rows[index];
            dynamic selectedReward = row.DataBoundItem;
            selectedRewardName = selectedReward.Nama_Sponsor;

            if (index < 0 || dgvRewards.Rows.Count == 0) return;
            cbSponsorName.Text = selectedReward.Nama_Sponsor;
            numNilaiHadiah.Value = (decimal)(float)selectedReward.Nilai_Hadiah;
            cbNamaTournament.Text = selectedReward.Nama_Turnamen;
            cbNamaTeamPenerima.Text = selectedReward.Nama_Tim_Penerima;
            cbJenisHadiah.Text = selectedReward.Jenis_Hadiah.ToString();

            dgClick = "clicked";
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
                Hadiah reward = new Hadiah
                {
                    Nilai = (float)numNilaiHadiah.Value,
                    JenisHadiah = (Jenis_Hadiah)Enum.Parse(typeof(Jenis_Hadiah), cbJenisHadiah.Text),
                    TimId = (int)cbNamaTeamPenerima.SelectedValue,
                    TurnamentId = (int)cbNamaTournament.SelectedValue,
                    SponsorId = (int)cbSponsorName.SelectedValue
                };
                _context.Hadiahs.Add(reward);
                await _context.SaveChangesAsync();
                loadViewData();
                disableField();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgClick == null)
            {
                MessageBox.Show("Pilih data terlebih dahulu");
                return;
            }
            else
            {
                enableField();
                operation = "edit";
            }
        }

        private async void actionEdit()
        {
            using (var _context = new DataContext())
            {
                var reward = _context.Hadiahs.FirstOrDefault(r => r.Sponsor.Name == selectedRewardName);
                reward.Nilai = (float)numNilaiHadiah.Value;
                reward.JenisHadiah = (Jenis_Hadiah)Enum.Parse(typeof(Jenis_Hadiah), cbJenisHadiah.Text);
                reward.TimId = (int)cbNamaTeamPenerima.SelectedValue;
                reward.TurnamentId = (int)cbNamaTournament.SelectedValue;
                reward.SponsorId = (int)cbSponsorName.SelectedValue;
                await _context.SaveChangesAsync();
                loadViewData();
                disableField();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(dgClick == null)
            {
                MessageBox.Show("Pilih data terlebih dahulu");
                return;
            }
            else
            {
                btnAdd.Enabled = false;
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
                btnSave.Enabled = true;
                btnCancel.Enabled = true;
                operation = "delete";
            }
        }

        private async void actionDelete()
        {
            using (var _context = new DataContext())
            {
                var reward = _context.Hadiahs.FirstOrDefault(r => r.Sponsor.Name == selectedRewardName);
                _context.Hadiahs.Remove(reward);
                await _context.SaveChangesAsync();
                loadViewData();
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
                case "edit":
                    actionEdit();
                    break;
                case "delete":
                    actionDelete();
                    break;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
