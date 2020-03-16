namespace GUI
{
    partial class GDPR
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GodkännBox = new System.Windows.Forms.CheckBox();
            this.NejBtn = new System.Windows.Forms.Button();
            this.JaBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 41);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(386, 320);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "Här står det en massa GDPR saker som du måste godkänna för att få skapa ett konto" +
    "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "För att skapa ett konto måste du läsa och godkänna nedanstående:";
            // 
            // GodkännBox
            // 
            this.GodkännBox.AutoSize = true;
            this.GodkännBox.Location = new System.Drawing.Point(12, 367);
            this.GodkännBox.Name = "GodkännBox";
            this.GodkännBox.Size = new System.Drawing.Size(133, 17);
            this.GodkännBox.TabIndex = 2;
            this.GodkännBox.Text = "Jag har läst och förstår";
            this.GodkännBox.UseVisualStyleBackColor = true;
            this.GodkännBox.CheckedChanged += new System.EventHandler(this.GodkännBox_CheckedChanged);
            // 
            // NejBtn
            // 
            this.NejBtn.Location = new System.Drawing.Point(12, 390);
            this.NejBtn.Name = "NejBtn";
            this.NejBtn.Size = new System.Drawing.Size(97, 23);
            this.NejBtn.TabIndex = 3;
            this.NejBtn.Text = "Godkänner inte";
            this.NejBtn.UseVisualStyleBackColor = true;
            this.NejBtn.Click += new System.EventHandler(this.NejBtn_Click);
            // 
            // JaBtn
            // 
            this.JaBtn.Location = new System.Drawing.Point(324, 390);
            this.JaBtn.Name = "JaBtn";
            this.JaBtn.Size = new System.Drawing.Size(75, 23);
            this.JaBtn.TabIndex = 4;
            this.JaBtn.Text = "Godkänner";
            this.JaBtn.UseVisualStyleBackColor = true;
            this.JaBtn.Click += new System.EventHandler(this.JaBtn_Click);
            // 
            // GDPR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 423);
            this.Controls.Add(this.JaBtn);
            this.Controls.Add(this.NejBtn);
            this.Controls.Add(this.GodkännBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "GDPR";
            this.Text = "GDPR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox GodkännBox;
        private System.Windows.Forms.Button NejBtn;
        private System.Windows.Forms.Button JaBtn;
    }
}