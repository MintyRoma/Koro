
namespace Testo.Forms.SetingsPages
{
    partial class MarksSetup
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.TypeOfMarks = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.ElementsPanel = new System.Windows.Forms.Panel();
            this.MarkInfoPanel = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.AmountUpDown = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.NameTxtBox = new MetroFramework.Controls.MetroTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.MarksListBox = new System.Windows.Forms.ListBox();
            this.DeleteMarkBtn = new System.Windows.Forms.Button();
            this.AddMarkBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.ElementsPanel.SuspendLayout();
            this.MarkInfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AmountUpDown)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.TypeOfMarks);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(604, 105);
            this.panel2.TabIndex = 6;
            // 
            // TypeOfMarks
            // 
            this.TypeOfMarks.Enabled = false;
            this.TypeOfMarks.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TypeOfMarks.FormattingEnabled = true;
            this.TypeOfMarks.Items.AddRange(new object[] {
            "Процентное",
            "Количественное"});
            this.TypeOfMarks.Location = new System.Drawing.Point(55, 54);
            this.TypeOfMarks.Name = "TypeOfMarks";
            this.TypeOfMarks.Size = new System.Drawing.Size(507, 29);
            this.TypeOfMarks.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label4.Location = new System.Drawing.Point(52, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Метод оценки теста.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(51, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Метод оценивания";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.metroLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(604, 40);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(55, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(73, 25);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Оценки";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ElementsPanel
            // 
            this.ElementsPanel.AutoScroll = true;
            this.ElementsPanel.Controls.Add(this.MarkInfoPanel);
            this.ElementsPanel.Controls.Add(this.panel3);
            this.ElementsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ElementsPanel.Location = new System.Drawing.Point(0, 145);
            this.ElementsPanel.Name = "ElementsPanel";
            this.ElementsPanel.Size = new System.Drawing.Size(604, 536);
            this.ElementsPanel.TabIndex = 8;
            this.ElementsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ElementsPanel_Paint);
            // 
            // MarkInfoPanel
            // 
            this.MarkInfoPanel.Controls.Add(this.label9);
            this.MarkInfoPanel.Controls.Add(this.AmountUpDown);
            this.MarkInfoPanel.Controls.Add(this.label8);
            this.MarkInfoPanel.Controls.Add(this.NameTxtBox);
            this.MarkInfoPanel.Controls.Add(this.label6);
            this.MarkInfoPanel.Controls.Add(this.label7);
            this.MarkInfoPanel.Controls.Add(this.label5);
            this.MarkInfoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MarkInfoPanel.Location = new System.Drawing.Point(0, 349);
            this.MarkInfoPanel.Name = "MarkInfoPanel";
            this.MarkInfoPanel.Size = new System.Drawing.Size(604, 168);
            this.MarkInfoPanel.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(499, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 21);
            this.label9.TabIndex = 11;
            this.label9.Text = "%";
            // 
            // AmountUpDown
            // 
            this.AmountUpDown.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AmountUpDown.Location = new System.Drawing.Point(417, 115);
            this.AmountUpDown.Name = "AmountUpDown";
            this.AmountUpDown.Size = new System.Drawing.Size(76, 29);
            this.AmountUpDown.TabIndex = 10;
            this.AmountUpDown.Enter += new System.EventHandler(this.AmountUpDown_Enter);
            this.AmountUpDown.Leave += new System.EventHandler(this.AmountUpDown_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label8.Location = new System.Drawing.Point(53, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(260, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "После какого результата отображается оценка";
            // 
            // NameTxtBox
            // 
            // 
            // 
            // 
            this.NameTxtBox.CustomButton.Image = null;
            this.NameTxtBox.CustomButton.Location = new System.Drawing.Point(479, 1);
            this.NameTxtBox.CustomButton.Name = "";
            this.NameTxtBox.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.NameTxtBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.NameTxtBox.CustomButton.TabIndex = 1;
            this.NameTxtBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.NameTxtBox.CustomButton.UseSelectable = true;
            this.NameTxtBox.CustomButton.Visible = false;
            this.NameTxtBox.Lines = new string[0];
            this.NameTxtBox.Location = new System.Drawing.Point(55, 62);
            this.NameTxtBox.MaxLength = 32767;
            this.NameTxtBox.Name = "NameTxtBox";
            this.NameTxtBox.PasswordChar = '\0';
            this.NameTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.NameTxtBox.SelectedText = "";
            this.NameTxtBox.SelectionLength = 0;
            this.NameTxtBox.SelectionStart = 0;
            this.NameTxtBox.ShortcutsEnabled = true;
            this.NameTxtBox.Size = new System.Drawing.Size(507, 29);
            this.NameTxtBox.TabIndex = 8;
            this.NameTxtBox.UseSelectable = true;
            this.NameTxtBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.NameTxtBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.NameTxtBox.Click += new System.EventHandler(this.NameTxtBox_Click);
            this.NameTxtBox.Enter += new System.EventHandler(this.NameTxtBox_Enter);
            this.NameTxtBox.Leave += new System.EventHandler(this.NameTxtBox_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label6.Location = new System.Drawing.Point(53, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(282, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Оно будет отображаться после прохождения теста";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(52, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 21);
            this.label7.TabIndex = 7;
            this.label7.Text = "Название оценки";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(52, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 21);
            this.label5.TabIndex = 5;
            this.label5.Text = "Результат";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.MarksListBox);
            this.panel3.Controls.Add(this.DeleteMarkBtn);
            this.panel3.Controls.Add(this.AddMarkBtn);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(604, 349);
            this.panel3.TabIndex = 0;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // MarksListBox
            // 
            this.MarksListBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.MarksListBox.FormattingEnabled = true;
            this.MarksListBox.ItemHeight = 21;
            this.MarksListBox.Location = new System.Drawing.Point(56, 58);
            this.MarksListBox.Name = "MarksListBox";
            this.MarksListBox.Size = new System.Drawing.Size(360, 277);
            this.MarksListBox.TabIndex = 23;
            this.MarksListBox.SelectedValueChanged += new System.EventHandler(this.MarksListBox_SelectedValueChanged);
            // 
            // DeleteMarkBtn
            // 
            this.DeleteMarkBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DeleteMarkBtn.FlatAppearance.BorderSize = 0;
            this.DeleteMarkBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteMarkBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteMarkBtn.ForeColor = System.Drawing.Color.Black;
            this.DeleteMarkBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeleteMarkBtn.Location = new System.Drawing.Point(422, 94);
            this.DeleteMarkBtn.Name = "DeleteMarkBtn";
            this.DeleteMarkBtn.Size = new System.Drawing.Size(140, 30);
            this.DeleteMarkBtn.TabIndex = 22;
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
            this.AddMarkBtn.Location = new System.Drawing.Point(422, 58);
            this.AddMarkBtn.Name = "AddMarkBtn";
            this.AddMarkBtn.Size = new System.Drawing.Size(140, 30);
            this.AddMarkBtn.TabIndex = 21;
            this.AddMarkBtn.Text = "Добавить";
            this.AddMarkBtn.UseVisualStyleBackColor = false;
            this.AddMarkBtn.Click += new System.EventHandler(this.AddMarkBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label1.Location = new System.Drawing.Point(53, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Здесь можно создавать и удалять оценки";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(52, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Список оценок";
            // 
            // MarksSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ElementsPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MarksSetup";
            this.Size = new System.Drawing.Size(604, 681);
            this.Load += new System.EventHandler(this.MarksSetup_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ElementsPanel.ResumeLayout(false);
            this.MarkInfoPanel.ResumeLayout(false);
            this.MarkInfoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AmountUpDown)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Panel ElementsPanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button DeleteMarkBtn;
        private System.Windows.Forms.Button AddMarkBtn;
        private System.Windows.Forms.Panel MarkInfoPanel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private MetroFramework.Controls.MetroTextBox NameTxtBox;
        private System.Windows.Forms.NumericUpDown AmountUpDown;
        private System.Windows.Forms.ListBox MarksListBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox TypeOfMarks;
    }
}
