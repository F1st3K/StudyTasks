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
            const string connectionString = "host='localhost';database='mydb';uid='root';pwd='';";
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
            string query = "SELECT * FROM courses;";
            try
            {
                GridViewForView.DataSource =  MySqlConnecter.ReturnQueryTable(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Внимание!\n" + query + " - некоректный запрос!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void lecturesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM lecturers;";
            try
            {
                GridViewForView.DataSource = MySqlConnecter.ReturnQueryTable(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Внимание!\n" + query + " - некоректный запрос!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void clientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM klients;";
            try
            {
                GridViewForView.DataSource = MySqlConnecter.ReturnQueryTable(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Внимание!\n" + query + " - некоректный запрос!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void studyRoomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM studyrooms;";
            try
            {
                GridViewForView.DataSource = MySqlConnecter.ReturnQueryTable(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Внимание!\n" + query + " - некоректный запрос!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
    }
}
