namespace GUI
{
    partial class RedigeraProfilPersonal
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.GammaltLösenordTxt = new System.Windows.Forms.TextBox();
            this.NyttLösenordTxt = new System.Windows.Forms.TextBox();
            this.UpprepaTxt = new System.Windows.Forms.TextBox();
            this.SparaLösenordBtn = new System.Windows.Forms.Button();
            this.SparaInfoBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TillbakaBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SparaInfoBtn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 141);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personlig information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vad behöver vi här?";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.SparaLösenordBtn);
            this.groupBox2.Controls.Add(this.UpprepaTxt);
            this.groupBox2.Controls.Add(this.NyttLösenordTxt);
            this.groupBox2.Controls.Add(this.GammaltLösenordTxt);
            this.groupBox2.Location = new System.Drawing.Point(12, 159);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(275, 130);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lösenord";
            // 
            // GammaltLösenordTxt
            // 
            this.GammaltLösenordTxt.Location = new System.Drawing.Point(127, 19);
            this.GammaltLösenordTxt.Name = "GammaltLösenordTxt";
            this.GammaltLösenordTxt.Size = new System.Drawing.Size(132, 20);
            this.GammaltLösenordTxt.TabIndex = 0;
            // 
            // NyttLösenordTxt
            // 
            this.NyttLösenordTxt.Location = new System.Drawing.Point(127, 45);
            this.NyttLösenordTxt.Name = "NyttLösenordTxt";
            this.NyttLösenordTxt.Size = new System.Drawing.Size(132, 20);
            this.NyttLösenordTxt.TabIndex = 1;
            // 
            // UpprepaTxt
            // 
            this.UpprepaTxt.Location = new System.Drawing.Point(127, 71);
            this.UpprepaTxt.Name = "UpprepaTxt";
            this.UpprepaTxt.Size = new System.Drawing.Size(132, 20);
            this.UpprepaTxt.TabIndex = 2;
            // 
            // SparaLösenordBtn
            // 
            this.SparaLösenordBtn.Location = new System.Drawing.Point(184, 97);
            this.SparaLösenordBtn.Name = "SparaLösenordBtn";
            this.SparaLösenordBtn.Size = new System.Drawing.Size(75, 23);
            this.SparaLösenordBtn.TabIndex = 3;
            this.SparaLösenordBtn.Text = "Spara";
            this.SparaLösenordBtn.UseVisualStyleBackColor = true;
            // 
            // SparaInfoBtn
            // 
            this.SparaInfoBtn.Location = new System.Drawing.Point(184, 112);
            this.SparaInfoBtn.Name = "SparaInfoBtn";
            this.SparaInfoBtn.Size = new System.Drawing.Size(75, 23);
            this.SparaInfoBtn.TabIndex = 1;
            this.SparaInfoBtn.Text = "Spara";
            this.SparaInfoBtn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Gammalt lösenord:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nytt lösenord:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Upprepa lösenord:";
            // 
            // TillbakaBtn
            // 
            this.TillbakaBtn.Location = new System.Drawing.Point(196, 295);
            this.TillbakaBtn.Name = "TillbakaBtn";
            this.TillbakaBtn.Size = new System.Drawing.Size(75, 23);
            this.TillbakaBtn.TabIndex = 2;
            this.TillbakaBtn.Text = "Tillbaka";
            this.TillbakaBtn.UseVisualStyleBackColor = true;
            // 
            // RedigeraProfilPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 331);
            this.Controls.Add(this.TillbakaBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "RedigeraProfilPersonal";
            this.Text = "Redigera profil";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button SparaInfoBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SparaLösenordBtn;
        private System.Windows.Forms.TextBox UpprepaTxt;
        private System.Windows.Forms.TextBox NyttLösenordTxt;
        private System.Windows.Forms.TextBox GammaltLösenordTxt;
        private System.Windows.Forms.Button TillbakaBtn;
    }
}