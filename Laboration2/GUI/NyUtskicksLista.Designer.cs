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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SparaBtn = new System.Windows.Forms.Button();
            this.TillbakaBtn = new System.Windows.Forms.Button();
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
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(107, 38);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(328, 253);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
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
            this.SparaBtn.Location = new System.Drawing.Point(360, 297);
            this.SparaBtn.Name = "SparaBtn";
            this.SparaBtn.Size = new System.Drawing.Size(75, 23);
            this.SparaBtn.TabIndex = 4;
            this.SparaBtn.Text = "Spara";
            this.SparaBtn.UseVisualStyleBackColor = true;
            // 
            // TillbakaBtn
            // 
            this.TillbakaBtn.Location = new System.Drawing.Point(15, 297);
            this.TillbakaBtn.Name = "TillbakaBtn";
            this.TillbakaBtn.Size = new System.Drawing.Size(75, 23);
            this.TillbakaBtn.TabIndex = 5;
            this.TillbakaBtn.Text = "Tillbaka";
            this.TillbakaBtn.UseVisualStyleBackColor = true;
            this.TillbakaBtn.Click += new System.EventHandler(this.TillbakaBtn_Click);
            // 
            // NyUtskicksLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 334);
            this.Controls.Add(this.TillbakaBtn);
            this.Controls.Add(this.SparaBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBox1);
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
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SparaBtn;
        private System.Windows.Forms.Button TillbakaBtn;
    }
}