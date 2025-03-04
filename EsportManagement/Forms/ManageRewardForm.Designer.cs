namespace EsportManagement.Forms
{
    partial class ManageRewardForm
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
            dgvRewards = new DataGridView();
            cbSponsorName = new ComboBox();
            label2 = new Label();
            numNilaiHadiah = new NumericUpDown();
            label3 = new Label();
            cbNamaTournament = new ComboBox();
            label4 = new Label();
            cbNamaTeamPenerima = new ComboBox();
            label5 = new Label();
            cbJenisHadiah = new ComboBox();
            label6 = new Label();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvRewards).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numNilaiHadiah).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(327, 9);
            label1.Name = "label1";
            label1.Size = new Size(117, 20);
            label1.TabIndex = 0;
            label1.Text = "Manage Reward";
            // 
            // dgvRewards
            // 
            dgvRewards.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRewards.Location = new Point(55, 81);
            dgvRewards.Name = "dgvRewards";
            dgvRewards.RowHeadersVisible = false;
            dgvRewards.RowHeadersWidth = 51;
            dgvRewards.Size = new Size(692, 188);
            dgvRewards.TabIndex = 1;
            dgvRewards.CellClick += dgvRewards_CellClick;
            // 
            // cbSponsorName
            // 
            cbSponsorName.FormattingEnabled = true;
            cbSponsorName.Location = new Point(55, 307);
            cbSponsorName.Name = "cbSponsorName";
            cbSponsorName.Size = new Size(163, 28);
            cbSponsorName.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 284);
            label2.Name = "label2";
            label2.Size = new Size(118, 20);
            label2.TabIndex = 3;
            label2.Text = "Sponsor Name : ";
            // 
            // numNilaiHadiah
            // 
            numNilaiHadiah.Location = new Point(55, 383);
            numNilaiHadiah.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
            numNilaiHadiah.Name = "numNilaiHadiah";
            numNilaiHadiah.Size = new Size(163, 27);
            numNilaiHadiah.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(55, 360);
            label3.Name = "label3";
            label3.Size = new Size(99, 20);
            label3.TabIndex = 5;
            label3.Text = "Nilai Hadiah :";
            // 
            // cbNamaTournament
            // 
            cbNamaTournament.FormattingEnabled = true;
            cbNamaTournament.Location = new Point(269, 307);
            cbNamaTournament.Name = "cbNamaTournament";
            cbNamaTournament.Size = new Size(157, 28);
            cbNamaTournament.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(269, 284);
            label4.Name = "label4";
            label4.Size = new Size(139, 20);
            label4.TabIndex = 7;
            label4.Text = "Nama Tournament :";
            // 
            // cbNamaTeamPenerima
            // 
            cbNamaTeamPenerima.FormattingEnabled = true;
            cbNamaTeamPenerima.Location = new Point(269, 382);
            cbNamaTeamPenerima.Name = "cbNamaTeamPenerima";
            cbNamaTeamPenerima.Size = new Size(157, 28);
            cbNamaTeamPenerima.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(269, 360);
            label5.Name = "label5";
            label5.Size = new Size(106, 20);
            label5.TabIndex = 9;
            label5.Text = "Tim Penerima :";
            // 
            // cbJenisHadiah
            // 
            cbJenisHadiah.FormattingEnabled = true;
            cbJenisHadiah.Items.AddRange(new object[] { " Uang", " ItemInGame", " Marchandise " });
            cbJenisHadiah.Location = new Point(473, 307);
            cbJenisHadiah.Name = "cbJenisHadiah";
            cbJenisHadiah.Size = new Size(160, 28);
            cbJenisHadiah.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(473, 284);
            label6.Name = "label6";
            label6.Size = new Size(99, 20);
            label6.TabIndex = 11;
            label6.Text = "Jenis Hadiah :";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(473, 351);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(473, 386);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 13;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(473, 421);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(573, 370);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 15;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(573, 405);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 16;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // ManageRewardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 473);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(label6);
            Controls.Add(cbJenisHadiah);
            Controls.Add(label5);
            Controls.Add(cbNamaTeamPenerima);
            Controls.Add(label4);
            Controls.Add(cbNamaTournament);
            Controls.Add(label3);
            Controls.Add(numNilaiHadiah);
            Controls.Add(label2);
            Controls.Add(cbSponsorName);
            Controls.Add(dgvRewards);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageRewardForm";
            Text = "ManageRewardForm";
            ((System.ComponentModel.ISupportInitialize)dgvRewards).EndInit();
            ((System.ComponentModel.ISupportInitialize)numNilaiHadiah).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvRewards;
        private ComboBox cbSponsorName;
        private Label label2;
        private NumericUpDown numNilaiHadiah;
        private Label label3;
        private ComboBox cbNamaTournament;
        private Label label4;
        private ComboBox cbNamaTeamPenerima;
        private Label label5;
        private ComboBox cbJenisHadiah;
        private Label label6;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnSave;
        private Button btnCancel;
    }
}