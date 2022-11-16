using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.Common;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace pr06
{
    public partial class MainForm : Form
    {
        
        public MainForm()
        {
            InitializeComponent();

            
        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewForm form = new ViewForm();
            form.Show();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddForm form = new AddForm();
            form.Show();
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditForm form = new EditForm();
            form.Show();
        }
    }
}
