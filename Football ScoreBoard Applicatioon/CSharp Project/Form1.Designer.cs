namespace CSharp_Project
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.HomeGoal = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.DISPLAYCHANGER = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Location = new System.Drawing.Point(15, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 56);
            this.button1.TabIndex = 0;
            this.button1.Text = "Intialise Score";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // HomeGoal
            // 
            this.HomeGoal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.HomeGoal.Location = new System.Drawing.Point(15, 145);
            this.HomeGoal.Name = "HomeGoal";
            this.HomeGoal.Size = new System.Drawing.Size(118, 56);
            this.HomeGoal.TabIndex = 1;
            this.HomeGoal.Text = "Home Goal";
            this.HomeGoal.UseVisualStyleBackColor = true;
            this.HomeGoal.Click += new System.EventHandler(this.HomeGoal_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.Location = new System.Drawing.Point(15, 257);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 56);
            this.button3.TabIndex = 2;
            this.button3.Text = "Away Goal";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button4.Location = new System.Drawing.Point(250, 313);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(358, 61);
            this.button4.TabIndex = 3;
            this.button4.Text = "UpdateDisplay";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // DISPLAYCHANGER
            // 
            this.DISPLAYCHANGER.AutoSize = true;
            this.DISPLAYCHANGER.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DISPLAYCHANGER.Location = new System.Drawing.Point(195, 174);
            this.DISPLAYCHANGER.Name = "DISPLAYCHANGER";
            this.DISPLAYCHANGER.Size = new System.Drawing.Size(0, 55);
            this.DISPLAYCHANGER.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(334, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Welcome To The World Class Football Stadium";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(856, 410);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DISPLAYCHANGER);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.HomeGoal);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button HomeGoal;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label DISPLAYCHANGER;
        private System.Windows.Forms.Label label2;
    }
}

