namespace GUI
{
    partial class SeAktivitetPersonal
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
            this.TillbakaBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.IDLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TitelLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PlatserLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.DatumLabel = new System.Windows.Forms.Label();
            this.TidLabel = new System.Windows.Forms.Label();
            this.PlatsLabel = new System.Windows.Forms.Label();
            this.BeskrivningBox = new System.Windows.Forms.RichTextBox();
            this.RedigeraBtn = new System.Windows.Forms.Button();
            this.DeltagareLB = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TillbakaBtn
            // 
            this.TillbakaBtn.Location = new System.Drawing.Point(12, 425);
            this.TillbakaBtn.Name = "TillbakaBtn";
            this.TillbakaBtn.Size = new System.Drawing.Size(75, 23);
            this.TillbakaBtn.TabIndex = 0;
            this.TillbakaBtn.Text = "Tillbaka";
            this.TillbakaBtn.UseVisualStyleBackColor = true;
            this.TillbakaBtn.Click += new System.EventHandler(this.TillbakaBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Aktivitets ID:";
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Location = new System.Drawing.Point(99, 17);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(18, 13);
            this.IDLabel.TabIndex = 3;
            this.IDLabel.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Titel: ";
            // 
            // TitelLabel
            // 
            this.TitelLabel.AutoSize = true;
            this.TitelLabel.Location = new System.Drawing.Point(99, 46);
            this.TitelLabel.Name = "TitelLabel";
            this.TitelLabel.Size = new System.Drawing.Size(23, 13);
            this.TitelLabel.TabIndex = 5;
            this.TitelLabel.Text = "titel";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Antal platser:";
            // 
            // PlatserLabel
            // 
            this.PlatserLabel.AutoSize = true;
            this.PlatserLabel.Location = new System.Drawing.Point(99, 75);
            this.PlatserLabel.Name = "PlatserLabel";
            this.PlatserLabel.Size = new System.Drawing.Size(38, 13);
            this.PlatserLabel.TabIndex = 7;
            this.PlatserLabel.Text = "platser";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Datum: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Tid:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 162);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Plats: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 191);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Beskrivning: ";
            // 
            // DatumLabel
            // 
            this.DatumLabel.AutoSize = true;
            this.DatumLabel.Location = new System.Drawing.Point(99, 104);
            this.DatumLabel.Name = "DatumLabel";
            this.DatumLabel.Size = new System.Drawing.Size(36, 13);
            this.DatumLabel.TabIndex = 12;
            this.DatumLabel.Text = "datum";
            // 
            // TidLabel
            // 
            this.TidLabel.AutoSize = true;
            this.TidLabel.Location = new System.Drawing.Point(99, 133);
            this.TidLabel.Name = "TidLabel";
            this.TidLabel.Size = new System.Drawing.Size(18, 13);
            this.TidLabel.TabIndex = 13;
            this.TidLabel.Text = "tid";
            // 
            // PlatsLabel
            // 
            this.PlatsLabel.AutoSize = true;
            this.PlatsLabel.Location = new System.Drawing.Point(99, 162);
            this.PlatsLabel.Name = "PlatsLabel";
            this.PlatsLabel.Size = new System.Drawing.Size(29, 13);
            this.PlatsLabel.TabIndex = 14;
            this.PlatsLabel.Text = "plats";
            // 
            // BeskrivningBox
            // 
            this.BeskrivningBox.Location = new System.Drawing.Point(102, 191);
            this.BeskrivningBox.Name = "BeskrivningBox";
            this.BeskrivningBox.ReadOnly = true;
            this.BeskrivningBox.Size = new System.Drawing.Size(227, 228);
            this.BeskrivningBox.TabIndex = 15;
            this.BeskrivningBox.Text = "";
            // 
            // RedigeraBtn
            // 
            this.RedigeraBtn.Location = new System.Drawing.Point(254, 425);
            this.RedigeraBtn.Name = "RedigeraBtn";
            this.RedigeraBtn.Size = new System.Drawing.Size(75, 23);
            this.RedigeraBtn.TabIndex = 16;
            this.RedigeraBtn.Text = "Redigera";
            this.RedigeraBtn.UseVisualStyleBackColor = true;
            this.RedigeraBtn.Click += new System.EventHandler(this.RedigeraBtn_Click);
            // 
            // DeltagareLB
            // 
            this.DeltagareLB.FormattingEnabled = true;
            this.DeltagareLB.Location = new System.Drawing.Point(335, 38);
            this.DeltagareLB.Name = "DeltagareLB";
            this.DeltagareLB.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.DeltagareLB.Size = new System.Drawing.Size(220, 381);
            this.DeltagareLB.TabIndex = 17;
            this.DeltagareLB.SelectedIndexChanged += new System.EventHandler(this.MottagareLB_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(332, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Deltagare: ";
            // 
            // SeAktivitetPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 462);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DeltagareLB);
            this.Controls.Add(this.RedigeraBtn);
            this.Controls.Add(this.BeskrivningBox);
            this.Controls.Add(this.PlatsLabel);
            this.Controls.Add(this.TidLabel);
            this.Controls.Add(this.DatumLabel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.PlatserLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TitelLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TillbakaBtn);
            this.Name = "SeAktivitetPersonal";
            this.Text = "Specifik aktivitet";
            this.Load += new System.EventHandler(this.SeAktivitetPersonal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TillbakaBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label TitelLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label PlatserLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label DatumLabel;
        private System.Windows.Forms.Label TidLabel;
        private System.Windows.Forms.Label PlatsLabel;
        private System.Windows.Forms.RichTextBox BeskrivningBox;
        private System.Windows.Forms.Button RedigeraBtn;
        private System.Windows.Forms.ListBox DeltagareLB;
        private System.Windows.Forms.Label label2;
    }
}