using System;
using System.Collections;
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
    public partial class DelForm : Form
    {
        private MySqlConnecter MySqlConnecter;
        private DataGridViewRow currentRow;
        private string _tableName;
        public DelForm()
        {
            InitializeComponent();
            const string connectionString = "host='localhost';database='mydb';uid='root';pwd='';charset=utf8;";
            MySqlConnecter = new MySqlConnecter(connectionString);
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm form = new MainForm();
            form.Show();
        }

        private void coursesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _tableName = "courses";
            dataGridView.DataSource = MySqlConnecter.QueryReturnTable(_tableName);
        }

        private void lecturesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _tableName = "lecturers";
            dataGridView.DataSource = MySqlConnecter.QueryReturnTable(_tableName);
        }

        private void clientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _tableName = "klients";
            dataGridView.DataSource = MySqlConnecter.QueryReturnTable(_tableName);
        }

        private void studyRoomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _tableName = "studyrooms";
            dataGridView.DataSource = MySqlConnecter.QueryReturnTable(_tableName);
        }

        private void DelForm_Load(object sender, EventArgs e)
        {
            coursesToolStripMenuItem_Click(sender, e);
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            currentRow = dataGridView.Rows[dataGridView.CurrentCell.RowIndex];
            currentRow.Selected = true;
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView_CellClick(sender, e);
            string row = "";
            for (int i = 0; i < dataGridView.Columns.Count; i++) row += "\t" + currentRow.Cells[i].Value.ToString();
            DialogResult dialogResult = MessageBox.Show($"Вы действительно хотите удалить следующую запись?: \n{row}", "Внимание! УДАЛЕНИЕ!", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (dialogResult == DialogResult.Yes)
                DeleteRow();
        }
        private void DeleteRow()
        {
            string condition = $"{currentRow.Cells[0].OwningColumn.Name} = {currentRow.Cells[0].Value.ToString()}";
            MySqlConnecter.QueryDeleteInTable(_tableName, condition);
            UpadateGridView();
        }
        private void UpadateGridView()
        {
            dataGridView.DataSource = MySqlConnecter.QueryReturnTable(_tableName);
        }
    }
}
