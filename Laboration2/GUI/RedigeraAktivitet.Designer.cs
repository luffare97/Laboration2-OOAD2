namespace GUI
{
    partial class RedigeraAktivitet
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
            this.SparaBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TitelTxt = new System.Windows.Forms.TextBox();
            this.TidTxt = new System.Windows.Forms.TextBox();
            this.PlatserField = new System.Windows.Forms.NumericUpDown();
            this.DatumDateTime = new System.Windows.Forms.DateTimePicker();
            this.PlatsTxt = new System.Windows.Forms.TextBox();
            this.BeskrivningBox = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.IDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PlatserField)).BeginInit();
            this.SuspendLayout();
            // 
            // TillbakaBtn
            // 
            this.TillbakaBtn.Location = new System.Drawing.Point(12, 340);
            this.TillbakaBtn.Name = "TillbakaBtn";
            this.TillbakaBtn.Size = new System.Drawing.Size(75, 23);
            this.TillbakaBtn.TabIndex = 0;
            this.TillbakaBtn.Text = "Tillbaka";
            this.TillbakaBtn.UseVisualStyleBackColor = true;
            this.TillbakaBtn.Click += new System.EventHandler(this.TillbakaBtn_Click);
            // 
            // SparaBtn
            // 
            this.SparaBtn.Location = new System.Drawing.Point(254, 340);
            this.SparaBtn.Name = "SparaBtn";
            this.SparaBtn.Size = new System.Drawing.Size(75, 23);
            this.SparaBtn.TabIndex = 1;
            this.SparaBtn.Text = "Spara";
            this.SparaBtn.UseVisualStyleBackColor = true;
            this.SparaBtn.Click += new System.EventHandler(this.SparaBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Titel: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Antal platser:";
            // 
            // TitelTxt
            // 
            this.TitelTxt.Location = new System.Drawing.Point(129, 25);
            this.TitelTxt.Name = "TitelTxt";
            this.TitelTxt.Size = new System.Drawing.Size(200, 20);
            this.TitelTxt.TabIndex = 4;
            // 
            // TidTxt
            // 
            this.TidTxt.Location = new System.Drawing.Point(129, 103);
            this.TidTxt.Name = "TidTxt";
            this.TidTxt.Size = new System.Drawing.Size(200, 20);
            this.TidTxt.TabIndex = 5;
            // 
            // PlatserField
            // 
            this.PlatserField.Location = new System.Drawing.Point(129, 51);
            this.PlatserField.Name = "PlatserField";
            this.PlatserField.Size = new System.Drawing.Size(200, 20);
            this.PlatserField.TabIndex = 6;
            // 
            // DatumDateTime
            // 
            this.DatumDateTime.Location = new System.Drawing.Point(129, 77);
            this.DatumDateTime.Name = "DatumDateTime";
            this.DatumDateTime.Size = new System.Drawing.Size(200, 20);
            this.DatumDateTime.TabIndex = 7;
            // 
            // PlatsTxt
            // 
            this.PlatsTxt.Location = new System.Drawing.Point(129, 129);
            this.PlatsTxt.Name = "PlatsTxt";
            this.PlatsTxt.Size = new System.Drawing.Size(200, 20);
            this.PlatsTxt.TabIndex = 8;
            // 
            // BeskrivningBox
            // 
            this.BeskrivningBox.Location = new System.Drawing.Point(129, 155);
            this.BeskrivningBox.Name = "BeskrivningBox";
            this.BeskrivningBox.Size = new System.Drawing.Size(200, 179);
            this.BeskrivningBox.TabIndex = 9;
            this.BeskrivningBox.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Datum:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Tidsram:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Plats:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Beskrivning:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "ID:";
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Location = new System.Drawing.Point(126, 9);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(18, 13);
            this.IDLabel.TabIndex = 15;
            this.IDLabel.Text = "ID";
            // 
            // RedigeraAktivitet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 375);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BeskrivningBox);
            this.Controls.Add(this.PlatsTxt);
            this.Controls.Add(this.DatumDateTime);
            this.Controls.Add(this.PlatserField);
            this.Controls.Add(this.TidTxt);
            this.Controls.Add(this.TitelTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SparaBtn);
            this.Controls.Add(this.TillbakaBtn);
            this.Name = "RedigeraAktivitet";
            this.Text = "Redigera aktivitet";
            ((System.ComponentModel.ISupportInitialize)(this.PlatserField)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TillbakaBtn;
        private System.Windows.Forms.Button SparaBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TitelTxt;
        private System.Windows.Forms.TextBox TidTxt;
        private System.Windows.Forms.NumericUpDown PlatserField;
        private System.Windows.Forms.DateTimePicker DatumDateTime;
        private System.Windows.Forms.TextBox PlatsTxt;
        private System.Windows.Forms.RichTextBox BeskrivningBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label IDLabel;
    }
}