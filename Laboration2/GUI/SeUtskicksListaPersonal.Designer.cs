namespace GUI
{
    partial class SeUtskicksListaPersonal
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
            this.TillbakaBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.IDTxt = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TitelTxt = new System.Windows.Forms.Label();
            this.MeddelandeBox = new System.Windows.Forms.RichTextBox();
            this.RedigeraBtn = new System.Windows.Forms.Button();
            this.MottagareLB = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // TillbakaBtn
            // 
            this.TillbakaBtn.Location = new System.Drawing.Point(12, 321);
            this.TillbakaBtn.Name = "TillbakaBtn";
            this.TillbakaBtn.Size = new System.Drawing.Size(75, 23);
            this.TillbakaBtn.TabIndex = 2;
            this.TillbakaBtn.Text = "Tillbaka";
            this.TillbakaBtn.UseVisualStyleBackColor = true;
            this.TillbakaBtn.Click += new System.EventHandler(this.TillbakaBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Titel:";
            // 
            // IDTxt
            // 
            this.IDTxt.AutoSize = true;
            this.IDTxt.Location = new System.Drawing.Point(99, 17);
            this.IDTxt.Name = "IDTxt";
            this.IDTxt.Size = new System.Drawing.Size(18, 13);
            this.IDTxt.TabIndex = 4;
            this.IDTxt.Text = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Meddelande: ";
            // 
            // TitelTxt
            // 
            this.TitelTxt.AutoSize = true;
            this.TitelTxt.Location = new System.Drawing.Point(99, 46);
            this.TitelTxt.Name = "TitelTxt";
            this.TitelTxt.Size = new System.Drawing.Size(27, 13);
            this.TitelTxt.TabIndex = 6;
            this.TitelTxt.Text = "Titel";
            // 
            // MeddelandeBox
            // 
            this.MeddelandeBox.Location = new System.Drawing.Point(102, 75);
            this.MeddelandeBox.Name = "MeddelandeBox";
            this.MeddelandeBox.ReadOnly = true;
            this.MeddelandeBox.Size = new System.Drawing.Size(249, 243);
            this.MeddelandeBox.TabIndex = 7;
            this.MeddelandeBox.Text = "";
            // 
            // RedigeraBtn
            // 
            this.RedigeraBtn.Location = new System.Drawing.Point(276, 321);
            this.RedigeraBtn.Name = "RedigeraBtn";
            this.RedigeraBtn.Size = new System.Drawing.Size(75, 23);
            this.RedigeraBtn.TabIndex = 8;
            this.RedigeraBtn.Text = "Redigera";
            this.RedigeraBtn.UseVisualStyleBackColor = true;
            this.RedigeraBtn.Click += new System.EventHandler(this.RedigeraBtn_Click);
            // 
            // MottagareLB
            // 
            this.MottagareLB.FormattingEnabled = true;
            this.MottagareLB.Location = new System.Drawing.Point(357, 41);
            this.MottagareLB.Name = "MottagareLB";
            this.MottagareLB.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.MottagareLB.Size = new System.Drawing.Size(210, 277);
            this.MottagareLB.TabIndex = 9;
            this.MottagareLB.SelectedIndexChanged += new System.EventHandler(this.MottagareLB_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(354, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Mottagare: ";
            // 
            // SeUtskicksListaPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 359);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MottagareLB);
            this.Controls.Add(this.RedigeraBtn);
            this.Controls.Add(this.MeddelandeBox);
            this.Controls.Add(this.TitelTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.IDTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TillbakaBtn);
            this.Controls.Add(this.label1);
            this.Name = "SeUtskicksListaPersonal";
            this.Text = "Specifik lista";
            this.Load += new System.EventHandler(this.SeUtskicksListaPersonal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button TillbakaBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label IDTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label TitelTxt;
        private System.Windows.Forms.RichTextBox MeddelandeBox;
        private System.Windows.Forms.Button RedigeraBtn;
        private System.Windows.Forms.ListBox MottagareLB;
        private System.Windows.Forms.Label label3;
    }
}