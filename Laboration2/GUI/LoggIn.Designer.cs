namespace GUI
{
    partial class LoggIn
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LösenordTxt = new System.Windows.Forms.TextBox();
            this.IDTxt = new System.Windows.Forms.TextBox();
            this.LoggaInBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RegistreraBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LösenordTxt);
            this.groupBox1.Controls.Add(this.IDTxt);
            this.groupBox1.Controls.Add(this.LoggaInBtn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 108);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Logga in";
            // 
            // LösenordTxt
            // 
            this.LösenordTxt.Location = new System.Drawing.Point(82, 45);
            this.LösenordTxt.Name = "LösenordTxt";
            this.LösenordTxt.Size = new System.Drawing.Size(193, 20);
            this.LösenordTxt.TabIndex = 4;
            // 
            // IDTxt
            // 
            this.IDTxt.Location = new System.Drawing.Point(82, 19);
            this.IDTxt.Name = "IDTxt";
            this.IDTxt.Size = new System.Drawing.Size(193, 20);
            this.IDTxt.TabIndex = 3;
            // 
            // LoggaInBtn
            // 
            this.LoggaInBtn.Location = new System.Drawing.Point(200, 71);
            this.LoggaInBtn.Name = "LoggaInBtn";
            this.LoggaInBtn.Size = new System.Drawing.Size(75, 23);
            this.LoggaInBtn.TabIndex = 2;
            this.LoggaInBtn.Text = "Logga in";
            this.LoggaInBtn.UseVisualStyleBackColor = true;
            this.LoggaInBtn.Click += new System.EventHandler(this.LoggaInBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lösenord:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Användar ID:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RegistreraBtn);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 126);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(292, 43);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // RegistreraBtn
            // 
            this.RegistreraBtn.Location = new System.Drawing.Point(200, 11);
            this.RegistreraBtn.Name = "RegistreraBtn";
            this.RegistreraBtn.Size = new System.Drawing.Size(75, 23);
            this.RegistreraBtn.TabIndex = 1;
            this.RegistreraBtn.Text = "Registrera dig";
            this.RegistreraBtn.UseVisualStyleBackColor = true;
            this.RegistreraBtn.Click += new System.EventHandler(this.RegistreraBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Eller registrera dig här:";
            // 
            // LoggIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 184);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "LoggIn";
            this.Text = "Logga in";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox LösenordTxt;
        private System.Windows.Forms.TextBox IDTxt;
        private System.Windows.Forms.Button LoggaInBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button RegistreraBtn;
        private System.Windows.Forms.Label label3;
    }
}

