namespace SaveTheOcean
{
    partial class FormRescues
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
            dgvRescues = new DataGridView();
            textBox1 = new TextBox();
            btnIdSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvRescues).BeginInit();
            SuspendLayout();
            // 
            // dgvRescues
            // 
            dgvRescues.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRescues.Dock = DockStyle.Top;
            dgvRescues.Location = new Point(0, 0);
            dgvRescues.Name = "dgvRescues";
            dgvRescues.Size = new Size(656, 373);
            dgvRescues.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(581, 405);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(63, 23);
            textBox1.TabIndex = 1;
            // 
            // btnIdSearch
            // 
            btnIdSearch.Location = new Point(474, 405);
            btnIdSearch.Name = "btnIdSearch";
            btnIdSearch.Size = new Size(101, 23);
            btnIdSearch.TabIndex = 2;
            btnIdSearch.Text = "Buscar por ID";
            btnIdSearch.UseVisualStyleBackColor = true;
            btnIdSearch.Click += btnIdSearch_Click;
            // 
            // FormRescues
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(656, 450);
            Controls.Add(btnIdSearch);
            Controls.Add(textBox1);
            Controls.Add(dgvRescues);
            Name = "FormRescues";
            Text = "FormRescues";
            Load += FormRescues_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRescues).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvRescues;
        private TextBox textBox1;
        private Button btnIdSearch;
    }
}