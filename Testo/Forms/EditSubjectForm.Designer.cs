namespace Testo.Forms
{
    partial class EditSubjectForm
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
            this.menuPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TasksListBox = new System.Windows.Forms.ListBox();
            this.AddTaskBtn = new System.Windows.Forms.Button();
            this.ConfigPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.MarksBtn = new System.Windows.Forms.Button();
            this.SubjectsBtn = new System.Windows.Forms.Button();
            this.ProfileBtn = new System.Windows.Forms.Button();
            this.DetailsPanel = new System.Windows.Forms.Panel();
            this.menuPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.ConfigPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.White;
            this.menuPanel.Controls.Add(this.panel1);
            this.menuPanel.Controls.Add(this.AddTaskBtn);
            this.menuPanel.Controls.Add(this.ConfigPanel);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(20, 60);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(210, 516);
            this.menuPanel.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TasksListBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 164);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 311);
            this.panel1.TabIndex = 17;
            // 
            // TasksListBox
            // 
            this.TasksListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TasksListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TasksListBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TasksListBox.FormattingEnabled = true;
            this.TasksListBox.ItemHeight = 21;
            this.TasksListBox.Items.AddRange(new object[] {
            "TEST",
            "Test",
            "test"});
            this.TasksListBox.Location = new System.Drawing.Point(0, 0);
            this.TasksListBox.Name = "TasksListBox";
            this.TasksListBox.Size = new System.Drawing.Size(210, 311);
            this.TasksListBox.TabIndex = 15;
            this.TasksListBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // AddTaskBtn
            // 
            this.AddTaskBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.AddTaskBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AddTaskBtn.FlatAppearance.BorderSize = 0;
            this.AddTaskBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddTaskBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddTaskBtn.ForeColor = System.Drawing.Color.White;
            this.AddTaskBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddTaskBtn.Location = new System.Drawing.Point(0, 475);
            this.AddTaskBtn.Name = "AddTaskBtn";
            this.AddTaskBtn.Size = new System.Drawing.Size(210, 41);
            this.AddTaskBtn.TabIndex = 16;
            this.AddTaskBtn.Text = "Добавить задание";
            this.AddTaskBtn.UseVisualStyleBackColor = false;
            this.AddTaskBtn.Click += new System.EventHandler(this.AddTaskBtn_Click_2);
            // 
            // ConfigPanel
            // 
            this.ConfigPanel.AutoSize = true;
            this.ConfigPanel.Controls.Add(this.button1);
            this.ConfigPanel.Controls.Add(this.MarksBtn);
            this.ConfigPanel.Controls.Add(this.SubjectsBtn);
            this.ConfigPanel.Controls.Add(this.ProfileBtn);
            this.ConfigPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ConfigPanel.Location = new System.Drawing.Point(0, 0);
            this.ConfigPanel.Name = "ConfigPanel";
            this.ConfigPanel.Size = new System.Drawing.Size(210, 164);
            this.ConfigPanel.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.Silver;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 41);
            this.button1.TabIndex = 11;
            this.button1.Text = "Задания";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MarksBtn
            // 
            this.MarksBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.MarksBtn.FlatAppearance.BorderSize = 0;
            this.MarksBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MarksBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MarksBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.MarksBtn.Image = global::Testo.Properties.Resources.marksimg;
            this.MarksBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MarksBtn.Location = new System.Drawing.Point(0, 82);
            this.MarksBtn.Name = "MarksBtn";
            this.MarksBtn.Size = new System.Drawing.Size(210, 41);
            this.MarksBtn.TabIndex = 6;
            this.MarksBtn.Text = "Оценки";
            this.MarksBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MarksBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MarksBtn.UseVisualStyleBackColor = true;
            this.MarksBtn.Click += new System.EventHandler(this.History_Click);
            // 
            // SubjectsBtn
            // 
            this.SubjectsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubjectsBtn.FlatAppearance.BorderSize = 0;
            this.SubjectsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubjectsBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SubjectsBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.SubjectsBtn.Image = global::Testo.Properties.Resources.code;
            this.SubjectsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SubjectsBtn.Location = new System.Drawing.Point(0, 41);
            this.SubjectsBtn.Name = "SubjectsBtn";
            this.SubjectsBtn.Size = new System.Drawing.Size(210, 41);
            this.SubjectsBtn.TabIndex = 5;
            this.SubjectsBtn.Text = "Настройка предмета";
            this.SubjectsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SubjectsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SubjectsBtn.UseVisualStyleBackColor = true;
            this.SubjectsBtn.Click += new System.EventHandler(this.SubjectsBtn_Click);
            // 
            // ProfileBtn
            // 
            this.ProfileBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.ProfileBtn.FlatAppearance.BorderSize = 0;
            this.ProfileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProfileBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProfileBtn.ForeColor = System.Drawing.Color.Silver;
            this.ProfileBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ProfileBtn.Location = new System.Drawing.Point(0, 0);
            this.ProfileBtn.Name = "ProfileBtn";
            this.ProfileBtn.Size = new System.Drawing.Size(210, 41);
            this.ProfileBtn.TabIndex = 4;
            this.ProfileBtn.Text = "Настройки предмета";
            this.ProfileBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ProfileBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ProfileBtn.UseVisualStyleBackColor = true;
            // 
            // DetailsPanel
            // 
            this.DetailsPanel.AutoScroll = true;
            this.DetailsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DetailsPanel.Location = new System.Drawing.Point(230, 60);
            this.DetailsPanel.Name = "DetailsPanel";
            this.DetailsPanel.Size = new System.Drawing.Size(648, 516);
            this.DetailsPanel.TabIndex = 4;
            // 
            // EditSubjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 596);
            this.Controls.Add(this.DetailsPanel);
            this.Controls.Add(this.menuPanel);
            this.Name = "EditSubjectForm";
            this.Text = "Предмет";
            this.Load += new System.EventHandler(this.EditSubjectForm_Load);
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ConfigPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Panel DetailsPanel;
        private System.Windows.Forms.Panel ConfigPanel;
        private System.Windows.Forms.Button MarksBtn;
        private System.Windows.Forms.Button SubjectsBtn;
        private System.Windows.Forms.Button ProfileBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox TasksListBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button AddTaskBtn;
    }
}