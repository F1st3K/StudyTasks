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
            UpdateGridView();
        }

        private void UpdateGridView()
        {
            string tableName = "";
            switch (tabControlAdd.SelectedIndex)
            {
                case 0: tableName = "courses"; break;
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
            UpdateGridView();
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
            textBoxChangeCourseName.Text = _currentRow.Cells[1].Value.ToString();
            ChangeSelectStudyRoom.Text = _currentRow.Cells[2].Value.ToString();
            ChangeSelectLecturer.Text = _currentRow.Cells[3].Value.ToString();
        }
        private void GetDataFromTableLecturers()
        {
            textBoxChangeLectureName.Text = _currentRow.Cells[1].Value.ToString();
            textBoxChangeLectureEdic.Text = _currentRow.Cells[2].Value.ToString();
            textBoxChangeLectureSpec.Text = _currentRow.Cells[3].Value.ToString();
        }
        private void GetDataFromTableKlients()
        {
            textBoxChangeKlientName.Text = _currentRow.Cells[1].Value.ToString();
            dateTimePickerChangeKlientDOB.Text = _currentRow.Cells[2].Value.ToString();
            if(_currentRow.Cells[3].Value.ToString() == "муж")
                radioButtonGenderMan.Select();
            else radioButtonGenderWoman.Select();
        }
        private void GetDataFromTableStudyRooms()
        {
            textBoxChangeStudyRoomsCity.Text = _currentRow.Cells[1].Value.ToString();
            textBoxChangeStudyRoomsStreet.Text = _currentRow.Cells[2].Value.ToString();
            textBoxChangeStudyRoomsStructure.Text = _currentRow.Cells[3].Value.ToString();
            textBoxChangeStudyRoomsCabinet.Text = _currentRow.Cells[4].Value.ToString();
        }
        private void ResetAll()
        {
            textBoxChangeKlientName.ResetText();
            dateTimePickerChangeKlientDOB.ResetText();
            radioButtonGenderMan.Checked = false;
            radioButtonGenderWoman.Checked = false;
            textBoxChangeCourseName.ResetText();
            ChangeSelectLecturer.ResetText();
            ChangeSelectStudyRoom.ResetText();
            textBoxChangeStudyRoomsCity.ResetText();
            textBoxChangeStudyRoomsStreet.ResetText();
            textBoxChangeStudyRoomsStructure.ResetText();
            textBoxChangeStudyRoomsCabinet.ResetText();
            textBoxChangeLectureName.ResetText();
            textBoxChangeLectureEdic.ResetText();
            textBoxChangeLectureSpec.ResetText();
        }
        private void buttonChangeCourse_Click(object sender, EventArgs e)
        {
            string table = "Courses";
            string values = $" {_currentRow.Cells[1].OwningColumn.Name} = '{textBoxChangeCourseName.Text}', " +
                $"{_currentRow.Cells[2].OwningColumn.Name} = '{ChangeSelectLecturer.Text}', " +
                $"{_currentRow.Cells[3].OwningColumn.Name} = '{ChangeSelectStudyRoom.Text}'";
            string condition = $"{_currentRow.Cells[0].OwningColumn.Name} = {_currentRow.Cells[0].Value.ToString()}";
            MySqlConnecter.QueryChangeInTable(table, values, condition);
            UpdateGridView();
            ResetAll();
        }

        private void buttonChangeLecturer_Click(object sender, EventArgs e)
        {
            string table = "Lecturers";
            string values = $" {_currentRow.Cells[1].OwningColumn.Name} = '{textBoxChangeLectureName.Text}', " +
                $"{_currentRow.Cells[2].OwningColumn.Name} = '{textBoxChangeLectureEdic.Text}', " +
                $"{_currentRow.Cells[3].OwningColumn.Name} = '{textBoxChangeLectureSpec.Text}'";
            string condition = $"{_currentRow.Cells[0].OwningColumn.Name} = {_currentRow.Cells[0].Value.ToString()}";
            MySqlConnecter.QueryChangeInTable(table, values, condition);
            UpdateGridView();
            ResetAll();
        }

        private void buttonChangeKlient_Click(object sender, EventArgs e)
        {
            int gender = radioButtonGenderMan.Checked ? 1 : 2;
            string table = "Klients";
            string values = $" {_currentRow.Cells[1].OwningColumn.Name} = '{textBoxChangeKlientName.Text}', " +
                $"{_currentRow.Cells[2].OwningColumn.Name} = '{dateTimePickerChangeKlientDOB.Value.ToString("yyyy-MM-dd")}', " +
                $"{_currentRow.Cells[3].OwningColumn.Name} = {gender}";
            string condition = $"{_currentRow.Cells[0].OwningColumn.Name} = {_currentRow.Cells[0].Value.ToString()}";
            MySqlConnecter.QueryChangeInTable(table, values, condition);
            UpdateGridView();
            ResetAll();
        }

        private void buttonChangeStudyRoom_Click(object sender, EventArgs e)
        {
            string table = "StudyRooms";
            string values = $" {_currentRow.Cells[1].OwningColumn.Name} = '{textBoxChangeStudyRoomsCity.Text}', " +
                $"{_currentRow.Cells[2].OwningColumn.Name} = '{textBoxChangeStudyRoomsStreet.Text}', " +
                $"{_currentRow.Cells[3].OwningColumn.Name} = {textBoxChangeStudyRoomsStructure.Text}, " +
                $"{_currentRow.Cells[4].OwningColumn.Name} = {textBoxChangeStudyRoomsCabinet.Text}";
            string condition = $"{_currentRow.Cells[0].OwningColumn.Name} = {_currentRow.Cells[0].Value.ToString()}";
            MySqlConnecter.QueryChangeInTable(table, values, condition);
            UpdateGridView();
            ResetAll();
        }
    }
}
