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
    public partial class AddForm : Form
    {
        MySqlConnecter MySqlConnecter;
        public AddForm()
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
        private void ResetAll()
        {
            textBoxAddKlientName.ResetText();
            dateTimePickerAddKlientDOB.ResetText();
            radioButtonGenderMan.ResetText();
            radioButtonGenderWoman.ResetText();
            textBoxAddCourseName.ResetText();
            AddSelectLecture.ResetText();
            AddSelectStudyRoom.ResetText();
            textBoxAddStudyRoomsCity.ResetText();
            textBoxAddStudyRoomsStreet.ResetText();
            textBoxAddStudyRoomsStructure.ResetText();
            textBoxAddStudyRoomsCabinet.ResetText();
            textBoxAddLectureName.ResetText();
            textBoxAddLectureEdic.ResetText();
            textBoxAddLectureSpec.ResetText();
        }
        private void buttonAddKlient_Click(object sender, EventArgs e)
        {
            int gender = radioButtonGenderMan.Checked ? 1 : 2;
            string table = "klients";
            string values = $"DEFAULT, '{textBoxAddKlientName.Text}', '{dateTimePickerAddKlientDOB.Value.ToShortDateString()}', {gender}";
            MySqlConnecter.QueryAddInTable(table, values);
            ResetAll();
        }

        private void buttonAddCourse_Click(object sender, EventArgs e)
        {
            string table = "Courses";
            string values = $"DEFAULT, '{textBoxAddCourseName.Text}', {AddSelectLecture.Text}, {AddSelectStudyRoom.Text}";
            MySqlConnecter.QueryAddInTable(table, values);
            ResetAll();
        }

        private void buttonAddStudyRoom_Click(object sender, EventArgs e)
        {
            string table = "StudyRooms";
            string values = $"DEFAULT, '{textBoxAddStudyRoomsCity.Text}', '{textBoxAddStudyRoomsStreet.Text}', '{textBoxAddStudyRoomsStructure.Text}', {textBoxAddStudyRoomsCabinet.Text}";
            MySqlConnecter.QueryAddInTable(table, values);
            ResetAll();

        }

        private void buttonAddLecturer_Click(object sender, EventArgs e)
        {
            string table = "Lecturers";
            string values = $"DEFAULT, '{textBoxAddLectureName.Text}', '{textBoxAddLectureEdic.Text}', '{textBoxAddLectureSpec.Text}'";
            MySqlConnecter.QueryAddInTable(table, values);
            ResetAll();
        }
    }
}
