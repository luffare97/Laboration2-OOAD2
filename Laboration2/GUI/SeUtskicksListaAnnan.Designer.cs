namespace GUI
{
    partial class SeUtskicksListaAnnan
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
            this.ID = new System.Windows.Forms.Label();
            this.TillbakaBtn = new System.Windows.Forms.Button();
            this.SlutaFölja = new System.Windows.Forms.Button();
            this.Titel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.IDTxt = new System.Windows.Forms.Label();
            this.TitelTxt = new System.Windows.Forms.Label();
            this.MeddelandBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(12, 17);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(21, 13);
            this.ID.TabIndex = 0;
            this.ID.Text = "ID:";
            // 
            // TillbakaBtn
            // 
            this.TillbakaBtn.Location = new System.Drawing.Point(12, 325);
            this.TillbakaBtn.Name = "TillbakaBtn";
            this.TillbakaBtn.Size = new System.Drawing.Size(75, 23);
            this.TillbakaBtn.TabIndex = 1;
            this.TillbakaBtn.Text = "Tillbaka";
            this.TillbakaBtn.UseVisualStyleBackColor = true;
            // 
            // SlutaFölja
            // 
            this.SlutaFölja.Location = new System.Drawing.Point(271, 325);
            this.SlutaFölja.Name = "SlutaFölja";
            this.SlutaFölja.Size = new System.Drawing.Size(75, 23);
            this.SlutaFölja.TabIndex = 2;
            this.SlutaFölja.Text = "Sluta följa";
            this.SlutaFölja.UseVisualStyleBackColor = true;
            // 
            // Titel
            // 
            this.Titel.AutoSize = true;
            this.Titel.Location = new System.Drawing.Point(12, 46);
            this.Titel.Name = "Titel";
            this.Titel.Size = new System.Drawing.Size(33, 13);
            this.Titel.TabIndex = 3;
            this.Titel.Text = "Titel: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Meddelande:";
            // 
            // IDTxt
            // 
            this.IDTxt.AutoSize = true;
            this.IDTxt.Location = new System.Drawing.Point(98, 17);
            this.IDTxt.Name = "IDTxt";
            this.IDTxt.Size = new System.Drawing.Size(18, 13);
            this.IDTxt.TabIndex = 5;
            this.IDTxt.Text = "ID";
            // 
            // TitelTxt
            // 
            this.TitelTxt.AutoSize = true;
            this.TitelTxt.Location = new System.Drawing.Point(98, 46);
            this.TitelTxt.Name = "TitelTxt";
            this.TitelTxt.Size = new System.Drawing.Size(27, 13);
            this.TitelTxt.TabIndex = 6;
            this.TitelTxt.Text = "Titel";
            // 
            // MeddelandBox
            // 
            this.MeddelandBox.Location = new System.Drawing.Point(101, 72);
            this.MeddelandBox.Name = "MeddelandBox";
            this.MeddelandBox.Size = new System.Drawing.Size(245, 247);
            this.MeddelandBox.TabIndex = 7;
            this.MeddelandBox.Text = "";
            // 
            // SeUtskicksListaAnnan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 360);
            this.Controls.Add(this.MeddelandBox);
            this.Controls.Add(this.TitelTxt);
            this.Controls.Add(this.IDTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Titel);
            this.Controls.Add(this.SlutaFölja);
            this.Controls.Add(this.TillbakaBtn);
            this.Controls.Add(this.ID);
            this.Name = "SeUtskicksListaAnnan";
            this.Text = "Specifik lista";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Button TillbakaBtn;
        private System.Windows.Forms.Button SlutaFölja;
        private System.Windows.Forms.Label Titel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label IDTxt;
        private System.Windows.Forms.Label TitelTxt;
        private System.Windows.Forms.RichTextBox MeddelandBox;
    }
}