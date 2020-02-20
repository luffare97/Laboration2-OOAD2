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
            this.InLoggadNamn = new System.Windows.Forms.Label();
            this.RedigeraProfilBtn = new System.Windows.Forms.Button();
            this.LoggaUtBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.UtskicksListaDataGrid = new System.Windows.Forms.DataGridView();
            this.VäljListaBtn = new System.Windows.Forms.Button();
            this.SkapaNyLista = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.AktivitetDataGridView = new System.Windows.Forms.DataGridView();
            this.SkapaAktivitetBtn = new System.Windows.Forms.Button();
            this.VäljaAktivitetBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UtskicksListaDataGrid)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AktivitetDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LoggaUtBtn);
            this.groupBox1.Controls.Add(this.RedigeraProfilBtn);
            this.groupBox1.Controls.Add(this.InLoggadNamn);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(102, 125);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Profil";
            // 
            // InLoggadNamn
            // 
            this.InLoggadNamn.AutoSize = true;
            this.InLoggadNamn.Location = new System.Drawing.Point(6, 22);
            this.InLoggadNamn.Name = "InLoggadNamn";
            this.InLoggadNamn.Size = new System.Drawing.Size(88, 13);
            this.InLoggadNamn.TabIndex = 0;
            this.InLoggadNamn.Text = "FNamn + ENamn";
            // 
            // RedigeraProfilBtn
            // 
            this.RedigeraProfilBtn.Location = new System.Drawing.Point(6, 60);
            this.RedigeraProfilBtn.Name = "RedigeraProfilBtn";
            this.RedigeraProfilBtn.Size = new System.Drawing.Size(88, 23);
            this.RedigeraProfilBtn.TabIndex = 1;
            this.RedigeraProfilBtn.Text = "Redigera profil";
            this.RedigeraProfilBtn.UseVisualStyleBackColor = true;
            // 
            // LoggaUtBtn
            // 
            this.LoggaUtBtn.Location = new System.Drawing.Point(6, 89);
            this.LoggaUtBtn.Name = "LoggaUtBtn";
            this.LoggaUtBtn.Size = new System.Drawing.Size(88, 23);
            this.LoggaUtBtn.TabIndex = 2;
            this.LoggaUtBtn.Text = "Logga ut";
            this.LoggaUtBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SkapaNyLista);
            this.groupBox2.Controls.Add(this.VäljListaBtn);
            this.groupBox2.Controls.Add(this.UtskicksListaDataGrid);
            this.groupBox2.Location = new System.Drawing.Point(120, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(241, 331);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Utskickslistor";
            // 
            // UtskicksListaDataGrid
            // 
            this.UtskicksListaDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UtskicksListaDataGrid.Location = new System.Drawing.Point(6, 19);
            this.UtskicksListaDataGrid.Name = "UtskicksListaDataGrid";
            this.UtskicksListaDataGrid.Size = new System.Drawing.Size(226, 273);
            this.UtskicksListaDataGrid.TabIndex = 0;
            // 
            // VäljListaBtn
            // 
            this.VäljListaBtn.Location = new System.Drawing.Point(157, 298);
            this.VäljListaBtn.Name = "VäljListaBtn";
            this.VäljListaBtn.Size = new System.Drawing.Size(75, 23);
            this.VäljListaBtn.TabIndex = 1;
            this.VäljListaBtn.Text = "Välj lista";
            this.VäljListaBtn.UseVisualStyleBackColor = true;
            // 
            // SkapaNyLista
            // 
            this.SkapaNyLista.Location = new System.Drawing.Point(6, 298);
            this.SkapaNyLista.Name = "SkapaNyLista";
            this.SkapaNyLista.Size = new System.Drawing.Size(75, 23);
            this.SkapaNyLista.TabIndex = 2;
            this.SkapaNyLista.Text = "Skapa lista";
            this.SkapaNyLista.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.VäljaAktivitetBtn);
            this.groupBox3.Controls.Add(this.SkapaAktivitetBtn);
            this.groupBox3.Controls.Add(this.AktivitetDataGridView);
            this.groupBox3.Location = new System.Drawing.Point(367, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(241, 331);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Aktiviteter";
            // 
            // AktivitetDataGridView
            // 
            this.AktivitetDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AktivitetDataGridView.Location = new System.Drawing.Point(6, 19);
            this.AktivitetDataGridView.Name = "AktivitetDataGridView";
            this.AktivitetDataGridView.Size = new System.Drawing.Size(229, 273);
            this.AktivitetDataGridView.TabIndex = 0;
            // 
            // SkapaAktivitetBtn
            // 
            this.SkapaAktivitetBtn.Location = new System.Drawing.Point(6, 298);
            this.SkapaAktivitetBtn.Name = "SkapaAktivitetBtn";
            this.SkapaAktivitetBtn.Size = new System.Drawing.Size(87, 23);
            this.SkapaAktivitetBtn.TabIndex = 1;
            this.SkapaAktivitetBtn.Text = "Skapa aktivitet";
            this.SkapaAktivitetBtn.UseVisualStyleBackColor = true;
            // 
            // VäljaAktivitetBtn
            // 
            this.VäljaAktivitetBtn.Location = new System.Drawing.Point(160, 298);
            this.VäljaAktivitetBtn.Name = "VäljaAktivitetBtn";
            this.VäljaAktivitetBtn.Size = new System.Drawing.Size(75, 23);
            this.VäljaAktivitetBtn.TabIndex = 2;
            this.VäljaAktivitetBtn.Text = "Välj aktivitet";
            this.VäljaAktivitetBtn.UseVisualStyleBackColor = true;
            // 
            // StartPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 371);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "StartPersonal";
            this.Text = "Start";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UtskicksListaDataGrid)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AktivitetDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button RedigeraProfilBtn;
        private System.Windows.Forms.Label InLoggadNamn;
        private System.Windows.Forms.Button LoggaUtBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView UtskicksListaDataGrid;
        private System.Windows.Forms.Button VäljListaBtn;
        private System.Windows.Forms.Button SkapaNyLista;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView AktivitetDataGridView;
        private System.Windows.Forms.Button VäljaAktivitetBtn;
        private System.Windows.Forms.Button SkapaAktivitetBtn;
    }
}