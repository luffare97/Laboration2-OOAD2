﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;

namespace GUI
{
    public partial class RedigeraProfilAnnan : Form
    {
        public RedigeraProfilAnnan(BusinessManager businessManager)
        {
            InitializeComponent();
        }

        private void TillbakaBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
