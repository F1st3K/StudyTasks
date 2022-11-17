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
        private DataGridViewRow currentRow;
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
            currentRow = dataGridView.Rows[dataGridView.CurrentCell.RowIndex];
            currentRow.Selected = true;
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
            textBoxChangeCourseName.Text = currentRow.Cells[1].Value.ToString();
            ChangeSelectStudyRoom.Text = currentRow.Cells[2].Value.ToString();
            ChangeSelectLecturer.Text = currentRow.Cells[3].Value.ToString();
        }
        private void GetDataFromTableLecturers()
        {
            textBoxChangeLectureName.Text = currentRow.Cells[1].Value.ToString();
            textBoxChangeLectureEdic.Text = currentRow.Cells[2].Value.ToString();
            textBoxChangeLectureSpec.Text = currentRow.Cells[3].Value.ToString();
        }
        private void GetDataFromTableKlients()
        {
            textBoxChangeKlientName.Text = currentRow.Cells[1].Value.ToString();
            dateTimePickerChangeKlientDOB.Text = currentRow.Cells[2].Value.ToString();
            if(currentRow.Cells[3].Value.ToString() == "муж")
                radioButtonGenderMan.Select();
            else radioButtonGenderWoman.Select();
        }
        private void GetDataFromTableStudyRooms()
        {
            textBoxChangeStudyRoomsCity.Text = currentRow.Cells[1].Value.ToString();
            textBoxChangeStudyRoomsStreet.Text = currentRow.Cells[2].Value.ToString();
            textBoxChangeStudyRoomsStructure.Text = currentRow.Cells[3].Value.ToString();
            textBoxChangeStudyRoomsCabinet.Text = currentRow.Cells[4].Value.ToString();
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
            string values = $" {currentRow.Cells[1].OwningColumn.Name} = '{textBoxChangeCourseName.Text}', " +
                $"{currentRow.Cells[2].OwningColumn.Name} = '{ChangeSelectLecturer.Text}', " +
                $"{currentRow.Cells[3].OwningColumn.Name} = '{ChangeSelectStudyRoom.Text}'";
            string condition = $"{currentRow.Cells[0].OwningColumn.Name} = {currentRow.Cells[0].Value.ToString()}";
            MySqlConnecter.QueryChangeInTable(table, values, condition);
            UpdateGridView();
            ResetAll();
        }

        private void buttonChangeLecturer_Click(object sender, EventArgs e)
        {
            string table = "Lecturers";
            string values = $" {currentRow.Cells[1].OwningColumn.Name} = '{textBoxChangeLectureName.Text}', " +
                $"{currentRow.Cells[2].OwningColumn.Name} = '{textBoxChangeLectureEdic.Text}', " +
                $"{currentRow.Cells[3].OwningColumn.Name} = '{textBoxChangeLectureSpec.Text}'";
            string condition = $"{currentRow.Cells[0].OwningColumn.Name} = {currentRow.Cells[0].Value.ToString()}";
            MySqlConnecter.QueryChangeInTable(table, values, condition);
            UpdateGridView();
            ResetAll();
        }

        private void buttonChangeKlient_Click(object sender, EventArgs e)
        {
            int gender = radioButtonGenderMan.Checked ? 1 : 2;
            string table = "Klients";
            string values = $" {currentRow.Cells[1].OwningColumn.Name} = '{textBoxChangeKlientName.Text}', " +
                $"{currentRow.Cells[2].OwningColumn.Name} = '{dateTimePickerChangeKlientDOB.Value.ToString("yyyy-MM-dd")}', " +
                $"{currentRow.Cells[3].OwningColumn.Name} = {gender}";
            string condition = $"{currentRow.Cells[0].OwningColumn.Name} = {currentRow.Cells[0].Value.ToString()}";
            MySqlConnecter.QueryChangeInTable(table, values, condition);
            UpdateGridView();
            ResetAll();
        }

        private void buttonChangeStudyRoom_Click(object sender, EventArgs e)
        {
            string table = "StudyRooms";
            string values = $" {currentRow.Cells[1].OwningColumn.Name} = '{textBoxChangeStudyRoomsCity.Text}', " +
                $"{currentRow.Cells[2].OwningColumn.Name} = '{textBoxChangeStudyRoomsStreet.Text}', " +
                $"{currentRow.Cells[3].OwningColumn.Name} = {textBoxChangeStudyRoomsStructure.Text}, " +
                $"{currentRow.Cells[4].OwningColumn.Name} = {textBoxChangeStudyRoomsCabinet.Text}";
            string condition = $"{currentRow.Cells[0].OwningColumn.Name} = {currentRow.Cells[0].Value.ToString()}";
            MySqlConnecter.QueryChangeInTable(table, values, condition);
            UpdateGridView();
            ResetAll();
        }
    }
}
