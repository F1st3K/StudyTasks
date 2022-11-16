namespace pr06
{
    partial class AddForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPageStudyRooms = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxAddStudyRoomsCabinet = new System.Windows.Forms.TextBox();
            this.buttonAddStudyRoom = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxAddStudyRoomsStreet = new System.Windows.Forms.TextBox();
            this.textBoxAddStudyRoomsStructure = new System.Windows.Forms.TextBox();
            this.textBoxAddStudyRoomsCity = new System.Windows.Forms.TextBox();
            this.tabPageKlients = new System.Windows.Forms.TabPage();
            this.radioButtonGenderWoman = new System.Windows.Forms.RadioButton();
            this.radioButtonGenderMan = new System.Windows.Forms.RadioButton();
            this.buttonAddKlient = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxAddKlientName = new System.Windows.Forms.TextBox();
            this.tabPageLecturers = new System.Windows.Forms.TabPage();
            this.buttonAddLecturer = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxAddLectureEdic = new System.Windows.Forms.TextBox();
            this.textBoxAddLectureSpec = new System.Windows.Forms.TextBox();
            this.textBoxAddLectureName = new System.Windows.Forms.TextBox();
            this.tabPageCourses = new System.Windows.Forms.TabPage();
            this.buttonAddCourse = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAddCourseName = new System.Windows.Forms.TextBox();
            this.tabControlAdd = new System.Windows.Forms.TabControl();
            this.AddSelectLecture = new System.Windows.Forms.ComboBox();
            this.dateTimePickerAddKlientDOB = new System.Windows.Forms.DateTimePicker();
            this.AddSelectStudyRoom = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.tabPageStudyRooms.SuspendLayout();
            this.tabPageKlients.SuspendLayout();
            this.tabPageLecturers.SuspendLayout();
            this.tabPageCourses.SuspendLayout();
            this.tabControlAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(936, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(99, 24);
            this.editToolStripMenuItem.Text = "Навигация";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.backToolStripMenuItem.Text = "назад";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // tabPageStudyRooms
            // 
            this.tabPageStudyRooms.Controls.Add(this.label13);
            this.tabPageStudyRooms.Controls.Add(this.textBoxAddStudyRoomsCabinet);
            this.tabPageStudyRooms.Controls.Add(this.buttonAddStudyRoom);
            this.tabPageStudyRooms.Controls.Add(this.label10);
            this.tabPageStudyRooms.Controls.Add(this.label11);
            this.tabPageStudyRooms.Controls.Add(this.label12);
            this.tabPageStudyRooms.Controls.Add(this.textBoxAddStudyRoomsStreet);
            this.tabPageStudyRooms.Controls.Add(this.textBoxAddStudyRoomsStructure);
            this.tabPageStudyRooms.Controls.Add(this.textBoxAddStudyRoomsCity);
            this.tabPageStudyRooms.Location = new System.Drawing.Point(4, 25);
            this.tabPageStudyRooms.Name = "tabPageStudyRooms";
            this.tabPageStudyRooms.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStudyRooms.Size = new System.Drawing.Size(928, 479);
            this.tabPageStudyRooms.TabIndex = 3;
            this.tabPageStudyRooms.Text = "Помещения";
            this.tabPageStudyRooms.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(289, 288);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 16);
            this.label13.TabIndex = 15;
            this.label13.Text = "Кабинет: ";
            // 
            // textBoxAddStudyRoomsCabinet
            // 
            this.textBoxAddStudyRoomsCabinet.Location = new System.Drawing.Point(289, 307);
            this.textBoxAddStudyRoomsCabinet.Name = "textBoxAddStudyRoomsCabinet";
            this.textBoxAddStudyRoomsCabinet.Size = new System.Drawing.Size(350, 22);
            this.textBoxAddStudyRoomsCabinet.TabIndex = 14;
            // 
            // buttonAddStudyRoom
            // 
            this.buttonAddStudyRoom.Location = new System.Drawing.Point(401, 360);
            this.buttonAddStudyRoom.Name = "buttonAddStudyRoom";
            this.buttonAddStudyRoom.Size = new System.Drawing.Size(137, 45);
            this.buttonAddStudyRoom.TabIndex = 13;
            this.buttonAddStudyRoom.Text = "Добавить";
            this.buttonAddStudyRoom.UseVisualStyleBackColor = true;
            this.buttonAddStudyRoom.Click += new System.EventHandler(this.buttonAddStudyRoom_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(289, 232);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 16);
            this.label10.TabIndex = 12;
            this.label10.Text = "Корпус: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(289, 177);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 16);
            this.label11.TabIndex = 11;
            this.label11.Text = "Улица: ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(289, 123);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 16);
            this.label12.TabIndex = 10;
            this.label12.Text = "Город: ";
            // 
            // textBoxAddStudyRoomsStreet
            // 
            this.textBoxAddStudyRoomsStreet.Location = new System.Drawing.Point(289, 196);
            this.textBoxAddStudyRoomsStreet.Name = "textBoxAddStudyRoomsStreet";
            this.textBoxAddStudyRoomsStreet.Size = new System.Drawing.Size(350, 22);
            this.textBoxAddStudyRoomsStreet.TabIndex = 9;
            // 
            // textBoxAddStudyRoomsStructure
            // 
            this.textBoxAddStudyRoomsStructure.Location = new System.Drawing.Point(289, 251);
            this.textBoxAddStudyRoomsStructure.Name = "textBoxAddStudyRoomsStructure";
            this.textBoxAddStudyRoomsStructure.Size = new System.Drawing.Size(350, 22);
            this.textBoxAddStudyRoomsStructure.TabIndex = 8;
            // 
            // textBoxAddStudyRoomsCity
            // 
            this.textBoxAddStudyRoomsCity.Location = new System.Drawing.Point(289, 145);
            this.textBoxAddStudyRoomsCity.Name = "textBoxAddStudyRoomsCity";
            this.textBoxAddStudyRoomsCity.Size = new System.Drawing.Size(350, 22);
            this.textBoxAddStudyRoomsCity.TabIndex = 7;
            // 
            // tabPageKlients
            // 
            this.tabPageKlients.Controls.Add(this.dateTimePickerAddKlientDOB);
            this.tabPageKlients.Controls.Add(this.radioButtonGenderWoman);
            this.tabPageKlients.Controls.Add(this.radioButtonGenderMan);
            this.tabPageKlients.Controls.Add(this.buttonAddKlient);
            this.tabPageKlients.Controls.Add(this.label7);
            this.tabPageKlients.Controls.Add(this.label8);
            this.tabPageKlients.Controls.Add(this.label9);
            this.tabPageKlients.Controls.Add(this.textBoxAddKlientName);
            this.tabPageKlients.Location = new System.Drawing.Point(4, 25);
            this.tabPageKlients.Name = "tabPageKlients";
            this.tabPageKlients.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageKlients.Size = new System.Drawing.Size(928, 479);
            this.tabPageKlients.TabIndex = 2;
            this.tabPageKlients.Text = "Клиенты";
            this.tabPageKlients.UseVisualStyleBackColor = true;
            // 
            // radioButtonGenderWoman
            // 
            this.radioButtonGenderWoman.AutoSize = true;
            this.radioButtonGenderWoman.Location = new System.Drawing.Point(482, 253);
            this.radioButtonGenderWoman.Name = "radioButtonGenderWoman";
            this.radioButtonGenderWoman.Size = new System.Drawing.Size(53, 20);
            this.radioButtonGenderWoman.TabIndex = 15;
            this.radioButtonGenderWoman.TabStop = true;
            this.radioButtonGenderWoman.Text = "жен";
            this.radioButtonGenderWoman.UseVisualStyleBackColor = true;
            // 
            // radioButtonGenderMan
            // 
            this.radioButtonGenderMan.AutoSize = true;
            this.radioButtonGenderMan.Location = new System.Drawing.Point(400, 253);
            this.radioButtonGenderMan.Name = "radioButtonGenderMan";
            this.radioButtonGenderMan.Size = new System.Drawing.Size(54, 20);
            this.radioButtonGenderMan.TabIndex = 14;
            this.radioButtonGenderMan.TabStop = true;
            this.radioButtonGenderMan.Text = "муж";
            this.radioButtonGenderMan.UseVisualStyleBackColor = true;
            // 
            // buttonAddKlient
            // 
            this.buttonAddKlient.Location = new System.Drawing.Point(401, 311);
            this.buttonAddKlient.Name = "buttonAddKlient";
            this.buttonAddKlient.Size = new System.Drawing.Size(137, 45);
            this.buttonAddKlient.TabIndex = 13;
            this.buttonAddKlient.Text = "Добавить";
            this.buttonAddKlient.UseVisualStyleBackColor = true;
            this.buttonAddKlient.Click += new System.EventHandler(this.buttonAddKlient_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(346, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Пол:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(289, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "Дата рождения:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(289, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 16);
            this.label9.TabIndex = 10;
            this.label9.Text = "ФИО: ";
            // 
            // textBoxAddKlientName
            // 
            this.textBoxAddKlientName.Location = new System.Drawing.Point(289, 145);
            this.textBoxAddKlientName.Name = "textBoxAddKlientName";
            this.textBoxAddKlientName.Size = new System.Drawing.Size(350, 22);
            this.textBoxAddKlientName.TabIndex = 7;
            // 
            // tabPageLecturers
            // 
            this.tabPageLecturers.Controls.Add(this.buttonAddLecturer);
            this.tabPageLecturers.Controls.Add(this.label4);
            this.tabPageLecturers.Controls.Add(this.label5);
            this.tabPageLecturers.Controls.Add(this.label6);
            this.tabPageLecturers.Controls.Add(this.textBoxAddLectureEdic);
            this.tabPageLecturers.Controls.Add(this.textBoxAddLectureSpec);
            this.tabPageLecturers.Controls.Add(this.textBoxAddLectureName);
            this.tabPageLecturers.Location = new System.Drawing.Point(4, 25);
            this.tabPageLecturers.Name = "tabPageLecturers";
            this.tabPageLecturers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLecturers.Size = new System.Drawing.Size(928, 479);
            this.tabPageLecturers.TabIndex = 1;
            this.tabPageLecturers.Text = "Лектора";
            this.tabPageLecturers.UseVisualStyleBackColor = true;
            // 
            // buttonAddLecturer
            // 
            this.buttonAddLecturer.Location = new System.Drawing.Point(401, 311);
            this.buttonAddLecturer.Name = "buttonAddLecturer";
            this.buttonAddLecturer.Size = new System.Drawing.Size(137, 45);
            this.buttonAddLecturer.TabIndex = 13;
            this.buttonAddLecturer.Text = "Добавить";
            this.buttonAddLecturer.UseVisualStyleBackColor = true;
            this.buttonAddLecturer.Click += new System.EventHandler(this.buttonAddLecturer_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(289, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Специализация:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(289, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Образование:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(289, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "ФИО:";
            // 
            // textBoxAddLectureEdic
            // 
            this.textBoxAddLectureEdic.Location = new System.Drawing.Point(289, 196);
            this.textBoxAddLectureEdic.Name = "textBoxAddLectureEdic";
            this.textBoxAddLectureEdic.Size = new System.Drawing.Size(350, 22);
            this.textBoxAddLectureEdic.TabIndex = 9;
            // 
            // textBoxAddLectureSpec
            // 
            this.textBoxAddLectureSpec.Location = new System.Drawing.Point(289, 251);
            this.textBoxAddLectureSpec.Name = "textBoxAddLectureSpec";
            this.textBoxAddLectureSpec.Size = new System.Drawing.Size(350, 22);
            this.textBoxAddLectureSpec.TabIndex = 8;
            // 
            // textBoxAddLectureName
            // 
            this.textBoxAddLectureName.Location = new System.Drawing.Point(289, 145);
            this.textBoxAddLectureName.Name = "textBoxAddLectureName";
            this.textBoxAddLectureName.Size = new System.Drawing.Size(350, 22);
            this.textBoxAddLectureName.TabIndex = 7;
            // 
            // tabPageCourses
            // 
            this.tabPageCourses.Controls.Add(this.AddSelectStudyRoom);
            this.tabPageCourses.Controls.Add(this.AddSelectLecture);
            this.tabPageCourses.Controls.Add(this.buttonAddCourse);
            this.tabPageCourses.Controls.Add(this.label3);
            this.tabPageCourses.Controls.Add(this.label2);
            this.tabPageCourses.Controls.Add(this.label1);
            this.tabPageCourses.Controls.Add(this.textBoxAddCourseName);
            this.tabPageCourses.Location = new System.Drawing.Point(4, 25);
            this.tabPageCourses.Name = "tabPageCourses";
            this.tabPageCourses.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCourses.Size = new System.Drawing.Size(928, 479);
            this.tabPageCourses.TabIndex = 0;
            this.tabPageCourses.Text = "Курсы";
            this.tabPageCourses.UseVisualStyleBackColor = true;
            // 
            // buttonAddCourse
            // 
            this.buttonAddCourse.Location = new System.Drawing.Point(401, 311);
            this.buttonAddCourse.Name = "buttonAddCourse";
            this.buttonAddCourse.Size = new System.Drawing.Size(137, 45);
            this.buttonAddCourse.TabIndex = 13;
            this.buttonAddCourse.Text = "Добавить";
            this.buttonAddCourse.UseVisualStyleBackColor = true;
            this.buttonAddCourse.Click += new System.EventHandler(this.buttonAddCourse_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(289, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Помещение:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Лектор:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(289, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Наименование курса:";
            // 
            // textBoxAddCourseName
            // 
            this.textBoxAddCourseName.Location = new System.Drawing.Point(289, 145);
            this.textBoxAddCourseName.Name = "textBoxAddCourseName";
            this.textBoxAddCourseName.Size = new System.Drawing.Size(350, 22);
            this.textBoxAddCourseName.TabIndex = 7;
            // 
            // tabControlAdd
            // 
            this.tabControlAdd.Controls.Add(this.tabPageCourses);
            this.tabControlAdd.Controls.Add(this.tabPageLecturers);
            this.tabControlAdd.Controls.Add(this.tabPageKlients);
            this.tabControlAdd.Controls.Add(this.tabPageStudyRooms);
            this.tabControlAdd.Location = new System.Drawing.Point(0, 31);
            this.tabControlAdd.Name = "tabControlAdd";
            this.tabControlAdd.SelectedIndex = 0;
            this.tabControlAdd.Size = new System.Drawing.Size(936, 508);
            this.tabControlAdd.TabIndex = 3;
            // 
            // AddSelectLecture
            // 
            this.AddSelectLecture.FormattingEnabled = true;
            this.AddSelectLecture.Location = new System.Drawing.Point(289, 196);
            this.AddSelectLecture.Name = "AddSelectLecture";
            this.AddSelectLecture.Size = new System.Drawing.Size(184, 24);
            this.AddSelectLecture.TabIndex = 14;
            // 
            // dateTimePickerAddKlientDOB
            // 
            this.dateTimePickerAddKlientDOB.Location = new System.Drawing.Point(289, 212);
            this.dateTimePickerAddKlientDOB.Name = "dateTimePickerAddKlientDOB";
            this.dateTimePickerAddKlientDOB.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerAddKlientDOB.TabIndex = 16;
            // 
            // AddSelectStudyRoom
            // 
            this.AddSelectStudyRoom.FormattingEnabled = true;
            this.AddSelectStudyRoom.Location = new System.Drawing.Point(289, 260);
            this.AddSelectStudyRoom.Name = "AddSelectStudyRoom";
            this.AddSelectStudyRoom.Size = new System.Drawing.Size(184, 24);
            this.AddSelectStudyRoom.TabIndex = 15;
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 533);
            this.Controls.Add(this.tabControlAdd);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(954, 580);
            this.MinimumSize = new System.Drawing.Size(954, 580);
            this.Name = "AddForm";
            this.Text = "AddForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabPageStudyRooms.ResumeLayout(false);
            this.tabPageStudyRooms.PerformLayout();
            this.tabPageKlients.ResumeLayout(false);
            this.tabPageKlients.PerformLayout();
            this.tabPageLecturers.ResumeLayout(false);
            this.tabPageLecturers.PerformLayout();
            this.tabPageCourses.ResumeLayout(false);
            this.tabPageCourses.PerformLayout();
            this.tabControlAdd.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPageStudyRooms;
        private System.Windows.Forms.TabPage tabPageKlients;
        private System.Windows.Forms.TabPage tabPageLecturers;
        private System.Windows.Forms.TabPage tabPageCourses;
        private System.Windows.Forms.TabControl tabControlAdd;
        private System.Windows.Forms.Button buttonAddStudyRoom;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxAddStudyRoomsStreet;
        private System.Windows.Forms.TextBox textBoxAddStudyRoomsStructure;
        private System.Windows.Forms.TextBox textBoxAddStudyRoomsCity;
        private System.Windows.Forms.Button buttonAddKlient;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxAddKlientName;
        private System.Windows.Forms.Button buttonAddLecturer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxAddLectureEdic;
        private System.Windows.Forms.TextBox textBoxAddLectureSpec;
        private System.Windows.Forms.TextBox textBoxAddLectureName;
        private System.Windows.Forms.Button buttonAddCourse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAddCourseName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxAddStudyRoomsCabinet;
        private System.Windows.Forms.RadioButton radioButtonGenderWoman;
        private System.Windows.Forms.RadioButton radioButtonGenderMan;
        private System.Windows.Forms.ComboBox AddSelectLecture;
        private System.Windows.Forms.DateTimePicker dateTimePickerAddKlientDOB;
        private System.Windows.Forms.ComboBox AddSelectStudyRoom;
    }
}