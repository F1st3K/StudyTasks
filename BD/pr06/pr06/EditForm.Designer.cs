namespace pr06
{
    partial class EditForm
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.tabControlAdd = new System.Windows.Forms.TabControl();
            this.tabPageCourses = new System.Windows.Forms.TabPage();
            this.ChangeSelectStudyRoom = new System.Windows.Forms.ComboBox();
            this.ChangeSelectLecturer = new System.Windows.Forms.ComboBox();
            this.buttonChangeCourse = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxChangeCourseName = new System.Windows.Forms.TextBox();
            this.tabPageLecturers = new System.Windows.Forms.TabPage();
            this.buttonChangeLecturer = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxChangeLectureEdic = new System.Windows.Forms.TextBox();
            this.textBoxChangeLectureSpec = new System.Windows.Forms.TextBox();
            this.textBoxChangeLectureName = new System.Windows.Forms.TextBox();
            this.tabPageKlients = new System.Windows.Forms.TabPage();
            this.dateTimePickerChangeKlientDOB = new System.Windows.Forms.DateTimePicker();
            this.radioButtonGenderWoman = new System.Windows.Forms.RadioButton();
            this.radioButtonGenderMan = new System.Windows.Forms.RadioButton();
            this.buttonChangeKlient = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxChangeKlientName = new System.Windows.Forms.TextBox();
            this.tabPageStudyRooms = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxChangeStudyRoomsCabinet = new System.Windows.Forms.TextBox();
            this.buttonChangeStudyRoom = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxChangeStudyRoomsStreet = new System.Windows.Forms.TextBox();
            this.textBoxChangeStudyRoomsStructure = new System.Windows.Forms.TextBox();
            this.textBoxChangeStudyRoomsCity = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.tabControlAdd.SuspendLayout();
            this.tabPageCourses.SuspendLayout();
            this.tabPageLecturers.SuspendLayout();
            this.tabPageKlients.SuspendLayout();
            this.tabPageStudyRooms.SuspendLayout();
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
            this.menuStrip1.TabIndex = 4;
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
            this.backToolStripMenuItem.Size = new System.Drawing.Size(132, 26);
            this.backToolStripMenuItem.Text = "назад";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(0, 32);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(936, 258);
            this.dataGridView.TabIndex = 6;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // tabControlAdd
            // 
            this.tabControlAdd.Controls.Add(this.tabPageCourses);
            this.tabControlAdd.Controls.Add(this.tabPageLecturers);
            this.tabControlAdd.Controls.Add(this.tabPageKlients);
            this.tabControlAdd.Controls.Add(this.tabPageStudyRooms);
            this.tabControlAdd.Location = new System.Drawing.Point(0, 288);
            this.tabControlAdd.Name = "tabControlAdd";
            this.tabControlAdd.SelectedIndex = 0;
            this.tabControlAdd.Size = new System.Drawing.Size(936, 247);
            this.tabControlAdd.TabIndex = 7;
            this.tabControlAdd.SelectedIndexChanged += new System.EventHandler(this.tabControlAdd_SelectedIndexChanged);
            // 
            // tabPageCourses
            // 
            this.tabPageCourses.Controls.Add(this.ChangeSelectStudyRoom);
            this.tabPageCourses.Controls.Add(this.ChangeSelectLecturer);
            this.tabPageCourses.Controls.Add(this.buttonChangeCourse);
            this.tabPageCourses.Controls.Add(this.label3);
            this.tabPageCourses.Controls.Add(this.label2);
            this.tabPageCourses.Controls.Add(this.label1);
            this.tabPageCourses.Controls.Add(this.textBoxChangeCourseName);
            this.tabPageCourses.Location = new System.Drawing.Point(4, 25);
            this.tabPageCourses.Name = "tabPageCourses";
            this.tabPageCourses.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCourses.Size = new System.Drawing.Size(928, 218);
            this.tabPageCourses.TabIndex = 0;
            this.tabPageCourses.Text = "Курсы";
            this.tabPageCourses.UseVisualStyleBackColor = true;
            // 
            // ChangeSelectStudyRoom
            // 
            this.ChangeSelectStudyRoom.FormattingEnabled = true;
            this.ChangeSelectStudyRoom.Location = new System.Drawing.Point(11, 144);
            this.ChangeSelectStudyRoom.Name = "ChangeSelectStudyRoom";
            this.ChangeSelectStudyRoom.Size = new System.Drawing.Size(181, 24);
            this.ChangeSelectStudyRoom.TabIndex = 17;
            // 
            // ChangeSelectLecturer
            // 
            this.ChangeSelectLecturer.FormattingEnabled = true;
            this.ChangeSelectLecturer.Location = new System.Drawing.Point(11, 80);
            this.ChangeSelectLecturer.Name = "ChangeSelectLecturer";
            this.ChangeSelectLecturer.Size = new System.Drawing.Size(181, 24);
            this.ChangeSelectLecturer.TabIndex = 16;
            // 
            // buttonChangeCourse
            // 
            this.buttonChangeCourse.Location = new System.Drawing.Point(221, 101);
            this.buttonChangeCourse.Name = "buttonChangeCourse";
            this.buttonChangeCourse.Size = new System.Drawing.Size(137, 45);
            this.buttonChangeCourse.TabIndex = 13;
            this.buttonChangeCourse.Text = "Редактировать";
            this.buttonChangeCourse.UseVisualStyleBackColor = true;
            this.buttonChangeCourse.Click += new System.EventHandler(this.buttonChangeCourse_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Помещение:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Лектор:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Наименование курса:";
            // 
            // textBoxChangeCourseName
            // 
            this.textBoxChangeCourseName.Location = new System.Drawing.Point(8, 28);
            this.textBoxChangeCourseName.Name = "textBoxChangeCourseName";
            this.textBoxChangeCourseName.Size = new System.Drawing.Size(350, 22);
            this.textBoxChangeCourseName.TabIndex = 7;
            // 
            // tabPageLecturers
            // 
            this.tabPageLecturers.Controls.Add(this.buttonChangeLecturer);
            this.tabPageLecturers.Controls.Add(this.label4);
            this.tabPageLecturers.Controls.Add(this.label5);
            this.tabPageLecturers.Controls.Add(this.label6);
            this.tabPageLecturers.Controls.Add(this.textBoxChangeLectureEdic);
            this.tabPageLecturers.Controls.Add(this.textBoxChangeLectureSpec);
            this.tabPageLecturers.Controls.Add(this.textBoxChangeLectureName);
            this.tabPageLecturers.Location = new System.Drawing.Point(4, 25);
            this.tabPageLecturers.Name = "tabPageLecturers";
            this.tabPageLecturers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLecturers.Size = new System.Drawing.Size(928, 218);
            this.tabPageLecturers.TabIndex = 1;
            this.tabPageLecturers.Text = "Лектора";
            this.tabPageLecturers.UseVisualStyleBackColor = true;
            // 
            // buttonChangeLecturer
            // 
            this.buttonChangeLecturer.Location = new System.Drawing.Point(220, 168);
            this.buttonChangeLecturer.Name = "buttonChangeLecturer";
            this.buttonChangeLecturer.Size = new System.Drawing.Size(137, 45);
            this.buttonChangeLecturer.TabIndex = 13;
            this.buttonChangeLecturer.Text = "Редактировать";
            this.buttonChangeLecturer.UseVisualStyleBackColor = true;
            this.buttonChangeLecturer.Click += new System.EventHandler(this.buttonChangeLecturer_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Специализация:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Образование:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "ФИО:";
            // 
            // textBoxChangeLectureEdic
            // 
            this.textBoxChangeLectureEdic.Location = new System.Drawing.Point(7, 82);
            this.textBoxChangeLectureEdic.Name = "textBoxChangeLectureEdic";
            this.textBoxChangeLectureEdic.Size = new System.Drawing.Size(350, 22);
            this.textBoxChangeLectureEdic.TabIndex = 9;
            // 
            // textBoxChangeLectureSpec
            // 
            this.textBoxChangeLectureSpec.Location = new System.Drawing.Point(7, 137);
            this.textBoxChangeLectureSpec.Name = "textBoxChangeLectureSpec";
            this.textBoxChangeLectureSpec.Size = new System.Drawing.Size(350, 22);
            this.textBoxChangeLectureSpec.TabIndex = 8;
            // 
            // textBoxChangeLectureName
            // 
            this.textBoxChangeLectureName.Location = new System.Drawing.Point(7, 31);
            this.textBoxChangeLectureName.Name = "textBoxChangeLectureName";
            this.textBoxChangeLectureName.Size = new System.Drawing.Size(350, 22);
            this.textBoxChangeLectureName.TabIndex = 7;
            // 
            // tabPageKlients
            // 
            this.tabPageKlients.Controls.Add(this.dateTimePickerChangeKlientDOB);
            this.tabPageKlients.Controls.Add(this.radioButtonGenderWoman);
            this.tabPageKlients.Controls.Add(this.radioButtonGenderMan);
            this.tabPageKlients.Controls.Add(this.buttonChangeKlient);
            this.tabPageKlients.Controls.Add(this.label7);
            this.tabPageKlients.Controls.Add(this.label8);
            this.tabPageKlients.Controls.Add(this.label9);
            this.tabPageKlients.Controls.Add(this.textBoxChangeKlientName);
            this.tabPageKlients.Location = new System.Drawing.Point(4, 25);
            this.tabPageKlients.Name = "tabPageKlients";
            this.tabPageKlients.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageKlients.Size = new System.Drawing.Size(928, 218);
            this.tabPageKlients.TabIndex = 2;
            this.tabPageKlients.Text = "Клиенты";
            this.tabPageKlients.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerChangeKlientDOB
            // 
            this.dateTimePickerChangeKlientDOB.Location = new System.Drawing.Point(4, 80);
            this.dateTimePickerChangeKlientDOB.Name = "dateTimePickerChangeKlientDOB";
            this.dateTimePickerChangeKlientDOB.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerChangeKlientDOB.TabIndex = 16;
            // 
            // radioButtonGenderWoman
            // 
            this.radioButtonGenderWoman.AutoSize = true;
            this.radioButtonGenderWoman.Location = new System.Drawing.Point(144, 136);
            this.radioButtonGenderWoman.Name = "radioButtonGenderWoman";
            this.radioButtonGenderWoman.Size = new System.Drawing.Size(56, 20);
            this.radioButtonGenderWoman.TabIndex = 15;
            this.radioButtonGenderWoman.TabStop = true;
            this.radioButtonGenderWoman.Text = "жен.";
            this.radioButtonGenderWoman.UseVisualStyleBackColor = true;
            // 
            // radioButtonGenderMan
            // 
            this.radioButtonGenderMan.AutoSize = true;
            this.radioButtonGenderMan.Location = new System.Drawing.Point(61, 136);
            this.radioButtonGenderMan.Name = "radioButtonGenderMan";
            this.radioButtonGenderMan.Size = new System.Drawing.Size(57, 20);
            this.radioButtonGenderMan.TabIndex = 14;
            this.radioButtonGenderMan.TabStop = true;
            this.radioButtonGenderMan.Text = "муж.";
            this.radioButtonGenderMan.UseVisualStyleBackColor = true;
            // 
            // buttonChangeKlient
            // 
            this.buttonChangeKlient.Location = new System.Drawing.Point(217, 124);
            this.buttonChangeKlient.Name = "buttonChangeKlient";
            this.buttonChangeKlient.Size = new System.Drawing.Size(137, 45);
            this.buttonChangeKlient.TabIndex = 13;
            this.buttonChangeKlient.Text = "Редактировать";
            this.buttonChangeKlient.UseVisualStyleBackColor = true;
            this.buttonChangeKlient.Click += new System.EventHandler(this.buttonChangeKlient_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Пол:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "Дата рождения:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 16);
            this.label9.TabIndex = 10;
            this.label9.Text = "ФИО: ";
            // 
            // textBoxChangeKlientName
            // 
            this.textBoxChangeKlientName.Location = new System.Drawing.Point(4, 28);
            this.textBoxChangeKlientName.Name = "textBoxChangeKlientName";
            this.textBoxChangeKlientName.Size = new System.Drawing.Size(350, 22);
            this.textBoxChangeKlientName.TabIndex = 7;
            // 
            // tabPageStudyRooms
            // 
            this.tabPageStudyRooms.Controls.Add(this.label13);
            this.tabPageStudyRooms.Controls.Add(this.textBoxChangeStudyRoomsCabinet);
            this.tabPageStudyRooms.Controls.Add(this.buttonChangeStudyRoom);
            this.tabPageStudyRooms.Controls.Add(this.label10);
            this.tabPageStudyRooms.Controls.Add(this.label11);
            this.tabPageStudyRooms.Controls.Add(this.label12);
            this.tabPageStudyRooms.Controls.Add(this.textBoxChangeStudyRoomsStreet);
            this.tabPageStudyRooms.Controls.Add(this.textBoxChangeStudyRoomsStructure);
            this.tabPageStudyRooms.Controls.Add(this.textBoxChangeStudyRoomsCity);
            this.tabPageStudyRooms.Location = new System.Drawing.Point(4, 25);
            this.tabPageStudyRooms.Name = "tabPageStudyRooms";
            this.tabPageStudyRooms.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStudyRooms.Size = new System.Drawing.Size(928, 218);
            this.tabPageStudyRooms.TabIndex = 3;
            this.tabPageStudyRooms.Text = "Помещения";
            this.tabPageStudyRooms.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 170);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 16);
            this.label13.TabIndex = 15;
            this.label13.Text = "Кабинет: ";
            // 
            // textBoxChangeStudyRoomsCabinet
            // 
            this.textBoxChangeStudyRoomsCabinet.Location = new System.Drawing.Point(3, 189);
            this.textBoxChangeStudyRoomsCabinet.Name = "textBoxChangeStudyRoomsCabinet";
            this.textBoxChangeStudyRoomsCabinet.Size = new System.Drawing.Size(176, 22);
            this.textBoxChangeStudyRoomsCabinet.TabIndex = 14;
            // 
            // buttonChangeStudyRoom
            // 
            this.buttonChangeStudyRoom.Location = new System.Drawing.Point(216, 141);
            this.buttonChangeStudyRoom.Name = "buttonChangeStudyRoom";
            this.buttonChangeStudyRoom.Size = new System.Drawing.Size(137, 45);
            this.buttonChangeStudyRoom.TabIndex = 13;
            this.buttonChangeStudyRoom.Text = "Редактировать";
            this.buttonChangeStudyRoom.UseVisualStyleBackColor = true;
            this.buttonChangeStudyRoom.Click += new System.EventHandler(this.buttonChangeStudyRoom_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 114);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 16);
            this.label10.TabIndex = 12;
            this.label10.Text = "Корпус: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 59);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 16);
            this.label11.TabIndex = 11;
            this.label11.Text = "Улица: ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 5);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 16);
            this.label12.TabIndex = 10;
            this.label12.Text = "Город: ";
            // 
            // textBoxChangeStudyRoomsStreet
            // 
            this.textBoxChangeStudyRoomsStreet.Location = new System.Drawing.Point(3, 78);
            this.textBoxChangeStudyRoomsStreet.Name = "textBoxChangeStudyRoomsStreet";
            this.textBoxChangeStudyRoomsStreet.Size = new System.Drawing.Size(350, 22);
            this.textBoxChangeStudyRoomsStreet.TabIndex = 9;
            // 
            // textBoxChangeStudyRoomsStructure
            // 
            this.textBoxChangeStudyRoomsStructure.Location = new System.Drawing.Point(3, 133);
            this.textBoxChangeStudyRoomsStructure.Name = "textBoxChangeStudyRoomsStructure";
            this.textBoxChangeStudyRoomsStructure.Size = new System.Drawing.Size(176, 22);
            this.textBoxChangeStudyRoomsStructure.TabIndex = 8;
            // 
            // textBoxChangeStudyRoomsCity
            // 
            this.textBoxChangeStudyRoomsCity.Location = new System.Drawing.Point(3, 27);
            this.textBoxChangeStudyRoomsCity.Name = "textBoxChangeStudyRoomsCity";
            this.textBoxChangeStudyRoomsCity.Size = new System.Drawing.Size(350, 22);
            this.textBoxChangeStudyRoomsCity.TabIndex = 7;
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(936, 533);
            this.Controls.Add(this.tabControlAdd);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Black;
            this.MaximumSize = new System.Drawing.Size(954, 580);
            this.MinimumSize = new System.Drawing.Size(954, 580);
            this.Name = "EditForm";
            this.Text = "EditForm";
            this.Load += new System.EventHandler(this.EditForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.tabControlAdd.ResumeLayout(false);
            this.tabPageCourses.ResumeLayout(false);
            this.tabPageCourses.PerformLayout();
            this.tabPageLecturers.ResumeLayout(false);
            this.tabPageLecturers.PerformLayout();
            this.tabPageKlients.ResumeLayout(false);
            this.tabPageKlients.PerformLayout();
            this.tabPageStudyRooms.ResumeLayout(false);
            this.tabPageStudyRooms.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TabControl tabControlAdd;
        private System.Windows.Forms.TabPage tabPageCourses;
        private System.Windows.Forms.Button buttonChangeCourse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxChangeCourseName;
        private System.Windows.Forms.TabPage tabPageLecturers;
        private System.Windows.Forms.Button buttonChangeLecturer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxChangeLectureEdic;
        private System.Windows.Forms.TextBox textBoxChangeLectureSpec;
        private System.Windows.Forms.TextBox textBoxChangeLectureName;
        private System.Windows.Forms.TabPage tabPageKlients;
        private System.Windows.Forms.RadioButton radioButtonGenderWoman;
        private System.Windows.Forms.RadioButton radioButtonGenderMan;
        private System.Windows.Forms.Button buttonChangeKlient;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxChangeKlientName;
        private System.Windows.Forms.TabPage tabPageStudyRooms;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxChangeStudyRoomsCabinet;
        private System.Windows.Forms.Button buttonChangeStudyRoom;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxChangeStudyRoomsStreet;
        private System.Windows.Forms.TextBox textBoxChangeStudyRoomsStructure;
        private System.Windows.Forms.TextBox textBoxChangeStudyRoomsCity;
        private System.Windows.Forms.ComboBox ChangeSelectStudyRoom;
        private System.Windows.Forms.ComboBox ChangeSelectLecturer;
        private System.Windows.Forms.DateTimePicker dateTimePickerChangeKlientDOB;
    }
}