namespace GUI
{
    partial class NyAktivitet
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TillbakaBtn = new System.Windows.Forms.Button();
            this.SparaBtn = new System.Windows.Forms.Button();
            this.TitelTxt = new System.Windows.Forms.TextBox();
            this.PlatserField = new System.Windows.Forms.NumericUpDown();
            this.StartDateTime = new System.Windows.Forms.DateTimePicker();
            this.PlatsTxt = new System.Windows.Forms.TextBox();
            this.BeskrivningTxt = new System.Windows.Forms.RichTextBox();
            this.TidTxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PlatserField)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titel på aktiviteten:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Antal platser:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Datum:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tidsram:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Plats:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Beskrivning:";
            // 
            // TillbakaBtn
            // 
            this.TillbakaBtn.Location = new System.Drawing.Point(15, 297);
            this.TillbakaBtn.Name = "TillbakaBtn";
            this.TillbakaBtn.Size = new System.Drawing.Size(75, 23);
            this.TillbakaBtn.TabIndex = 6;
            this.TillbakaBtn.Text = "Tillbaka";
            this.TillbakaBtn.UseVisualStyleBackColor = true;
            this.TillbakaBtn.Click += new System.EventHandler(this.TillbakaBtn_Click);
            // 
            // SparaBtn
            // 
            this.SparaBtn.Location = new System.Drawing.Point(250, 297);
            this.SparaBtn.Name = "SparaBtn";
            this.SparaBtn.Size = new System.Drawing.Size(75, 23);
            this.SparaBtn.TabIndex = 7;
            this.SparaBtn.Text = "Spara";
            this.SparaBtn.UseVisualStyleBackColor = true;
            this.SparaBtn.Click += new System.EventHandler(this.SparaBtn_Click);
            // 
            // TitelTxt
            // 
            this.TitelTxt.Location = new System.Drawing.Point(125, 12);
            this.TitelTxt.Name = "TitelTxt";
            this.TitelTxt.Size = new System.Drawing.Size(200, 20);
            this.TitelTxt.TabIndex = 8;
            // 
            // PlatserField
            // 
            this.PlatserField.Location = new System.Drawing.Point(125, 38);
            this.PlatserField.Name = "PlatserField";
            this.PlatserField.Size = new System.Drawing.Size(200, 20);
            this.PlatserField.TabIndex = 9;
            // 
            // StartDateTime
            // 
            this.StartDateTime.Location = new System.Drawing.Point(125, 64);
            this.StartDateTime.Name = "StartDateTime";
            this.StartDateTime.Size = new System.Drawing.Size(200, 20);
            this.StartDateTime.TabIndex = 10;
            // 
            // PlatsTxt
            // 
            this.PlatsTxt.Location = new System.Drawing.Point(125, 116);
            this.PlatsTxt.Name = "PlatsTxt";
            this.PlatsTxt.Size = new System.Drawing.Size(200, 20);
            this.PlatsTxt.TabIndex = 12;
            // 
            // BeskrivningTxt
            // 
            this.BeskrivningTxt.Location = new System.Drawing.Point(125, 142);
            this.BeskrivningTxt.Name = "BeskrivningTxt";
            this.BeskrivningTxt.Size = new System.Drawing.Size(200, 149);
            this.BeskrivningTxt.TabIndex = 13;
            this.BeskrivningTxt.Text = "";
            // 
            // TidTxt
            // 
            this.TidTxt.Location = new System.Drawing.Point(125, 90);
            this.TidTxt.Name = "TidTxt";
            this.TidTxt.Size = new System.Drawing.Size(200, 20);
            this.TidTxt.TabIndex = 14;
            // 
            // NyAktivitet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 331);
            this.Controls.Add(this.TidTxt);
            this.Controls.Add(this.BeskrivningTxt);
            this.Controls.Add(this.PlatsTxt);
            this.Controls.Add(this.StartDateTime);
            this.Controls.Add(this.PlatserField);
            this.Controls.Add(this.TitelTxt);
            this.Controls.Add(this.SparaBtn);
            this.Controls.Add(this.TillbakaBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NyAktivitet";
            this.Text = "Ny aktivitet";
            ((System.ComponentModel.ISupportInitialize)(this.PlatserField)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button TillbakaBtn;
        private System.Windows.Forms.Button SparaBtn;
        private System.Windows.Forms.TextBox TitelTxt;
        private System.Windows.Forms.NumericUpDown PlatserField;
        private System.Windows.Forms.DateTimePicker StartDateTime;
        private System.Windows.Forms.TextBox PlatsTxt;
        private System.Windows.Forms.RichTextBox BeskrivningTxt;
        private System.Windows.Forms.TextBox TidTxt;
    }
}