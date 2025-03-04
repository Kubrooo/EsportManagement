namespace EsportManagement.Forms
{
    partial class ManageTeamForm
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
            dgvTeam = new DataGridView();
            tbTeam = new TextBox();
            label2 = new Label();
            label3 = new Label();
            tbCountry = new TextBox();
            numTotalPoint = new NumericUpDown();
            label4 = new Label();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnCancel = new Button();
            btnSave = new Button();
            tbSearch = new TextBox();
            cbSortOptions = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvTeam).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numTotalPoint).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(388, 21);
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 0;
            label1.Text = "Manage Team";
            // 
            // dgvTeam
            // 
            dgvTeam.AllowUserToAddRows = false;
            dgvTeam.AllowUserToDeleteRows = false;
            dgvTeam.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTeam.Location = new Point(25, 108);
            dgvTeam.Name = "dgvTeam";
            dgvTeam.ReadOnly = true;
            dgvTeam.RowHeadersVisible = false;
            dgvTeam.RowHeadersWidth = 51;
            dgvTeam.Size = new Size(858, 188);
            dgvTeam.TabIndex = 1;
            dgvTeam.CellClick += dgvTeam_CellClick;
            // 
            // tbTeam
            // 
            tbTeam.Location = new Point(25, 324);
            tbTeam.Name = "tbTeam";
            tbTeam.Size = new Size(157, 27);
            tbTeam.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 301);
            label2.Name = "label2";
            label2.Size = new Size(96, 20);
            label2.TabIndex = 3;
            label2.Text = "Team Name :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 363);
            label3.Name = "label3";
            label3.Size = new Size(107, 20);
            label3.TabIndex = 5;
            label3.Text = "Team Country :";
            // 
            // tbCountry
            // 
            tbCountry.Location = new Point(25, 386);
            tbCountry.Name = "tbCountry";
            tbCountry.Size = new Size(157, 27);
            tbCountry.TabIndex = 6;
            // 
            // numTotalPoint
            // 
            numTotalPoint.Location = new Point(25, 447);
            numTotalPoint.Name = "numTotalPoint";
            numTotalPoint.Size = new Size(157, 27);
            numTotalPoint.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 424);
            label4.Name = "label4";
            label4.Size = new Size(86, 20);
            label4.TabIndex = 8;
            label4.Text = "Total Point :";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(310, 328);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(310, 363);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 10;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(310, 398);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(410, 328);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(410, 363);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 13;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // tbSearch
            // 
            tbSearch.Location = new Point(25, 75);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(219, 27);
            tbSearch.TabIndex = 14;
            tbSearch.TextChanged += tbSearch_TextChanged;
            // 
            // cbSortOptions
            // 
            cbSortOptions.FormattingEnabled = true;
            cbSortOptions.Items.AddRange(new object[] { "Total Turnamen", "Total Menang", "Total Hadiah Item" });
            cbSortOptions.Location = new Point(253, 74);
            cbSortOptions.Name = "cbSortOptions";
            cbSortOptions.Size = new Size(151, 28);
            cbSortOptions.TabIndex = 15;
            cbSortOptions.SelectedIndexChanged += cbSortOptions_SelectedIndexChanged;
            // 
            // ManageTeamForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(905, 519);
            Controls.Add(cbSortOptions);
            Controls.Add(tbSearch);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(label4);
            Controls.Add(numTotalPoint);
            Controls.Add(tbCountry);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tbTeam);
            Controls.Add(dgvTeam);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageTeamForm";
            Text = "ManageTeamForm";
            Load += ManageTeamForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTeam).EndInit();
            ((System.ComponentModel.ISupportInitialize)numTotalPoint).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvTeam;
        private TextBox tbTeam;
        private Label label2;
        private Label label3;
        private TextBox tbCountry;
        private NumericUpDown numTotalPoint;
        private Label label4;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnCancel;
        private Button btnSave;
        private TextBox tbSearch;
        private ComboBox cbSortOptions;
    }
}