﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void history_button_Click(object sender, EventArgs e)
        {
            History hist1 = new History();
            this.Hide();
            hist1.ShowDialog();
            this.Close();
        }
    }
}
