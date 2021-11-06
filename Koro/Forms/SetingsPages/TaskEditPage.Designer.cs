namespace Koro.Forms.SetingsPages
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
            this.TypeSelector = new MetroFramework.Controls.MetroComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TaskDescriptionTxtBox = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.NameTxtBox = new MetroFramework.Controls.MetroTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DeleteTaskPanel = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.DeleteTask = new System.Windows.Forms.Button();
            this.EditAnswerNamePanel = new System.Windows.Forms.Panel();
            this.AnswerRightPanel = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.AnswerUpDown = new System.Windows.Forms.NumericUpDown();
            this.AnswerCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.AnswerRadioBtn = new MetroFramework.Controls.MetroRadioButton();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.AnswerNameTxtbox = new MetroFramework.Controls.MetroTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.AnswersListBox = new System.Windows.Forms.ListBox();
            this.DeleteAnswerBtn = new System.Windows.Forms.Button();
            this.AddAnswerBtn = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.DeleteMediaBtn = new System.Windows.Forms.Button();
            this.AddMediaBtn = new System.Windows.Forms.Button();
            this.ImgsListView = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.DeleteTaskPanel.SuspendLayout();
            this.EditAnswerNamePanel.SuspendLayout();
            this.AnswerRightPanel.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AnswerUpDown)).BeginInit();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.TypeSelector);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 233);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(604, 102);
            this.panel4.TabIndex = 8;
            // 
            // TypeSelector
            // 
            this.TypeSelector.FormattingEnabled = true;
            this.TypeSelector.ItemHeight = 23;
            this.TypeSelector.Items.AddRange(new object[] {
            "Строка",
            "Выбор одного",
            "Выбор нескольких",
            "Порядок"});
            this.TypeSelector.Location = new System.Drawing.Point(55, 53);
            this.TypeSelector.Name = "TypeSelector";
            this.TypeSelector.Size = new System.Drawing.Size(492, 29);
            this.TypeSelector.TabIndex = 3;
            this.TypeSelector.UseSelectable = true;
            this.TypeSelector.SelectedIndexChanged += new System.EventHandler(this.TypeSelector_SelectedIndexChanged);
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
            this.TaskDescriptionTxtBox.Click += new System.EventHandler(this.TaskDescriptionTxtBox_Click);
            this.TaskDescriptionTxtBox.Leave += new System.EventHandler(this.TaskDescriptionTxtBox_Leave);
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
            this.panel5.Controls.Add(this.NameTxtBox);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 62);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(604, 88);
            this.panel5.TabIndex = 6;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // NameTxtBox
            // 
            // 
            // 
            // 
            this.NameTxtBox.CustomButton.Image = null;
            this.NameTxtBox.CustomButton.Location = new System.Drawing.Point(470, 1);
            this.NameTxtBox.CustomButton.Name = "";
            this.NameTxtBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.NameTxtBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.NameTxtBox.CustomButton.TabIndex = 1;
            this.NameTxtBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.NameTxtBox.CustomButton.UseSelectable = true;
            this.NameTxtBox.CustomButton.Visible = false;
            this.NameTxtBox.Lines = new string[] {
        "Вопрос #"};
            this.NameTxtBox.Location = new System.Drawing.Point(55, 49);
            this.NameTxtBox.MaxLength = 32767;
            this.NameTxtBox.Name = "NameTxtBox";
            this.NameTxtBox.PasswordChar = '\0';
            this.NameTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.NameTxtBox.SelectedText = "";
            this.NameTxtBox.SelectionLength = 0;
            this.NameTxtBox.SelectionStart = 0;
            this.NameTxtBox.ShortcutsEnabled = true;
            this.NameTxtBox.Size = new System.Drawing.Size(492, 23);
            this.NameTxtBox.TabIndex = 3;
            this.NameTxtBox.Text = "Вопрос #";
            this.NameTxtBox.UseSelectable = true;
            this.NameTxtBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.NameTxtBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.NameTxtBox.Click += new System.EventHandler(this.NameTxtBox_Click);
            this.NameTxtBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.NameTxtBox_KeyUp);
            this.NameTxtBox.Leave += new System.EventHandler(this.NameTxtBox_Leave);
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
            // panel2
            // 
            this.panel2.Controls.Add(this.DeleteTaskPanel);
            this.panel2.Controls.Add(this.EditAnswerNamePanel);
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 354);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(604, 846);
            this.panel2.TabIndex = 10;
            // 
            // DeleteTaskPanel
            // 
            this.DeleteTaskPanel.Controls.Add(this.label15);
            this.DeleteTaskPanel.Controls.Add(this.label16);
            this.DeleteTaskPanel.Controls.Add(this.DeleteTask);
            this.DeleteTaskPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.DeleteTaskPanel.Location = new System.Drawing.Point(0, 722);
            this.DeleteTaskPanel.Name = "DeleteTaskPanel";
            this.DeleteTaskPanel.Size = new System.Drawing.Size(604, 92);
            this.DeleteTaskPanel.TabIndex = 13;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.label15.Location = new System.Drawing.Point(52, 44);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(242, 26);
            this.label15.TabIndex = 31;
            this.label15.Text = "Удаляет задание из базы заданий предмета!\r\nДействие отменить нельзя!";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            this.label16.Location = new System.Drawing.Point(51, 23);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(144, 21);
            this.label16.TabIndex = 32;
            this.label16.Text = "Удаление задания";
            // 
            // DeleteTask
            // 
            this.DeleteTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            this.DeleteTask.FlatAppearance.BorderSize = 0;
            this.DeleteTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteTask.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteTask.ForeColor = System.Drawing.Color.White;
            this.DeleteTask.Location = new System.Drawing.Point(355, 32);
            this.DeleteTask.Name = "DeleteTask";
            this.DeleteTask.Size = new System.Drawing.Size(192, 32);
            this.DeleteTask.TabIndex = 10;
            this.DeleteTask.Text = "Удалить задание";
            this.DeleteTask.UseVisualStyleBackColor = false;
            this.DeleteTask.Click += new System.EventHandler(this.DeleteTask_Click);
            // 
            // EditAnswerNamePanel
            // 
            this.EditAnswerNamePanel.Controls.Add(this.AnswerRightPanel);
            this.EditAnswerNamePanel.Controls.Add(this.label13);
            this.EditAnswerNamePanel.Controls.Add(this.AnswerNameTxtbox);
            this.EditAnswerNamePanel.Controls.Add(this.label11);
            this.EditAnswerNamePanel.Controls.Add(this.label12);
            this.EditAnswerNamePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.EditAnswerNamePanel.Location = new System.Drawing.Point(0, 569);
            this.EditAnswerNamePanel.Name = "EditAnswerNamePanel";
            this.EditAnswerNamePanel.Size = new System.Drawing.Size(604, 153);
            this.EditAnswerNamePanel.TabIndex = 11;
            this.EditAnswerNamePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.EditAnswerNamePanel_Paint);
            // 
            // AnswerRightPanel
            // 
            this.AnswerRightPanel.Controls.Add(this.panel10);
            this.AnswerRightPanel.Controls.Add(this.label14);
            this.AnswerRightPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AnswerRightPanel.Location = new System.Drawing.Point(0, 89);
            this.AnswerRightPanel.Name = "AnswerRightPanel";
            this.AnswerRightPanel.Size = new System.Drawing.Size(604, 64);
            this.AnswerRightPanel.TabIndex = 33;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.AnswerUpDown);
            this.panel10.Controls.Add(this.AnswerCheckBox);
            this.panel10.Controls.Add(this.AnswerRadioBtn);
            this.panel10.Location = new System.Drawing.Point(459, 1);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(88, 96);
            this.panel10.TabIndex = 34;
            // 
            // AnswerUpDown
            // 
            this.AnswerUpDown.Dock = System.Windows.Forms.DockStyle.Top;
            this.AnswerUpDown.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AnswerUpDown.Location = new System.Drawing.Point(0, 50);
            this.AnswerUpDown.Name = "AnswerUpDown";
            this.AnswerUpDown.Size = new System.Drawing.Size(88, 29);
            this.AnswerUpDown.TabIndex = 11;
            this.AnswerUpDown.Leave += new System.EventHandler(this.AnswerUpDown_Leave);
            // 
            // AnswerCheckBox
            // 
            this.AnswerCheckBox.AutoSize = true;
            this.AnswerCheckBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.AnswerCheckBox.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.AnswerCheckBox.Location = new System.Drawing.Point(0, 25);
            this.AnswerCheckBox.Name = "AnswerCheckBox";
            this.AnswerCheckBox.Size = new System.Drawing.Size(88, 25);
            this.AnswerCheckBox.TabIndex = 1;
            this.AnswerCheckBox.Text = " ";
            this.AnswerCheckBox.UseSelectable = true;
            this.AnswerCheckBox.CheckedChanged += new System.EventHandler(this.AnswerCheckBox_CheckedChanged);
            // 
            // AnswerRadioBtn
            // 
            this.AnswerRadioBtn.AutoSize = true;
            this.AnswerRadioBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.AnswerRadioBtn.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.AnswerRadioBtn.Location = new System.Drawing.Point(0, 0);
            this.AnswerRadioBtn.Name = "AnswerRadioBtn";
            this.AnswerRadioBtn.Size = new System.Drawing.Size(88, 25);
            this.AnswerRadioBtn.TabIndex = 0;
            this.AnswerRadioBtn.Text = " ";
            this.AnswerRadioBtn.UseSelectable = true;
            this.AnswerRadioBtn.CheckedChanged += new System.EventHandler(this.AnswerRadioBtn_CheckedChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(51, 3);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(130, 21);
            this.label14.TabIndex = 33;
            this.label14.Text = "Значение ответа";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(51, 43);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(152, 21);
            this.label13.TabIndex = 32;
            this.label13.Text = "Содержание ответа";
            // 
            // AnswerNameTxtbox
            // 
            // 
            // 
            // 
            this.AnswerNameTxtbox.CustomButton.Image = null;
            this.AnswerNameTxtbox.CustomButton.Location = new System.Drawing.Point(470, 1);
            this.AnswerNameTxtbox.CustomButton.Name = "";
            this.AnswerNameTxtbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.AnswerNameTxtbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.AnswerNameTxtbox.CustomButton.TabIndex = 1;
            this.AnswerNameTxtbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.AnswerNameTxtbox.CustomButton.UseSelectable = true;
            this.AnswerNameTxtbox.CustomButton.Visible = false;
            this.AnswerNameTxtbox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.AnswerNameTxtbox.Lines = new string[] {
        "Ответ"};
            this.AnswerNameTxtbox.Location = new System.Drawing.Point(55, 67);
            this.AnswerNameTxtbox.MaxLength = 32767;
            this.AnswerNameTxtbox.Name = "AnswerNameTxtbox";
            this.AnswerNameTxtbox.PasswordChar = '\0';
            this.AnswerNameTxtbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.AnswerNameTxtbox.SelectedText = "";
            this.AnswerNameTxtbox.SelectionLength = 0;
            this.AnswerNameTxtbox.SelectionStart = 0;
            this.AnswerNameTxtbox.ShortcutsEnabled = true;
            this.AnswerNameTxtbox.Size = new System.Drawing.Size(492, 23);
            this.AnswerNameTxtbox.TabIndex = 31;
            this.AnswerNameTxtbox.Text = "Ответ";
            this.AnswerNameTxtbox.UseSelectable = true;
            this.AnswerNameTxtbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.AnswerNameTxtbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.AnswerNameTxtbox.Click += new System.EventHandler(this.AnswerNameTxtbox_Click);
            this.AnswerNameTxtbox.Enter += new System.EventHandler(this.AnswerNameTxtbox_Enter);
            this.AnswerNameTxtbox.Leave += new System.EventHandler(this.AnswerNameTxtbox_Leave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label11.Location = new System.Drawing.Point(52, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(339, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "Установка отображаемого значения и выбор верного ответа";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(51, 3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(179, 21);
            this.label12.TabIndex = 30;
            this.label12.Text = "Редактирование ответа";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.label9);
            this.panel8.Controls.Add(this.label10);
            this.panel8.Controls.Add(this.AnswersListBox);
            this.panel8.Controls.Add(this.DeleteAnswerBtn);
            this.panel8.Controls.Add(this.AddAnswerBtn);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 335);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(604, 234);
            this.panel8.TabIndex = 10;
            this.panel8.Paint += new System.Windows.Forms.PaintEventHandler(this.panel8_Paint);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label9.Location = new System.Drawing.Point(52, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Список ответов";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(51, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 21);
            this.label10.TabIndex = 28;
            this.label10.Text = "Ответы";
            // 
            // AnswersListBox
            // 
            this.AnswersListBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.AnswersListBox.FormattingEnabled = true;
            this.AnswersListBox.ItemHeight = 21;
            this.AnswersListBox.Location = new System.Drawing.Point(55, 50);
            this.AnswersListBox.Name = "AnswersListBox";
            this.AnswersListBox.Size = new System.Drawing.Size(346, 172);
            this.AnswersListBox.TabIndex = 26;
            this.AnswersListBox.SelectedIndexChanged += new System.EventHandler(this.AnswersListBox_SelectedIndexChanged);
            // 
            // DeleteAnswerBtn
            // 
            this.DeleteAnswerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DeleteAnswerBtn.FlatAppearance.BorderSize = 0;
            this.DeleteAnswerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteAnswerBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteAnswerBtn.ForeColor = System.Drawing.Color.Black;
            this.DeleteAnswerBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeleteAnswerBtn.Location = new System.Drawing.Point(407, 86);
            this.DeleteAnswerBtn.Name = "DeleteAnswerBtn";
            this.DeleteAnswerBtn.Size = new System.Drawing.Size(140, 30);
            this.DeleteAnswerBtn.TabIndex = 25;
            this.DeleteAnswerBtn.Text = "Удалить";
            this.DeleteAnswerBtn.UseVisualStyleBackColor = false;
            this.DeleteAnswerBtn.Click += new System.EventHandler(this.DeleteAnswerBtn_Click);
            // 
            // AddAnswerBtn
            // 
            this.AddAnswerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.AddAnswerBtn.FlatAppearance.BorderSize = 0;
            this.AddAnswerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddAnswerBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddAnswerBtn.ForeColor = System.Drawing.Color.White;
            this.AddAnswerBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddAnswerBtn.Location = new System.Drawing.Point(407, 50);
            this.AddAnswerBtn.Name = "AddAnswerBtn";
            this.AddAnswerBtn.Size = new System.Drawing.Size(140, 30);
            this.AddAnswerBtn.TabIndex = 24;
            this.AddAnswerBtn.Text = "Добавить";
            this.AddAnswerBtn.UseVisualStyleBackColor = false;
            this.AddAnswerBtn.Click += new System.EventHandler(this.AddAnswerBtn_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.DeleteMediaBtn);
            this.panel7.Controls.Add(this.AddMediaBtn);
            this.panel7.Controls.Add(this.ImgsListView);
            this.panel7.Controls.Add(this.label3);
            this.panel7.Controls.Add(this.label4);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(604, 233);
            this.panel7.TabIndex = 9;
            // 
            // DeleteMediaBtn
            // 
            this.DeleteMediaBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DeleteMediaBtn.FlatAppearance.BorderSize = 0;
            this.DeleteMediaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteMediaBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteMediaBtn.ForeColor = System.Drawing.Color.Black;
            this.DeleteMediaBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeleteMediaBtn.Location = new System.Drawing.Point(261, 197);
            this.DeleteMediaBtn.Name = "DeleteMediaBtn";
            this.DeleteMediaBtn.Size = new System.Drawing.Size(140, 30);
            this.DeleteMediaBtn.TabIndex = 24;
            this.DeleteMediaBtn.Text = "Удалить";
            this.DeleteMediaBtn.UseVisualStyleBackColor = false;
            this.DeleteMediaBtn.Click += new System.EventHandler(this.DeleteMediaBtn_Click);
            // 
            // AddMediaBtn
            // 
            this.AddMediaBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.AddMediaBtn.FlatAppearance.BorderSize = 0;
            this.AddMediaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddMediaBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddMediaBtn.ForeColor = System.Drawing.Color.White;
            this.AddMediaBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddMediaBtn.Location = new System.Drawing.Point(407, 197);
            this.AddMediaBtn.Name = "AddMediaBtn";
            this.AddMediaBtn.Size = new System.Drawing.Size(140, 30);
            this.AddMediaBtn.TabIndex = 23;
            this.AddMediaBtn.Text = "Добавить";
            this.AddMediaBtn.UseVisualStyleBackColor = false;
            this.AddMediaBtn.Click += new System.EventHandler(this.AddMediaBtn_Click);
            // 
            // ImgsListView
            // 
            this.ImgsListView.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.ImgsListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImgsListView.HideSelection = false;
            this.ImgsListView.Location = new System.Drawing.Point(55, 40);
            this.ImgsListView.Name = "ImgsListView";
            this.ImgsListView.Size = new System.Drawing.Size(492, 151);
            this.ImgsListView.TabIndex = 5;
            this.ImgsListView.UseCompatibleStateImageBehavior = false;
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
            // TaskEditPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.Name = "TaskEditPage";
            this.Size = new System.Drawing.Size(604, 1200);
            this.Load += new System.EventHandler(this.TaskEditPage_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.DeleteTaskPanel.ResumeLayout(false);
            this.DeleteTaskPanel.PerformLayout();
            this.EditAnswerNamePanel.ResumeLayout(false);
            this.EditAnswerNamePanel.PerformLayout();
            this.AnswerRightPanel.ResumeLayout(false);
            this.AnswerRightPanel.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AnswerUpDown)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
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
        private MetroFramework.Controls.MetroTextBox NameTxtBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel6;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroComboBox TypeSelector;
        private MetroFramework.Controls.MetroTextBox TaskDescriptionTxtBox;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.ListView ImgsListView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button DeleteMediaBtn;
        private System.Windows.Forms.Button AddMediaBtn;
        private System.Windows.Forms.Panel EditAnswerNamePanel;
        private MetroFramework.Controls.MetroTextBox AnswerNameTxtbox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox AnswersListBox;
        private System.Windows.Forms.Button DeleteAnswerBtn;
        private System.Windows.Forms.Button AddAnswerBtn;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel DeleteTaskPanel;
        private System.Windows.Forms.Button DeleteTask;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel AnswerRightPanel;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.NumericUpDown AnswerUpDown;
        private MetroFramework.Controls.MetroCheckBox AnswerCheckBox;
        private MetroFramework.Controls.MetroRadioButton AnswerRadioBtn;
        private System.Windows.Forms.Label label14;
    }
}
