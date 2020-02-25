namespace GUI
{
    partial class StartPersonal
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
            this.InLoggadPosition = new System.Windows.Forms.Label();
            this.LoggaUtBtn = new System.Windows.Forms.Button();
            this.RedigeraProfilBtn = new System.Windows.Forms.Button();
            this.InLoggadNamn = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SkapaNyLista = new System.Windows.Forms.Button();
            this.VäljListaBtn = new System.Windows.Forms.Button();
            this.dataGridListor = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.VäljaAktivitetBtn = new System.Windows.Forms.Button();
            this.SkapaAktivitetBtn = new System.Windows.Forms.Button();
            this.dataGridAktiviteter = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListor)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAktiviteter)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.InLoggadPosition);
            this.groupBox1.Controls.Add(this.LoggaUtBtn);
            this.groupBox1.Controls.Add(this.RedigeraProfilBtn);
            this.groupBox1.Controls.Add(this.InLoggadNamn);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(102, 144);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Profil";
            // 
            // InLoggadPosition
            // 
            this.InLoggadPosition.AutoSize = true;
            this.InLoggadPosition.Location = new System.Drawing.Point(8, 53);
            this.InLoggadPosition.Name = "InLoggadPosition";
            this.InLoggadPosition.Size = new System.Drawing.Size(49, 13);
            this.InLoggadPosition.TabIndex = 3;
            this.InLoggadPosition.Text = "Possition";
            // 
            // LoggaUtBtn
            // 
            this.LoggaUtBtn.Location = new System.Drawing.Point(6, 112);
            this.LoggaUtBtn.Name = "LoggaUtBtn";
            this.LoggaUtBtn.Size = new System.Drawing.Size(90, 23);
            this.LoggaUtBtn.TabIndex = 2;
            this.LoggaUtBtn.Text = "Logga ut";
            this.LoggaUtBtn.UseVisualStyleBackColor = true;
            this.LoggaUtBtn.Click += new System.EventHandler(this.LoggaUtBtn_Click);
            // 
            // RedigeraProfilBtn
            // 
            this.RedigeraProfilBtn.Location = new System.Drawing.Point(6, 83);
            this.RedigeraProfilBtn.Name = "RedigeraProfilBtn";
            this.RedigeraProfilBtn.Size = new System.Drawing.Size(90, 23);
            this.RedigeraProfilBtn.TabIndex = 1;
            this.RedigeraProfilBtn.Text = "Redigera profil";
            this.RedigeraProfilBtn.UseVisualStyleBackColor = true;
            // 
            // InLoggadNamn
            // 
            this.InLoggadNamn.AutoSize = true;
            this.InLoggadNamn.Location = new System.Drawing.Point(8, 24);
            this.InLoggadNamn.Name = "InLoggadNamn";
            this.InLoggadNamn.Size = new System.Drawing.Size(88, 13);
            this.InLoggadNamn.TabIndex = 0;
            this.InLoggadNamn.Text = "FNamn + ENamn";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SkapaNyLista);
            this.groupBox2.Controls.Add(this.VäljListaBtn);
            this.groupBox2.Controls.Add(this.dataGridListor);
            this.groupBox2.Location = new System.Drawing.Point(120, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(396, 482);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Utskickslistor";
            // 
            // SkapaNyLista
            // 
            this.SkapaNyLista.Location = new System.Drawing.Point(6, 453);
            this.SkapaNyLista.Name = "SkapaNyLista";
            this.SkapaNyLista.Size = new System.Drawing.Size(75, 23);
            this.SkapaNyLista.TabIndex = 2;
            this.SkapaNyLista.Text = "Skapa lista";
            this.SkapaNyLista.UseVisualStyleBackColor = true;
            // 
            // VäljListaBtn
            // 
            this.VäljListaBtn.Location = new System.Drawing.Point(315, 453);
            this.VäljListaBtn.Name = "VäljListaBtn";
            this.VäljListaBtn.Size = new System.Drawing.Size(75, 23);
            this.VäljListaBtn.TabIndex = 1;
            this.VäljListaBtn.Text = "Välj lista";
            this.VäljListaBtn.UseVisualStyleBackColor = true;
            this.VäljListaBtn.Click += new System.EventHandler(this.VäljListaBtn_Click);
            // 
            // dataGridListor
            // 
            this.dataGridListor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridListor.Location = new System.Drawing.Point(6, 19);
            this.dataGridListor.Name = "dataGridListor";
            this.dataGridListor.Size = new System.Drawing.Size(384, 428);
            this.dataGridListor.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.VäljaAktivitetBtn);
            this.groupBox3.Controls.Add(this.SkapaAktivitetBtn);
            this.groupBox3.Controls.Add(this.dataGridAktiviteter);
            this.groupBox3.Location = new System.Drawing.Point(522, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(396, 482);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Aktiviteter";
            // 
            // VäljaAktivitetBtn
            // 
            this.VäljaAktivitetBtn.Location = new System.Drawing.Point(315, 453);
            this.VäljaAktivitetBtn.Name = "VäljaAktivitetBtn";
            this.VäljaAktivitetBtn.Size = new System.Drawing.Size(75, 23);
            this.VäljaAktivitetBtn.TabIndex = 2;
            this.VäljaAktivitetBtn.Text = "Välj aktivitet";
            this.VäljaAktivitetBtn.UseVisualStyleBackColor = true;
            // 
            // SkapaAktivitetBtn
            // 
            this.SkapaAktivitetBtn.Location = new System.Drawing.Point(6, 453);
            this.SkapaAktivitetBtn.Name = "SkapaAktivitetBtn";
            this.SkapaAktivitetBtn.Size = new System.Drawing.Size(87, 23);
            this.SkapaAktivitetBtn.TabIndex = 1;
            this.SkapaAktivitetBtn.Text = "Skapa aktivitet";
            this.SkapaAktivitetBtn.UseVisualStyleBackColor = true;
            // 
            // dataGridAktiviteter
            // 
            this.dataGridAktiviteter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAktiviteter.Location = new System.Drawing.Point(6, 19);
            this.dataGridAktiviteter.Name = "dataGridAktiviteter";
            this.dataGridAktiviteter.Size = new System.Drawing.Size(384, 428);
            this.dataGridAktiviteter.TabIndex = 0;
            // 
            // StartPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 503);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "StartPersonal";
            this.Text = "Start";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListor)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAktiviteter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button RedigeraProfilBtn;
        private System.Windows.Forms.Label InLoggadNamn;
        private System.Windows.Forms.Button LoggaUtBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridListor;
        private System.Windows.Forms.Button VäljListaBtn;
        private System.Windows.Forms.Button SkapaNyLista;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridAktiviteter;
        private System.Windows.Forms.Button VäljaAktivitetBtn;
        private System.Windows.Forms.Button SkapaAktivitetBtn;
        private System.Windows.Forms.Label InLoggadPosition;
    }
}