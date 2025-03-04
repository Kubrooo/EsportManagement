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
    public partial class ManageMatchForm : Form
    {
        BindingSource bindingSource = new BindingSource();
        private int selectedMatchId;
        private string operation, dgClick;
        public ManageMatchForm()
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
                var matchDetails = _context.ViewMatchDetails
                    .Select(m => new
                    {
                        m.MatchId,
                        m.FirstTeamName,
                        m.SecondTeamName,
                        m.WinnerTeamName,
                        m.TournamentTitle,
                        m.ScoreFirstTeam,
                        m.ScoreSecondTeam
                    })
                    .ToList();
                dgvMatch.DataSource = matchDetails;
            }
        }

        private void loadComboboxData()
        {
            using(var _context = new DataContext())
            {
                var dataTournament = _context.Tournaments.ToList();
                cbTournament.DataSource = dataTournament;
                cbTournament.DisplayMember = "Judul";
                cbTournament.ValueMember = "Id";

                var dataTeam1 = _context.Tims.ToList();
                cbFirstTeam.DataSource = dataTeam1;
                cbFirstTeam.DisplayMember = "Nama";
                cbFirstTeam.ValueMember = "Id";

                var dataTeam2 = _context.Tims.ToList();
                cbSecondTeam.DataSource = dataTeam2;
                cbSecondTeam.DisplayMember = "Nama";
                cbSecondTeam.ValueMember = "Id";

                var dataWinnerTeam = _context.Tims.ToList();
                cbWinnerTeam.DataSource = dataWinnerTeam;
                cbWinnerTeam.DisplayMember = "Nama";
                cbWinnerTeam.ValueMember = "Id";
            }
        }

        private void disableField()
        {
            cbFirstTeam.Enabled = false;
            cbSecondTeam.Enabled = false;
            cbWinnerTeam.Enabled = false;
            numFirstTeamScore.Enabled = false;
            numSecondTeamScore.Enabled = false;
            cbTournament.Enabled = false;
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
        }

        private void enableField()
        {
            cbFirstTeam.Enabled = true;
            cbSecondTeam.Enabled = true;
            cbWinnerTeam.Enabled = true;
            numFirstTeamScore.Enabled = true;
            numSecondTeamScore.Enabled = true;
            cbTournament.Enabled = true;
            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
        }

        private void clearField()
        {
            cbFirstTeam.Text = "";
            cbSecondTeam.Text = "";
            cbWinnerTeam.Text = "";
            cbTournament.Text = "";
            numFirstTeamScore.Value = 0;
            numSecondTeamScore.Value = 0;
        }

        private void dgvMatch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgvMatch.Rows.Count == 0) return;

            int index = e.RowIndex;
            var row = dgvMatch.Rows[index];

            dynamic selectedMatch = row.DataBoundItem; // Pakai dynamic agar tidak perlu casting

            selectedMatchId = selectedMatch.MatchId;
            cbFirstTeam.Text = selectedMatch.FirstTeamName;
            cbSecondTeam.Text = selectedMatch.SecondTeamName;
            cbWinnerTeam.Text = selectedMatch.WinnerTeamName;
            cbTournament.Text = selectedMatch.TournamentTitle;
            numFirstTeamScore.Value = selectedMatch.ScoreFirstTeam;
            numSecondTeamScore.Value = selectedMatch.ScoreSecondTeam;

            dgClick = "clicked";
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
                var match = new Pertandingan
                {
                    Tim_Id1 = (int)cbFirstTeam.SelectedValue,
                    Tim_Id2 = (int)cbSecondTeam.SelectedValue,
                    Pemenang_Id = (int)cbWinnerTeam.SelectedValue,
                    Turnament_Id = (int)cbTournament.SelectedValue,
                    Skor_Tim1 = (int)numFirstTeamScore.Value,
                    Skor_Tim2 = (int)numSecondTeamScore.Value
                };

                _context.Pertandingans.Add(match);

                var firstTeam = _context.Tims.FirstOrDefault(t => t.Id == match.Tim_Id1);
                var secondTeam = _context.Tims.FirstOrDefault(t => t.Id == match.Tim_Id2);

                if (firstTeam != null)
                {
                    firstTeam.Total_Poin = (int.Parse(firstTeam.Total_Poin) + match.Skor_Tim1).ToString();
                }

                if (secondTeam != null)
                {
                    secondTeam.Total_Poin = (int.Parse(secondTeam.Total_Poin) + match.Skor_Tim2).ToString();
                }

                await _context.SaveChangesAsync();
                loadViewData();
                disableField();
            }
        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(dgClick == null)
            {
                MessageBox.Show("Please select a match first");
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
            using(var _context = new DataContext())
            {
                var match = _context.Pertandingans.FirstOrDefault(m => m.Id == selectedMatchId);
                match.Tim_Id1 = (int)cbFirstTeam.SelectedValue;
                match.Tim_Id2 = (int)cbSecondTeam.SelectedValue;
                match.Pemenang_Id = (int)cbWinnerTeam.SelectedValue;
                match.Turnament_Id = (int)cbTournament.SelectedValue;
                match.Skor_Tim1 = (int)numFirstTeamScore.Value;
                match.Skor_Tim2 = (int)numSecondTeamScore.Value;
                await _context.SaveChangesAsync();
                loadViewData();
                disableField();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgClick == null)
            {
                MessageBox.Show("Please select a match first");
                return;
            }
            else
            {
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
                var match = _context.Pertandingans.FirstOrDefault(m => m.Id == selectedMatchId);
                _context.Pertandingans.Remove(match);
                await _context.SaveChangesAsync();
                loadViewData();
                disableField();
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
            disableField();
            clearField();   
        }
    }
}
