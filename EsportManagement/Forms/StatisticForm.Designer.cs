namespace EsportManagement.Forms
{
    partial class StatisticForm
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
            dataGridViewStatistics = new DataGridView();
            dataGridViewTeamStats = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStatistics).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTeamStats).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(335, 9);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 0;
            label1.Text = "Statistic";
            // 
            // dataGridViewStatistics
            // 
            dataGridViewStatistics.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStatistics.Location = new Point(58, 73);
            dataGridViewStatistics.Name = "dataGridViewStatistics";
            dataGridViewStatistics.RowHeadersWidth = 51;
            dataGridViewStatistics.Size = new Size(687, 188);
            dataGridViewStatistics.TabIndex = 1;
            // 
            // dataGridViewTeamStats
            // 
            dataGridViewTeamStats.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTeamStats.Location = new Point(58, 297);
            dataGridViewTeamStats.Name = "dataGridViewTeamStats";
            dataGridViewTeamStats.RowHeadersWidth = 51;
            dataGridViewTeamStats.Size = new Size(687, 188);
            dataGridViewTeamStats.TabIndex = 2;
            // 
            // StatisticForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 510);
            Controls.Add(dataGridViewTeamStats);
            Controls.Add(dataGridViewStatistics);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StatisticForm";
            Text = "StatisticForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewStatistics).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTeamStats).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridViewStatistics;
        private DataGridView dataGridViewTeamStats;
    }
}