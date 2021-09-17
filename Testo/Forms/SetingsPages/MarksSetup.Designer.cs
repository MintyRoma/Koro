
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
            this.panel5 = new System.Windows.Forms.Panel();
            this.AddMarkBtn = new System.Windows.Forms.Button();
            this.TypeOfMarks = new MetroFramework.Controls.MetroComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.ElementsPanel = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.TypeOfMarks);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(604, 151);
            this.panel2.TabIndex = 6;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.AddMarkBtn);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 92);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(604, 59);
            this.panel5.TabIndex = 4;
            // 
            // AddMarkBtn
            // 
            this.AddMarkBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.AddMarkBtn.FlatAppearance.BorderSize = 0;
            this.AddMarkBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddMarkBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddMarkBtn.ForeColor = System.Drawing.Color.White;
            this.AddMarkBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddMarkBtn.Location = new System.Drawing.Point(354, 15);
            this.AddMarkBtn.Name = "AddMarkBtn";
            this.AddMarkBtn.Size = new System.Drawing.Size(173, 30);
            this.AddMarkBtn.TabIndex = 20;
            this.AddMarkBtn.Text = "Добавить";
            this.AddMarkBtn.UseVisualStyleBackColor = false;
            this.AddMarkBtn.Click += new System.EventHandler(this.AddMarkBtn_Click);
            // 
            // TypeOfMarks
            // 
            this.TypeOfMarks.FormattingEnabled = true;
            this.TypeOfMarks.ItemHeight = 23;
            this.TypeOfMarks.Items.AddRange(new object[] {
            "Количественное",
            "Процентное"});
            this.TypeOfMarks.Location = new System.Drawing.Point(55, 51);
            this.TypeOfMarks.Name = "TypeOfMarks";
            this.TypeOfMarks.Size = new System.Drawing.Size(472, 29);
            this.TypeOfMarks.TabIndex = 3;
            this.TypeOfMarks.UseSelectable = true;
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
            this.ElementsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ElementsPanel.Location = new System.Drawing.Point(0, 191);
            this.ElementsPanel.Name = "ElementsPanel";
            this.ElementsPanel.Size = new System.Drawing.Size(604, 650);
            this.ElementsPanel.TabIndex = 8;
            // 
            // MarksSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ElementsPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MarksSetup";
            this.Load += new System.EventHandler(this.MarksSetup_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox TypeOfMarks;
        private System.Windows.Forms.Panel ElementsPanel;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button AddMarkBtn;
    }
}
