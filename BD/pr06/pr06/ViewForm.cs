using System;
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
    public partial class ViewForm : Form
    {
        private MySqlConnecter MySqlConnecter;
        public ViewForm()
        {
            InitializeComponent();
            const string connectionString = "host='localhost';database='mydb';uid='root';pwd='';charset=utf8;";
            MySqlConnecter = new MySqlConnecter(connectionString);
        }

        private void ViewForm_Load(object sender, EventArgs e)
        {
            coursesToolStripMenuItem_Click(sender, e);
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm form = new MainForm();
            form.Show();
        }

        private void coursesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string tableName = "courses";
            dataGridView.DataSource =  MySqlConnecter.QueryReturnTable(tableName);
        }

        private void lecturesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string tableName = "lecturers";
            dataGridView.DataSource = MySqlConnecter.QueryReturnTable(tableName);
        }

        private void clientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string tableName = "klients";
            dataGridView.DataSource = MySqlConnecter.QueryReturnTable(tableName);
        }

        private void studyRoomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string tableName = "studyrooms";
            dataGridView.DataSource = MySqlConnecter.QueryReturnTable(tableName);
        }
    }
}
