namespace pr14
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.page1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.outputTask01 = new System.Windows.Forms.Label();
            this.runingTask01 = new System.Windows.Forms.Button();
            this.inputNumberTask01 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.outputTask02 = new System.Windows.Forms.Label();
            this.inputATask02 = new System.Windows.Forms.TextBox();
            this.runingTask02 = new System.Windows.Forms.Button();
            this.inputNTask02 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.runingTask03 = new System.Windows.Forms.Button();
            this.inputTask03 = new System.Windows.Forms.TextBox();
            this.outputTask03 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.runingTask04 = new System.Windows.Forms.Button();
            this.inputTask04 = new System.Windows.Forms.TextBox();
            this.outputTask04 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.page1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // page1
            // 
            this.page1.Controls.Add(this.tabPage1);
            this.page1.Controls.Add(this.tabPage2);
            this.page1.Controls.Add(this.tabPage3);
            this.page1.Controls.Add(this.tabPage4);
            this.page1.Location = new System.Drawing.Point(4, 2);
            this.page1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.page1.Name = "page1";
            this.page1.SelectedIndex = 0;
            this.page1.Size = new System.Drawing.Size(388, 305);
            this.page1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.outputTask01);
            this.tabPage1.Controls.Add(this.runingTask01);
            this.tabPage1.Controls.Add(this.inputNumberTask01);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tabPage1.Size = new System.Drawing.Size(380, 262);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Task01";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // outputTask01
            // 
            this.outputTask01.Location = new System.Drawing.Point(51, 203);
            this.outputTask01.Name = "outputTask01";
            this.outputTask01.Size = new System.Drawing.Size(287, 34);
            this.outputTask01.TabIndex = 3;
            this.outputTask01.Text = "Ответ: ";
            // 
            // runingTask01
            // 
            this.runingTask01.Location = new System.Drawing.Point(187, 138);
            this.runingTask01.Name = "runingTask01";
            this.runingTask01.Size = new System.Drawing.Size(151, 37);
            this.runingTask01.TabIndex = 2;
            this.runingTask01.Text = "Проверить";
            this.runingTask01.UseVisualStyleBackColor = true;
            this.runingTask01.Click += new System.EventHandler(this.runingTask01_Click);
            // 
            // inputNumberTask01
            // 
            this.inputNumberTask01.Location = new System.Drawing.Point(51, 140);
            this.inputNumberTask01.Name = "inputNumberTask01";
            this.inputNumberTask01.Size = new System.Drawing.Size(130, 37);
            this.inputNumberTask01.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 108);
            this.label1.TabIndex = 0;
            this.label1.Text = "1. Проверить истинность высказывания: \"Данное целое положительное число является " +
    "четным трехзначным числом\".";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.outputTask02);
            this.tabPage2.Controls.Add(this.inputATask02);
            this.tabPage2.Controls.Add(this.runingTask02);
            this.tabPage2.Controls.Add(this.inputNTask02);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 39);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tabPage2.Size = new System.Drawing.Size(380, 262);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Task02";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // outputTask02
            // 
            this.outputTask02.Location = new System.Drawing.Point(118, 202);
            this.outputTask02.Name = "outputTask02";
            this.outputTask02.Size = new System.Drawing.Size(254, 34);
            this.outputTask02.TabIndex = 5;
            this.outputTask02.Text = "Ответ: ";
            // 
            // inputATask02
            // 
            this.inputATask02.Font = new System.Drawing.Font("Microsoft YaHei UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputATask02.Location = new System.Drawing.Point(18, 182);
            this.inputATask02.Name = "inputATask02";
            this.inputATask02.Size = new System.Drawing.Size(83, 54);
            this.inputATask02.TabIndex = 4;
            // 
            // runingTask02
            // 
            this.runingTask02.Location = new System.Drawing.Point(166, 140);
            this.runingTask02.Name = "runingTask02";
            this.runingTask02.Size = new System.Drawing.Size(104, 36);
            this.runingTask02.TabIndex = 3;
            this.runingTask02.Text = "Расчет";
            this.runingTask02.UseVisualStyleBackColor = true;
            this.runingTask02.Click += new System.EventHandler(this.runingTask02_Click);
            // 
            // inputNTask02
            // 
            this.inputNTask02.Location = new System.Drawing.Point(96, 139);
            this.inputNTask02.Name = "inputNTask02";
            this.inputNTask02.Size = new System.Drawing.Size(51, 37);
            this.inputNTask02.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(9, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(363, 119);
            this.label2.TabIndex = 1;
            this.label2.Text = "2. Дано вещественное число A и целое число N(N > 0). \r\nВывести значение результат" +
    "а A в степени N: AN = A* A*...*A(число A перемножается N раз).\r\n";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.runingTask03);
            this.tabPage3.Controls.Add(this.inputTask03);
            this.tabPage3.Controls.Add(this.outputTask03);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Location = new System.Drawing.Point(4, 39);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tabPage3.Size = new System.Drawing.Size(380, 262);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Task03";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // runingTask03
            // 
            this.runingTask03.Location = new System.Drawing.Point(13, 184);
            this.runingTask03.Name = "runingTask03";
            this.runingTask03.Size = new System.Drawing.Size(188, 39);
            this.runingTask03.TabIndex = 8;
            this.runingTask03.Text = "Определить";
            this.runingTask03.UseVisualStyleBackColor = true;
            this.runingTask03.Click += new System.EventHandler(this.runingTask03_Click);
            // 
            // inputTask03
            // 
            this.inputTask03.Location = new System.Drawing.Point(12, 142);
            this.inputTask03.Name = "inputTask03";
            this.inputTask03.Size = new System.Drawing.Size(359, 37);
            this.inputTask03.TabIndex = 7;
            // 
            // outputTask03
            // 
            this.outputTask03.Location = new System.Drawing.Point(8, 222);
            this.outputTask03.Name = "outputTask03";
            this.outputTask03.Size = new System.Drawing.Size(364, 34);
            this.outputTask03.TabIndex = 6;
            this.outputTask03.Text = "Ответ: ";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(8, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(372, 121);
            this.label3.TabIndex = 1;
            this.label3.Text = "3. Вводится строка-предложение на английском языке. Длина строки может быть разно" +
    "й. Определить и вывести слово, содержащего наибольшее число символов \'d\'.\r\n";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.runingTask04);
            this.tabPage4.Controls.Add(this.inputTask04);
            this.tabPage4.Controls.Add(this.outputTask04);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Location = new System.Drawing.Point(4, 39);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tabPage4.Size = new System.Drawing.Size(380, 262);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Task04";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // runingTask04
            // 
            this.runingTask04.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.runingTask04.Location = new System.Drawing.Point(312, 179);
            this.runingTask04.Name = "runingTask04";
            this.runingTask04.Size = new System.Drawing.Size(68, 45);
            this.runingTask04.TabIndex = 9;
            this.runingTask04.Text = "вывод\r\n";
            this.runingTask04.UseVisualStyleBackColor = true;
            this.runingTask04.Click += new System.EventHandler(this.runingTask04_Click);
            // 
            // inputTask04
            // 
            this.inputTask04.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputTask04.Location = new System.Drawing.Point(12, 179);
            this.inputTask04.Multiline = true;
            this.inputTask04.Name = "inputTask04";
            this.inputTask04.Size = new System.Drawing.Size(302, 45);
            this.inputTask04.TabIndex = 8;
            // 
            // outputTask04
            // 
            this.outputTask04.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outputTask04.Location = new System.Drawing.Point(8, 227);
            this.outputTask04.Name = "outputTask04";
            this.outputTask04.Size = new System.Drawing.Size(364, 29);
            this.outputTask04.TabIndex = 7;
            this.outputTask04.Text = "Ответ: ";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(8, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(370, 170);
            this.label4.TabIndex = 1;
            this.label4.Text = resources.GetString("label4.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 309);
            this.Controls.Add(this.page1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.page1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl page1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button runingTask01;
        private System.Windows.Forms.TextBox inputNumberTask01;
        private System.Windows.Forms.Label outputTask01;
        private System.Windows.Forms.TextBox inputNTask02;
        private System.Windows.Forms.TextBox inputATask02;
        private System.Windows.Forms.Button runingTask02;
        private System.Windows.Forms.Label outputTask02;
        private System.Windows.Forms.Button runingTask03;
        private System.Windows.Forms.TextBox inputTask03;
        private System.Windows.Forms.Label outputTask03;
        private System.Windows.Forms.Button runingTask04;
        private System.Windows.Forms.TextBox inputTask04;
        private System.Windows.Forms.Label outputTask04;
    }
}

