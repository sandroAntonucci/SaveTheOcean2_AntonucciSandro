namespace SaveTheOcean
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LblGame = new Label();
            btnPlay = new Button();
            btnExit = new Button();
            btnSeeRescues = new Button();
            btnRescues = new Button();
            SuspendLayout();
            // 
            // LblGame
            // 
            LblGame.AutoSize = true;
            LblGame.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblGame.Location = new Point(26, 33);
            LblGame.Name = "LblGame";
            LblGame.Size = new Size(154, 26);
            LblGame.TabIndex = 0;
            LblGame.Text = "Save the Ocean!";
            // 
            // btnPlay
            // 
            btnPlay.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPlay.Location = new Point(30, 75);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(150, 39);
            btnPlay.TabIndex = 1;
            btnPlay.Text = "Jugar";
            btnPlay.UseVisualStyleBackColor = true;
            btnPlay.Click += btnPlay_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(30, 165);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(150, 39);
            btnExit.TabIndex = 2;
            btnExit.Text = "Salir";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnSeeRescues
            // 
            btnSeeRescues.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSeeRescues.Location = new Point(52, 120);
            btnSeeRescues.Name = "btnSeeRescues";
            btnSeeRescues.Size = new Size(103, 39);
            btnSeeRescues.TabIndex = 3;
            btnSeeRescues.Text = "Ver Rescates";
            btnSeeRescues.UseVisualStyleBackColor = true;

            // 
            // btnRescues
            // 
            btnRescues.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRescues.Location = new Point(30, 120);
            btnRescues.Name = "btnRescues";
            btnRescues.Size = new Size(150, 39);
            btnRescues.TabIndex = 4;
            btnRescues.Text = "Ver Rescates";
            btnRescues.UseVisualStyleBackColor = true;
            btnRescues.Click += btnRescues_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(214, 221);
            Controls.Add(btnRescues);
            Controls.Add(btnSeeRescues);
            Controls.Add(btnExit);
            Controls.Add(btnPlay);
            Controls.Add(LblGame);
            Name = "Form1";
            Text = "Save the ocean";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblGame;
        private Button btnPlay;
        private Button btnExit;
        private Button btnSeeRescues;
        private Button btnRescues;
    }
}
