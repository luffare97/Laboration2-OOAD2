namespace GUI
{
    partial class RaderaKonto
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
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Lösen1 = new System.Windows.Forms.TextBox();
            this.Lösen2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TillbakaBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Om du vill radera ditt konto skriv in ditt lösenord och tryck radera";
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(256, 106);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(89, 23);
            this.DeleteBtn.TabIndex = 1;
            this.DeleteBtn.Text = "Radera kontot";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lösenord: ";
            // 
            // Lösen1
            // 
            this.Lösen1.Location = new System.Drawing.Point(138, 41);
            this.Lösen1.Name = "Lösen1";
            this.Lösen1.Size = new System.Drawing.Size(207, 20);
            this.Lösen1.TabIndex = 3;
            // 
            // Lösen2
            // 
            this.Lösen2.Location = new System.Drawing.Point(138, 67);
            this.Lösen2.Name = "Lösen2";
            this.Lösen2.Size = new System.Drawing.Size(207, 20);
            this.Lösen2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Upprepa lösenord: ";
            // 
            // TillbakaBtn
            // 
            this.TillbakaBtn.Location = new System.Drawing.Point(12, 106);
            this.TillbakaBtn.Name = "TillbakaBtn";
            this.TillbakaBtn.Size = new System.Drawing.Size(75, 23);
            this.TillbakaBtn.TabIndex = 6;
            this.TillbakaBtn.Text = "Tillbaka";
            this.TillbakaBtn.UseVisualStyleBackColor = true;
            this.TillbakaBtn.Click += new System.EventHandler(this.TillbakaBtn_Click);
            // 
            // RaderaKonto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 147);
            this.Controls.Add(this.TillbakaBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Lösen2);
            this.Controls.Add(this.Lösen1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.label1);
            this.Name = "RaderaKonto";
            this.Text = "RaderaKonto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Lösen1;
        private System.Windows.Forms.TextBox Lösen2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button TillbakaBtn;
    }
}