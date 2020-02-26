namespace GUI
{
    partial class NyUtskicksLista
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
            this.TitelTxt = new System.Windows.Forms.TextBox();
            this.InfoTxt = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SparaBtn = new System.Windows.Forms.Button();
            this.TillbakaBtn = new System.Windows.Forms.Button();
            this.MottagareLB = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titel:";
            // 
            // TitelTxt
            // 
            this.TitelTxt.Location = new System.Drawing.Point(107, 12);
            this.TitelTxt.Name = "TitelTxt";
            this.TitelTxt.Size = new System.Drawing.Size(328, 20);
            this.TitelTxt.TabIndex = 1;
            // 
            // InfoTxt
            // 
            this.InfoTxt.Location = new System.Drawing.Point(107, 38);
            this.InfoTxt.Name = "InfoTxt";
            this.InfoTxt.Size = new System.Drawing.Size(328, 253);
            this.InfoTxt.TabIndex = 2;
            this.InfoTxt.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Meddelande:";
            // 
            // SparaBtn
            // 
            this.SparaBtn.Location = new System.Drawing.Point(615, 299);
            this.SparaBtn.Name = "SparaBtn";
            this.SparaBtn.Size = new System.Drawing.Size(75, 23);
            this.SparaBtn.TabIndex = 4;
            this.SparaBtn.Text = "Spara";
            this.SparaBtn.UseVisualStyleBackColor = true;
            this.SparaBtn.Click += new System.EventHandler(this.SparaBtn_Click);
            // 
            // TillbakaBtn
            // 
            this.TillbakaBtn.Location = new System.Drawing.Point(12, 299);
            this.TillbakaBtn.Name = "TillbakaBtn";
            this.TillbakaBtn.Size = new System.Drawing.Size(75, 23);
            this.TillbakaBtn.TabIndex = 5;
            this.TillbakaBtn.Text = "Tillbaka";
            this.TillbakaBtn.UseVisualStyleBackColor = true;
            this.TillbakaBtn.Click += new System.EventHandler(this.TillbakaBtn_Click);
            // 
            // MottagareLB
            // 
            this.MottagareLB.FormattingEnabled = true;
            this.MottagareLB.Location = new System.Drawing.Point(461, 38);
            this.MottagareLB.Name = "MottagareLB";
            this.MottagareLB.Size = new System.Drawing.Size(229, 251);
            this.MottagareLB.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(458, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mottagare:";
            // 
            // NyUtskicksLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 334);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MottagareLB);
            this.Controls.Add(this.TillbakaBtn);
            this.Controls.Add(this.SparaBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.InfoTxt);
            this.Controls.Add(this.TitelTxt);
            this.Controls.Add(this.label1);
            this.Name = "NyUtskicksLista";
            this.Text = "Ny utskickslista";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TitelTxt;
        private System.Windows.Forms.RichTextBox InfoTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SparaBtn;
        private System.Windows.Forms.Button TillbakaBtn;
        private System.Windows.Forms.ListBox MottagareLB;
        private System.Windows.Forms.Label label3;
    }
}