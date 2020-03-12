namespace GUI
{
    partial class RedigeraLista
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
            this.IDLabel = new System.Windows.Forms.Label();
            this.IDTxt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TitelTxt = new System.Windows.Forms.TextBox();
            this.MeddelandeBox = new System.Windows.Forms.RichTextBox();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TillbakaBtn
            // 
            this.TillbakaBtn.Location = new System.Drawing.Point(12, 293);
            this.TillbakaBtn.Name = "TillbakaBtn";
            this.TillbakaBtn.Size = new System.Drawing.Size(75, 23);
            this.TillbakaBtn.TabIndex = 0;
            this.TillbakaBtn.Text = "Tillbaka";
            this.TillbakaBtn.UseVisualStyleBackColor = true;
            this.TillbakaBtn.Click += new System.EventHandler(this.TillbakaBtn_Click);
            // 
            // SparaBtn
            // 
            this.SparaBtn.Location = new System.Drawing.Point(304, 293);
            this.SparaBtn.Name = "SparaBtn";
            this.SparaBtn.Size = new System.Drawing.Size(75, 23);
            this.SparaBtn.TabIndex = 1;
            this.SparaBtn.Text = "Spara";
            this.SparaBtn.UseVisualStyleBackColor = true;
            this.SparaBtn.Click += new System.EventHandler(this.SparaBtn_Click);
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Location = new System.Drawing.Point(12, 17);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(21, 13);
            this.IDLabel.TabIndex = 2;
            this.IDLabel.Text = "ID:";
            // 
            // IDTxt
            // 
            this.IDTxt.AutoSize = true;
            this.IDTxt.Location = new System.Drawing.Point(104, 17);
            this.IDTxt.Name = "IDTxt";
            this.IDTxt.Size = new System.Drawing.Size(18, 13);
            this.IDTxt.TabIndex = 3;
            this.IDTxt.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Meddelande: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Titel: ";
            // 
            // TitelTxt
            // 
            this.TitelTxt.Location = new System.Drawing.Point(107, 43);
            this.TitelTxt.Name = "TitelTxt";
            this.TitelTxt.Size = new System.Drawing.Size(272, 20);
            this.TitelTxt.TabIndex = 6;
            // 
            // MeddelandeBox
            // 
            this.MeddelandeBox.Location = new System.Drawing.Point(107, 72);
            this.MeddelandeBox.Name = "MeddelandeBox";
            this.MeddelandeBox.Size = new System.Drawing.Size(272, 215);
            this.MeddelandeBox.TabIndex = 7;
            this.MeddelandeBox.Text = "";
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(12, 169);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(75, 23);
            this.DeleteBtn.TabIndex = 8;
            this.DeleteBtn.Text = "Radera";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // RedigeraLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 331);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.MeddelandeBox);
            this.Controls.Add(this.TitelTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IDTxt);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.SparaBtn);
            this.Controls.Add(this.TillbakaBtn);
            this.Name = "RedigeraLista";
            this.Text = "Redigera lista";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TillbakaBtn;
        private System.Windows.Forms.Button SparaBtn;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Label IDTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TitelTxt;
        private System.Windows.Forms.RichTextBox MeddelandeBox;
        private System.Windows.Forms.Button DeleteBtn;
    }
}