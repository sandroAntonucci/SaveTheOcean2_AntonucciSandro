namespace SaveTheOcean
{
    partial class Form2
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
            components = new System.ComponentModel.Container();
            lblRole = new Label();
            cmbRole = new ComboBox();
            label1 = new Label();
            lblName = new Label();
            txtCharName = new TextBox();
            btnCreateChar = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRole.Location = new Point(35, 22);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(144, 19);
            lblRole.TabIndex = 0;
            lblRole.Text = "Datos del personaje";
            // 
            // cmbRole
            // 
            cmbRole.FormattingEnabled = true;
            cmbRole.Items.AddRange(new object[] { "Técnico [ 45 XP ]", "Veterinario [ 80 XP ]" });
            cmbRole.Location = new Point(46, 145);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(121, 23);
            cmbRole.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(93, 127);
            label1.Name = "label1";
            label1.Size = new Size(24, 15);
            label1.TabIndex = 2;
            label1.Text = "Rol";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(77, 66);
            lblName.Name = "lblName";
            lblName.Size = new Size(51, 15);
            lblName.TabIndex = 3;
            lblName.Text = "Nombre";
            // 
            // txtCharName
            // 
            txtCharName.Location = new Point(55, 84);
            txtCharName.Name = "txtCharName";
            txtCharName.Size = new Size(100, 23);
            txtCharName.TabIndex = 4;
            // 
            // btnCreateChar
            // 
            btnCreateChar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreateChar.Location = new Point(65, 199);
            btnCreateChar.Name = "btnCreateChar";
            btnCreateChar.Size = new Size(75, 23);
            btnCreateChar.TabIndex = 5;
            btnCreateChar.Text = "Crear";
            btnCreateChar.UseVisualStyleBackColor = true;
            btnCreateChar.Click += btnCreateChar_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(214, 243);
            Controls.Add(btnCreateChar);
            Controls.Add(txtCharName);
            Controls.Add(lblName);
            Controls.Add(label1);
            Controls.Add(cmbRole);
            Controls.Add(lblRole);
            Name = "Form2";
            Text = "Crear Personaje";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRole;
        private ComboBox cmbRole;
        private Label label1;
        private Label lblName;
        private TextBox txtCharName;
        private Button btnCreateChar;
        private ErrorProvider errorProvider1;
    }
}