namespace JK_saldumi_31_01
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
            this.label1 = new System.Windows.Forms.Label();
            this.naudas_ievade = new System.Windows.Forms.TextBox();
            this.aprekinat = new System.Windows.Forms.Button();
            this.rezultats = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightYellow;
            this.label1.Location = new System.Drawing.Point(429, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "SALDUMU VEIKALS MAZAA";
            // 
            // naudas_ievade
            // 
            this.naudas_ievade.Location = new System.Drawing.Point(287, 96);
            this.naudas_ievade.Name = "naudas_ievade";
            this.naudas_ievade.Size = new System.Drawing.Size(118, 20);
            this.naudas_ievade.TabIndex = 1;
            this.naudas_ievade.Text = "56";
            this.naudas_ievade.TextChanged += new System.EventHandler(this.naudas_ievade_TextChanged);
            // 
            // aprekinat
            // 
            this.aprekinat.BackColor = System.Drawing.Color.DarkTurquoise;
            this.aprekinat.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.aprekinat.Location = new System.Drawing.Point(432, 168);
            this.aprekinat.Name = "aprekinat";
            this.aprekinat.Size = new System.Drawing.Size(144, 68);
            this.aprekinat.TabIndex = 2;
            this.aprekinat.Text = "aprekinat";
            this.aprekinat.UseVisualStyleBackColor = false;
            this.aprekinat.Click += new System.EventHandler(this.aprekinat_Click);
            // 
            // rezultats
            // 
            this.rezultats.Location = new System.Drawing.Point(628, 96);
            this.rezultats.Name = "rezultats";
            this.rezultats.Size = new System.Drawing.Size(142, 20);
            this.rezultats.TabIndex = 3;
            this.rezultats.TextChanged += new System.EventHandler(this.rezultats_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightYellow;
            this.label2.Location = new System.Drawing.Point(284, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "seit ievadi savu budzetu maza";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightYellow;
            this.label3.Location = new System.Drawing.Point(646, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "sitik kg tev sanak skaistulit";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.BackgroundImage = global::JK_saldumi_31_01.Properties.Resources.sour_gummies_520909_hero_1_6171c1c70c164b3eb95a3fc99938c72d;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rezultats);
            this.Controls.Add(this.aprekinat);
            this.Controls.Add(this.naudas_ievade);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox naudas_ievade;
        private System.Windows.Forms.Button aprekinat;
        private System.Windows.Forms.TextBox rezultats;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

