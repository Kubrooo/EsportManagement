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
    public partial class MainForm : Form
    {
        ManageTeamForm manageTeamForm;
        ManagePlayerForm managePlayerForm;
        ManageTournamentForm manageTournamentForm;
        ManageMatchForm manageMatchForm;
        ManageSponsorForm manageSponsorForm;
        ManageRewardForm manageRewardForm;
        StatisticForm statisticForm;
        Form currentOpenForm;
        public MainForm()
        {
            InitializeComponent();
        }

        private void closeCurrentForm()
        {
            manageMatchForm = null;
            managePlayerForm = null;
            manageRewardForm = null;
            manageSponsorForm = null;
            manageTeamForm = null;
            manageTournamentForm = null;
            statisticForm = null;

            if (currentOpenForm != null)
            {
                currentOpenForm.Close();
            }
        }

        private void btnManageTeam_Click(object sender, EventArgs e)
        {
            if (manageTeamForm == null)
            {
                closeCurrentForm();
                manageTeamForm = new ManageTeamForm();
                manageTeamForm.MdiParent = this;
                manageTeamForm.Dock = DockStyle.Fill;
                manageTeamForm.Show();
                currentOpenForm = manageTeamForm;
            }
        }

        private void btnManagePlayer_Click(object sender, EventArgs e)
        {
            if (managePlayerForm == null) 
            {
                closeCurrentForm();
                managePlayerForm = new ManagePlayerForm();
                managePlayerForm.MdiParent = this;
                managePlayerForm.Dock = DockStyle.Fill;
                managePlayerForm.Show();
                currentOpenForm = managePlayerForm;
            }
        }

        private void btnManageTournament_Click(object sender, EventArgs e)
        {
            if (manageTournamentForm == null)
            {
                closeCurrentForm();
                manageTournamentForm = new ManageTournamentForm();
                manageTournamentForm.MdiParent = this;
                manageTournamentForm.Dock = DockStyle.Fill;
                manageTournamentForm.Show();
                currentOpenForm = manageTournamentForm;
            }
        }

        private void btnManageMatch_Click(object sender, EventArgs e)
        {
            if (manageMatchForm == null)
            {
                closeCurrentForm();
                manageMatchForm = new ManageMatchForm();
                manageMatchForm.MdiParent = this;
                manageMatchForm.Dock = DockStyle.Fill;
                manageMatchForm.Show();
                currentOpenForm = manageMatchForm;
            }
        }

        private void btnManageSponsor_Click(object sender, EventArgs e)
        {
            if(manageSponsorForm == null)
            {
                closeCurrentForm();
                manageSponsorForm = new ManageSponsorForm();
                manageSponsorForm.MdiParent = this;
                manageSponsorForm.Dock = DockStyle.Fill;
                manageSponsorForm.Show();
                currentOpenForm = manageSponsorForm;
            }
        }

        private void btnManageReward_Click(object sender, EventArgs e)
        {
            if (manageRewardForm == null)
            {
                closeCurrentForm();
                manageRewardForm = new ManageRewardForm();
                manageRewardForm.MdiParent = this;
                manageRewardForm.Dock = DockStyle.Fill;
                manageRewardForm.Show();
                currentOpenForm = manageRewardForm;
            }
        }

        private void btnStatistic_Click(object sender, EventArgs e)
        {
            if(statisticForm == null)
            {
                closeCurrentForm();
                statisticForm = new StatisticForm();
                statisticForm.MdiParent = this;
                statisticForm.Dock = DockStyle.Fill;
                statisticForm.Show();
                currentOpenForm = statisticForm;
            }
        }
    }
}
