﻿namespace Testo.Forms.SetingsPages
{
    partial class TaskEditPage
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel4 = new System.Windows.Forms.Panel();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DeleteTask = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TaskDescriptionTxtBox = new MetroFramework.Controls.MetroTextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.DeleteMarkBtn = new System.Windows.Forms.Button();
            this.AddMarkBtn = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.metroComboBox1);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 224);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(604, 102);
            this.panel4.TabIndex = 8;
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Items.AddRange(new object[] {
            "Строка",
            "Выбор одного",
            "Выбор нескольких",
            "Порядок"});
            this.metroComboBox1.Location = new System.Drawing.Point(55, 53);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(492, 29);
            this.metroComboBox1.TabIndex = 3;
            this.metroComboBox1.UseSelectable = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label5.Location = new System.Drawing.Point(52, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Метод ответа на вопрос";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(51, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 21);
            this.label6.TabIndex = 2;
            this.label6.Text = "Тип ответа";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.TaskDescriptionTxtBox);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 150);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(604, 204);
            this.panel3.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label1.Location = new System.Drawing.Point(52, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Полное описание вопроса";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(51, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Текст вопроса";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.metroTextBox1);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 62);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(604, 88);
            this.panel5.TabIndex = 6;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(470, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[] {
        "Вопрос #"};
            this.metroTextBox1.Location = new System.Drawing.Point(55, 49);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(492, 23);
            this.metroTextBox1.TabIndex = 3;
            this.metroTextBox1.Text = "Вопрос #";
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label7.Location = new System.Drawing.Point(52, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(191, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Отображаемое название вопроса";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(51, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 21);
            this.label8.TabIndex = 2;
            this.label8.Text = "Заголовок";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.metroLabel2);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(604, 62);
            this.panel6.TabIndex = 5;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(50, 21);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(70, 25);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Вопрос";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DeleteTask);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 760);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(604, 81);
            this.panel1.TabIndex = 9;
            // 
            // DeleteTask
            // 
            this.DeleteTask.BackColor = System.Drawing.Color.Gray;
            this.DeleteTask.FlatAppearance.BorderSize = 0;
            this.DeleteTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteTask.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteTask.ForeColor = System.Drawing.Color.White;
            this.DeleteTask.Location = new System.Drawing.Point(399, 19);
            this.DeleteTask.Name = "DeleteTask";
            this.DeleteTask.Size = new System.Drawing.Size(148, 36);
            this.DeleteTask.TabIndex = 10;
            this.DeleteTask.Text = "Удалить";
            this.DeleteTask.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 354);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(604, 406);
            this.panel2.TabIndex = 10;
            // 
            // TaskDescriptionTxtBox
            // 
            // 
            // 
            // 
            this.TaskDescriptionTxtBox.CustomButton.Image = null;
            this.TaskDescriptionTxtBox.CustomButton.Location = new System.Drawing.Point(342, 2);
            this.TaskDescriptionTxtBox.CustomButton.Name = "";
            this.TaskDescriptionTxtBox.CustomButton.Size = new System.Drawing.Size(147, 147);
            this.TaskDescriptionTxtBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TaskDescriptionTxtBox.CustomButton.TabIndex = 1;
            this.TaskDescriptionTxtBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TaskDescriptionTxtBox.CustomButton.UseSelectable = true;
            this.TaskDescriptionTxtBox.CustomButton.Visible = false;
            this.TaskDescriptionTxtBox.Lines = new string[] {
        "metroTextBox2"};
            this.TaskDescriptionTxtBox.Location = new System.Drawing.Point(55, 41);
            this.TaskDescriptionTxtBox.MaxLength = 32767;
            this.TaskDescriptionTxtBox.Multiline = true;
            this.TaskDescriptionTxtBox.Name = "TaskDescriptionTxtBox";
            this.TaskDescriptionTxtBox.PasswordChar = '\0';
            this.TaskDescriptionTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TaskDescriptionTxtBox.SelectedText = "";
            this.TaskDescriptionTxtBox.SelectionLength = 0;
            this.TaskDescriptionTxtBox.SelectionStart = 0;
            this.TaskDescriptionTxtBox.ShortcutsEnabled = true;
            this.TaskDescriptionTxtBox.Size = new System.Drawing.Size(492, 152);
            this.TaskDescriptionTxtBox.TabIndex = 3;
            this.TaskDescriptionTxtBox.Text = "metroTextBox2";
            this.TaskDescriptionTxtBox.UseSelectable = true;
            this.TaskDescriptionTxtBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TaskDescriptionTxtBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.DeleteMarkBtn);
            this.panel7.Controls.Add(this.AddMarkBtn);
            this.panel7.Controls.Add(this.listView1);
            this.panel7.Controls.Add(this.label3);
            this.panel7.Controls.Add(this.label4);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(604, 224);
            this.panel7.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label3.Location = new System.Drawing.Point(52, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(273, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "здесь можно добавить или удалить изображения";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(51, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Медиа";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(55, 53);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(492, 118);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // DeleteMarkBtn
            // 
            this.DeleteMarkBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DeleteMarkBtn.FlatAppearance.BorderSize = 0;
            this.DeleteMarkBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteMarkBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteMarkBtn.ForeColor = System.Drawing.Color.Black;
            this.DeleteMarkBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeleteMarkBtn.Location = new System.Drawing.Point(261, 177);
            this.DeleteMarkBtn.Name = "DeleteMarkBtn";
            this.DeleteMarkBtn.Size = new System.Drawing.Size(140, 30);
            this.DeleteMarkBtn.TabIndex = 24;
            this.DeleteMarkBtn.Text = "Удалить";
            this.DeleteMarkBtn.UseVisualStyleBackColor = false;
            this.DeleteMarkBtn.Click += new System.EventHandler(this.DeleteMarkBtn_Click);
            // 
            // AddMarkBtn
            // 
            this.AddMarkBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.AddMarkBtn.FlatAppearance.BorderSize = 0;
            this.AddMarkBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddMarkBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddMarkBtn.ForeColor = System.Drawing.Color.White;
            this.AddMarkBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddMarkBtn.Location = new System.Drawing.Point(407, 177);
            this.AddMarkBtn.Name = "AddMarkBtn";
            this.AddMarkBtn.Size = new System.Drawing.Size(140, 30);
            this.AddMarkBtn.TabIndex = 23;
            this.AddMarkBtn.Text = "Добавить";
            this.AddMarkBtn.UseVisualStyleBackColor = false;
            this.AddMarkBtn.Click += new System.EventHandler(this.AddMarkBtn_Click);
            // 
            // TaskEditPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.Name = "TaskEditPage";
            this.Load += new System.EventHandler(this.TaskEditPage_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel6;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button DeleteTask;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroTextBox TaskDescriptionTxtBox;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button DeleteMarkBtn;
        private System.Windows.Forms.Button AddMarkBtn;
    }
}
