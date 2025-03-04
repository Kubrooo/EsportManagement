namespace EsportManagement.Forms
{
    partial class ManageMatchForm
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
            label1 = new Label();
            dgvMatch = new DataGridView();
            cbFirstTeam = new ComboBox();
            cbSecondTeam = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            cbWinnerTeam = new ComboBox();
            label4 = new Label();
            cbTournament = new ComboBox();
            label5 = new Label();
            numFirstTeamScore = new NumericUpDown();
            numSecondTeamScore = new NumericUpDown();
            label6 = new Label();
            label7 = new Label();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnCancel = new Button();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMatch).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numFirstTeamScore).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSecondTeamScore).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(325, 9);
            label1.Name = "label1";
            label1.Size = new Size(108, 20);
            label1.TabIndex = 0;
            label1.Text = "Manage Match";
            // 
            // dgvMatch
            // 
            dgvMatch.AllowUserToAddRows = false;
            dgvMatch.AllowUserToDeleteRows = false;
            dgvMatch.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMatch.Location = new Point(47, 72);
            dgvMatch.Name = "dgvMatch";
            dgvMatch.ReadOnly = true;
            dgvMatch.RowHeadersVisible = false;
            dgvMatch.RowHeadersWidth = 51;
            dgvMatch.Size = new Size(708, 199);
            dgvMatch.TabIndex = 1;
            dgvMatch.CellClick += dgvMatch_CellClick;
            // 
            // cbFirstTeam
            // 
            cbFirstTeam.FormattingEnabled = true;
            cbFirstTeam.Location = new Point(47, 312);
            cbFirstTeam.Name = "cbFirstTeam";
            cbFirstTeam.Size = new Size(159, 28);
            cbFirstTeam.TabIndex = 2;
            // 
            // cbSecondTeam
            // 
            cbSecondTeam.FormattingEnabled = true;
            cbSecondTeam.Location = new Point(47, 370);
            cbSecondTeam.Name = "cbSecondTeam";
            cbSecondTeam.Size = new Size(159, 28);
            cbSecondTeam.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 289);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 4;
            label2.Text = "First Team :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 347);
            label3.Name = "label3";
            label3.Size = new Size(105, 20);
            label3.TabIndex = 5;
            label3.Text = "Second Team :";
            // 
            // cbWinnerTeam
            // 
            cbWinnerTeam.FormattingEnabled = true;
            cbWinnerTeam.Location = new Point(47, 430);
            cbWinnerTeam.Name = "cbWinnerTeam";
            cbWinnerTeam.Size = new Size(159, 28);
            cbWinnerTeam.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(47, 407);
            label4.Name = "label4";
            label4.Size = new Size(101, 20);
            label4.TabIndex = 7;
            label4.Text = "Winner team :";
            // 
            // cbTournament
            // 
            cbTournament.FormattingEnabled = true;
            cbTournament.Location = new Point(235, 430);
            cbTournament.Name = "cbTournament";
            cbTournament.Size = new Size(159, 28);
            cbTournament.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(235, 407);
            label5.Name = "label5";
            label5.Size = new Size(139, 20);
            label5.TabIndex = 9;
            label5.Text = "Tournament Name :";
            // 
            // numFirstTeamScore
            // 
            numFirstTeamScore.Location = new Point(235, 313);
            numFirstTeamScore.Name = "numFirstTeamScore";
            numFirstTeamScore.Size = new Size(159, 27);
            numFirstTeamScore.TabIndex = 10;
            // 
            // numSecondTeamScore
            // 
            numSecondTeamScore.Location = new Point(235, 371);
            numSecondTeamScore.Name = "numSecondTeamScore";
            numSecondTeamScore.Size = new Size(159, 27);
            numSecondTeamScore.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(235, 348);
            label6.Name = "label6";
            label6.Size = new Size(146, 20);
            label6.TabIndex = 12;
            label6.Text = "Second Team Score :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(235, 289);
            label7.Name = "label7";
            label7.Size = new Size(124, 20);
            label7.TabIndex = 13;
            label7.Text = "First Team Score :";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(492, 313);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 14;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(492, 348);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 15;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(492, 383);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 16;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(592, 360);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 17;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(592, 325);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 18;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // ManageMatchForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 489);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(numSecondTeamScore);
            Controls.Add(numFirstTeamScore);
            Controls.Add(label5);
            Controls.Add(cbTournament);
            Controls.Add(label4);
            Controls.Add(cbWinnerTeam);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cbSecondTeam);
            Controls.Add(cbFirstTeam);
            Controls.Add(dgvMatch);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageMatchForm";
            Text = "ManageMatchForm";
            ((System.ComponentModel.ISupportInitialize)dgvMatch).EndInit();
            ((System.ComponentModel.ISupportInitialize)numFirstTeamScore).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSecondTeamScore).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvMatch;
        private ComboBox cbFirstTeam;
        private ComboBox cbSecondTeam;
        private Label label2;
        private Label label3;
        private ComboBox cbWinnerTeam;
        private Label label4;
        private ComboBox cbTournament;
        private Label label5;
        private NumericUpDown numFirstTeamScore;
        private NumericUpDown numSecondTeamScore;
        private Label label6;
        private Label label7;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnCancel;
        private Button btnSave;
    }
}