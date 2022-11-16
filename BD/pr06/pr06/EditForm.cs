using MySqlX.XDevAPI.Relational;
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
    public partial class EditForm : Form
    {
        private MySqlConnecter MySqlConnecter;
        private DataGridViewRow _currentRow;
        public EditForm()
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

        private void tabControlAdd_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tableName = "";
            switch (tabControlAdd.SelectedIndex)
            {
                case 0: tableName = "courses";break;
                case 1: tableName = "lecturers"; break;
                case 2: tableName = "klients"; break;
                case 3: tableName = "studyrooms"; break;
                default:
                    break;
            }
            dataGridView.DataSource = MySqlConnecter.QueryReturnTable(tableName);
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            tabControlAdd_SelectedIndexChanged(sender, e);
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _currentRow = dataGridView.Rows[dataGridView.CurrentCell.RowIndex];
            _currentRow.Selected = true;
            switch (tabControlAdd.SelectedIndex)
            {
                case 0: GetDataFromTableCourses(); break;
                case 1: GetDataFromTableLecturers(); break;
                case 2: GetDataFromTableKlients(); break;
                case 3: GetDataFromTableStudyRooms(); break;
                default:
                    break;
            }
        }
        private void GetDataFromTableCourses()
        {
            textBoxChangeCourseName.Text = _currentRow.Cells["CourseName"].Value.ToString();
            comboBoxChangeSelectLecturer.Text = _currentRow.Cells["LecturerID"].Value.ToString();
            comboBoxChangeSelectStudyRoom.Text = _currentRow.Cells["StudyRoomID"].Value.ToString();
        }
        private void GetDataFromTableLecturers()
        {
            textBoxChangeLectureName.Text = _currentRow.Cells["FullName"].Value.ToString();
            textBoxChangeLectureEdic.Text = _currentRow.Cells["Education"].Value.ToString();
            textBoxChangeLectureSpec.Text = _currentRow.Cells["CourseSpec"].Value.ToString();
        }
        private void GetDataFromTableKlients()
        {
            textBoxChangeKlientName.Text = _currentRow.Cells["FullName"].Value.ToString();
            DatePickerChangeKlientDOB.Text = _currentRow.Cells["DOB"].Value.ToString();
            if(_currentRow.Cells["Gender"].Value.ToString() == "муж")
                radioButtonChangeGenderMan.Select();
            else radioButtonChangeGenderWoman.Select();
        }
        private void GetDataFromTableStudyRooms()
        {
            textBoxChangeStudyRoomsCity.Text = _currentRow.Cells["City"].Value.ToString();
            textBoxChangeStudyRoomsStreet.Text = _currentRow.Cells["Street"].Value.ToString();
            textBoxChangeStudyRoomsStructure.Text = _currentRow.Cells["Structure"].Value.ToString();
            textBoxChangeStudyRoomsCabinet.Text = _currentRow.Cells["Cabinet"].Value.ToString();
        }
    }
}
