namespace EsportManagement.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnManageTeam = new Button();
            btnManagePlayer = new Button();
            btnManageTournament = new Button();
            btnManageMatch = new Button();
            btnManageSponsor = new Button();
            btnManageReward = new Button();
            btnStatistic = new Button();
            panel1 = new Panel();
            label1 = new Label();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnManageTeam);
            flowLayoutPanel1.Controls.Add(btnManagePlayer);
            flowLayoutPanel1.Controls.Add(btnManageTournament);
            flowLayoutPanel1.Controls.Add(btnManageMatch);
            flowLayoutPanel1.Controls.Add(btnManageSponsor);
            flowLayoutPanel1.Controls.Add(btnManageReward);
            flowLayoutPanel1.Controls.Add(btnStatistic);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(250, 670);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // btnManageTeam
            // 
            btnManageTeam.Location = new Point(3, 3);
            btnManageTeam.Name = "btnManageTeam";
            btnManageTeam.Size = new Size(241, 29);
            btnManageTeam.TabIndex = 0;
            btnManageTeam.Text = "Manage Team ";
            btnManageTeam.UseVisualStyleBackColor = true;
            btnManageTeam.Click += btnManageTeam_Click;
            // 
            // btnManagePlayer
            // 
            btnManagePlayer.Location = new Point(3, 38);
            btnManagePlayer.Name = "btnManagePlayer";
            btnManagePlayer.Size = new Size(241, 29);
            btnManagePlayer.TabIndex = 1;
            btnManagePlayer.Text = "Manage Player";
            btnManagePlayer.UseVisualStyleBackColor = true;
            btnManagePlayer.Click += btnManagePlayer_Click;
            // 
            // btnManageTournament
            // 
            btnManageTournament.Location = new Point(3, 73);
            btnManageTournament.Name = "btnManageTournament";
            btnManageTournament.Size = new Size(241, 29);
            btnManageTournament.TabIndex = 2;
            btnManageTournament.Text = "Manage Tournament";
            btnManageTournament.UseVisualStyleBackColor = true;
            btnManageTournament.Click += btnManageTournament_Click;
            // 
            // btnManageMatch
            // 
            btnManageMatch.Location = new Point(3, 108);
            btnManageMatch.Name = "btnManageMatch";
            btnManageMatch.Size = new Size(241, 29);
            btnManageMatch.TabIndex = 3;
            btnManageMatch.Text = "Manage Match";
            btnManageMatch.UseVisualStyleBackColor = true;
            btnManageMatch.Click += btnManageMatch_Click;
            // 
            // btnManageSponsor
            // 
            btnManageSponsor.Location = new Point(3, 143);
            btnManageSponsor.Name = "btnManageSponsor";
            btnManageSponsor.Size = new Size(241, 29);
            btnManageSponsor.TabIndex = 4;
            btnManageSponsor.Text = "Manage Sponsor";
            btnManageSponsor.UseVisualStyleBackColor = true;
            btnManageSponsor.Click += btnManageSponsor_Click;
            // 
            // btnManageReward
            // 
            btnManageReward.Location = new Point(3, 178);
            btnManageReward.Name = "btnManageReward";
            btnManageReward.Size = new Size(241, 29);
            btnManageReward.TabIndex = 5;
            btnManageReward.Text = "Manage Reward";
            btnManageReward.UseVisualStyleBackColor = true;
            btnManageReward.Click += btnManageReward_Click;
            // 
            // btnStatistic
            // 
            btnStatistic.Location = new Point(3, 213);
            btnStatistic.Name = "btnStatistic";
            btnStatistic.Size = new Size(241, 29);
            btnStatistic.TabIndex = 6;
            btnStatistic.Text = "Statistic";
            btnStatistic.UseVisualStyleBackColor = true;
            btnStatistic.Click += btnStatistic_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(250, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(825, 125);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(356, 49);
            label1.Name = "label1";
            label1.Size = new Size(114, 20);
            label1.TabIndex = 0;
            label1.Text = "Esport Manager";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1075, 670);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel1);
            IsMdiContainer = true;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnManageTeam;
        private Panel panel1;
        private Label label1;
        private Button btnManagePlayer;
        private Button btnManageTournament;
        private Button btnManageMatch;
        private Button btnManageSponsor;
        private Button btnManageReward;
        private Button btnStatistic;
    }
}