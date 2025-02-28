namespace EsportManagement.Forms
{
    partial class ManageTournamentForm
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
            dgvTournament = new DataGridView();
            tbTournamentTitle = new TextBox();
            label2 = new Label();
            dtStartDate = new DateTimePicker();
            label3 = new Label();
            dtEndDate = new DateTimePicker();
            label4 = new Label();
            cbFormatTournament = new ComboBox();
            label5 = new Label();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            btnCancel = new Button();
            btnShowDeleted = new Button();
            btnRestoreDeleted = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTournament).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(317, 9);
            label1.Name = "label1";
            label1.Size = new Size(146, 20);
            label1.TabIndex = 0;
            label1.Text = "Manage Tournament";
            // 
            // dgvTournament
            // 
            dgvTournament.AllowUserToAddRows = false;
            dgvTournament.AllowUserToDeleteRows = false;
            dgvTournament.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTournament.Location = new Point(41, 83);
            dgvTournament.Name = "dgvTournament";
            dgvTournament.ReadOnly = true;
            dgvTournament.RowHeadersVisible = false;
            dgvTournament.RowHeadersWidth = 51;
            dgvTournament.Size = new Size(725, 188);
            dgvTournament.TabIndex = 1;
            dgvTournament.CellClick += dgvTournament_CellClick;
            // 
            // tbTournamentTitle
            // 
            tbTournamentTitle.Location = new Point(41, 304);
            tbTournamentTitle.Name = "tbTournamentTitle";
            tbTournamentTitle.Size = new Size(158, 27);
            tbTournamentTitle.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 281);
            label2.Name = "label2";
            label2.Size = new Size(128, 20);
            label2.TabIndex = 3;
            label2.Text = "Tournament Title :";
            // 
            // dtStartDate
            // 
            dtStartDate.Location = new Point(41, 362);
            dtStartDate.Name = "dtStartDate";
            dtStartDate.Size = new Size(158, 27);
            dtStartDate.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 339);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 5;
            label3.Text = "Start Date :";
            // 
            // dtEndDate
            // 
            dtEndDate.Location = new Point(41, 427);
            dtEndDate.Name = "dtEndDate";
            dtEndDate.Size = new Size(158, 27);
            dtEndDate.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 404);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 7;
            label4.Text = "End Date :";
            // 
            // cbFormatTournament
            // 
            cbFormatTournament.FormattingEnabled = true;
            cbFormatTournament.Items.AddRange(new object[] { "Liga ", "Eliminasi", "Grup " });
            cbFormatTournament.Location = new Point(255, 303);
            cbFormatTournament.Name = "cbFormatTournament";
            cbFormatTournament.Size = new Size(151, 28);
            cbFormatTournament.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(255, 281);
            label5.Name = "label5";
            label5.Size = new Size(146, 20);
            label5.TabIndex = 9;
            label5.Text = "Format Tournament :";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(437, 302);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(437, 337);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 11;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(437, 374);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(537, 320);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 13;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(537, 355);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnShowDeleted
            // 
            btnShowDeleted.Location = new Point(558, 434);
            btnShowDeleted.Name = "btnShowDeleted";
            btnShowDeleted.Size = new Size(116, 29);
            btnShowDeleted.TabIndex = 15;
            btnShowDeleted.Text = "Show Deleted";
            btnShowDeleted.UseVisualStyleBackColor = true;
            btnShowDeleted.Click += btnShowDeleted_Click;
            // 
            // btnRestoreDeleted
            // 
            btnRestoreDeleted.Location = new Point(680, 434);
            btnRestoreDeleted.Name = "btnRestoreDeleted";
            btnRestoreDeleted.Size = new Size(94, 29);
            btnRestoreDeleted.TabIndex = 16;
            btnRestoreDeleted.Text = "Restore";
            btnRestoreDeleted.UseVisualStyleBackColor = true;
            btnRestoreDeleted.Click += btnRestoreDeleted_Click;
            // 
            // ManageTournamentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 475);
            Controls.Add(btnRestoreDeleted);
            Controls.Add(btnShowDeleted);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(label5);
            Controls.Add(cbFormatTournament);
            Controls.Add(label4);
            Controls.Add(dtEndDate);
            Controls.Add(label3);
            Controls.Add(dtStartDate);
            Controls.Add(label2);
            Controls.Add(tbTournamentTitle);
            Controls.Add(dgvTournament);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageTournamentForm";
            Text = "ManageTournamentForm";
            ((System.ComponentModel.ISupportInitialize)dgvTournament).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvTournament;
        private TextBox tbTournamentTitle;
        private Label label2;
        private DateTimePicker dtStartDate;
        private Label label3;
        private DateTimePicker dtEndDate;
        private Label label4;
        private ComboBox cbFormatTournament;
        private Label label5;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnSave;
        private Button btnCancel;
        private Button btnShowDeleted;
        private Button btnRestoreDeleted;
    }
}