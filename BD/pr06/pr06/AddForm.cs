﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr06
{
    public partial class AddForm : Form
    {
        MySqlConnecter MySqlConnecter;
        public AddForm()
        {
            InitializeComponent();
            const string connectionString = "host='localhost';database='mydb';uid='root';pwd='';";
            MySqlConnecter = new MySqlConnecter(connectionString);
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm form = new MainForm();
            form.Show();
        }
    }
}
