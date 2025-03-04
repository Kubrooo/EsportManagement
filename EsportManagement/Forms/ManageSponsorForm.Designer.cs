namespace EsportManagement.Forms
{
    partial class ManageSponsorForm
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
            dgvSponsors = new DataGridView();
            tbSponsorName = new TextBox();
            label2 = new Label();
            numNilaiHadiah = new NumericUpDown();
            label3 = new Label();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            btnCancel = new Button();
            dgvTournament = new DataGridView();
            cbTournament = new ComboBox();
            label4 = new Label();
            comboBox1 = new ComboBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvSponsors).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numNilaiHadiah).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTournament).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(325, 9);
            label1.Name = "label1";
            label1.Size = new Size(121, 20);
            label1.TabIndex = 0;
            label1.Text = "Manage Sponsor";
            // 
            // dgvSponsors
            // 
            dgvSponsors.AllowUserToAddRows = false;
            dgvSponsors.AllowUserToDeleteRows = false;
            dgvSponsors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSponsors.Location = new Point(36, 43);
            dgvSponsors.Name = "dgvSponsors";
            dgvSponsors.ReadOnly = true;
            dgvSponsors.RowHeadersVisible = false;
            dgvSponsors.RowHeadersWidth = 51;
            dgvSponsors.Size = new Size(716, 188);
            dgvSponsors.TabIndex = 1;
            dgvSponsors.CellClick += dgvSponsors_CellClick;
            // 
            // tbSponsorName
            // 
            tbSponsorName.Location = new Point(36, 461);
            tbSponsorName.Name = "tbSponsorName";
            tbSponsorName.Size = new Size(163, 27);
            tbSponsorName.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 438);
            label2.Name = "label2";
            label2.Size = new Size(114, 20);
            label2.TabIndex = 3;
            label2.Text = "Sponsor Name :";
            // 
            // numNilaiHadiah
            // 
            numNilaiHadiah.Location = new Point(36, 530);
            numNilaiHadiah.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            numNilaiHadiah.Name = "numNilaiHadiah";
            numNilaiHadiah.Size = new Size(163, 27);
            numNilaiHadiah.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 507);
            label3.Name = "label3";
            label3.Size = new Size(99, 20);
            label3.TabIndex = 5;
            label3.Text = "Nilai Hadiah :";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(458, 459);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(558, 459);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 7;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(658, 459);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(515, 494);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 9;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(615, 494);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // dgvTournament
            // 
            dgvTournament.AllowUserToAddRows = false;
            dgvTournament.AllowUserToDeleteRows = false;
            dgvTournament.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTournament.Location = new Point(36, 259);
            dgvTournament.Name = "dgvTournament";
            dgvTournament.ReadOnly = true;
            dgvTournament.RowHeadersVisible = false;
            dgvTournament.RowHeadersWidth = 51;
            dgvTournament.Size = new Size(716, 161);
            dgvTournament.TabIndex = 11;
            // 
            // cbTournament
            // 
            cbTournament.FormattingEnabled = true;
            cbTournament.Location = new Point(214, 461);
            cbTournament.Name = "cbTournament";
            cbTournament.Size = new Size(162, 28);
            cbTournament.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(214, 438);
            label4.Name = "label4";
            label4.Size = new Size(95, 20);
            label4.TabIndex = 13;
            label4.Text = "Tournament :";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(214, 528);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(162, 28);
            comboBox1.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(214, 505);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 15;
            // 
            // ManageSponsorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 568);
            Controls.Add(label5);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(cbTournament);
            Controls.Add(dgvTournament);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(label3);
            Controls.Add(numNilaiHadiah);
            Controls.Add(label2);
            Controls.Add(tbSponsorName);
            Controls.Add(dgvSponsors);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageSponsorForm";
            Text = "ManageSponsorForm";
            ((System.ComponentModel.ISupportInitialize)dgvSponsors).EndInit();
            ((System.ComponentModel.ISupportInitialize)numNilaiHadiah).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTournament).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvSponsors;
        private TextBox tbSponsorName;
        private Label label2;
        private NumericUpDown numNilaiHadiah;
        private Label label3;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnSave;
        private Button btnCancel;
        private DataGridView dgvTournament;
        private ComboBox cbTournament;
        private Label label4;
        private ComboBox comboBox1;
        private Label label5;
    }
}