namespace EsportManagement.Forms
{
    partial class ManagePlayerForm
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
            dgvPlayer = new DataGridView();
            tbPlayerName = new TextBox();
            label2 = new Label();
            cbRole = new ComboBox();
            label3 = new Label();
            numKill = new NumericUpDown();
            numAssist = new NumericUpDown();
            numDeath = new NumericUpDown();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            cbTeam = new ComboBox();
            label7 = new Label();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPlayer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numKill).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numAssist).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDeath).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(338, 23);
            label1.Name = "label1";
            label1.Size = new Size(107, 20);
            label1.TabIndex = 0;
            label1.Text = "Manage Player";
            // 
            // dgvPlayer
            // 
            dgvPlayer.AllowUserToAddRows = false;
            dgvPlayer.AllowUserToDeleteRows = false;
            dgvPlayer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPlayer.Location = new Point(41, 131);
            dgvPlayer.Name = "dgvPlayer";
            dgvPlayer.ReadOnly = true;
            dgvPlayer.RowHeadersWidth = 51;
            dgvPlayer.Size = new Size(715, 188);
            dgvPlayer.TabIndex = 1;
            dgvPlayer.CellClick += dgvPlayer_CellClick;
            // 
            // tbPlayerName
            // 
            tbPlayerName.Location = new Point(41, 354);
            tbPlayerName.Name = "tbPlayerName";
            tbPlayerName.Size = new Size(150, 27);
            tbPlayerName.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 331);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 3;
            label2.Text = "Player Name :";
            // 
            // cbRole
            // 
            cbRole.FormattingEnabled = true;
            cbRole.Items.AddRange(new object[] { "Tank", "Support", "DPS", "Sniper", "Assassin" });
            cbRole.Location = new Point(41, 418);
            cbRole.Name = "cbRole";
            cbRole.Size = new Size(151, 28);
            cbRole.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 395);
            label3.Name = "label3";
            label3.Size = new Size(90, 20);
            label3.TabIndex = 5;
            label3.Text = "Player Role :";
            // 
            // numKill
            // 
            numKill.Location = new Point(242, 354);
            numKill.Name = "numKill";
            numKill.Size = new Size(150, 27);
            numKill.TabIndex = 6;
            // 
            // numAssist
            // 
            numAssist.Location = new Point(242, 408);
            numAssist.Name = "numAssist";
            numAssist.Size = new Size(150, 27);
            numAssist.TabIndex = 7;
            // 
            // numDeath
            // 
            numDeath.Location = new Point(242, 460);
            numDeath.Name = "numDeath";
            numDeath.Size = new Size(150, 27);
            numDeath.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(242, 331);
            label4.Name = "label4";
            label4.Size = new Size(37, 20);
            label4.TabIndex = 9;
            label4.Text = "Kill :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(242, 384);
            label5.Name = "label5";
            label5.Size = new Size(53, 20);
            label5.TabIndex = 10;
            label5.Text = "Assist :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(242, 438);
            label6.Name = "label6";
            label6.Size = new Size(56, 20);
            label6.TabIndex = 11;
            label6.Text = "Death :";
            // 
            // cbTeam
            // 
            cbTeam.FormattingEnabled = true;
            cbTeam.Location = new Point(440, 354);
            cbTeam.Name = "cbTeam";
            cbTeam.Size = new Size(151, 28);
            cbTeam.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(440, 331);
            label7.Name = "label7";
            label7.Size = new Size(52, 20);
            label7.TabIndex = 13;
            label7.Text = "Team :";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(440, 395);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 14;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(540, 395);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 15;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(640, 395);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 16;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(497, 429);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 17;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(597, 430);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 18;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // ManagePlayerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 529);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(label7);
            Controls.Add(cbTeam);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(numDeath);
            Controls.Add(numAssist);
            Controls.Add(numKill);
            Controls.Add(label3);
            Controls.Add(cbRole);
            Controls.Add(label2);
            Controls.Add(tbPlayerName);
            Controls.Add(dgvPlayer);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManagePlayerForm";
            Text = "ManagePlayerForm";
            Load += ManagePlayerForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPlayer).EndInit();
            ((System.ComponentModel.ISupportInitialize)numKill).EndInit();
            ((System.ComponentModel.ISupportInitialize)numAssist).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDeath).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvPlayer;
        private TextBox tbPlayerName;
        private Label label2;
        private ComboBox cbRole;
        private Label label3;
        private NumericUpDown numKill;
        private NumericUpDown numAssist;
        private NumericUpDown numDeath;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox cbTeam;
        private Label label7;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnSave;
        private Button btnCancel;
    }
}