
namespace Testo.Forms.Components
{
    partial class AnswerEditor
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
            this.selectorPanel = new System.Windows.Forms.Panel();
            this.TextPanel = new System.Windows.Forms.Panel();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.TextPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // selectorPanel
            // 
            this.selectorPanel.BackColor = System.Drawing.Color.White;
            this.selectorPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.selectorPanel.Location = new System.Drawing.Point(0, 0);
            this.selectorPanel.Name = "selectorPanel";
            this.selectorPanel.Size = new System.Drawing.Size(61, 58);
            this.selectorPanel.TabIndex = 0;
            this.selectorPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // TextPanel
            // 
            this.TextPanel.BackColor = System.Drawing.Color.White;
            this.TextPanel.Controls.Add(this.metroTextBox1);
            this.TextPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextPanel.Location = new System.Drawing.Point(61, 0);
            this.TextPanel.Name = "TextPanel";
            this.TextPanel.Size = new System.Drawing.Size(441, 58);
            this.TextPanel.TabIndex = 1;
            this.TextPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(368, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[] {
        "AnswerTxtBox"};
            this.metroTextBox1.Location = new System.Drawing.Point(15, 18);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(390, 23);
            this.metroTextBox1.TabIndex = 0;
            this.metroTextBox1.Text = "AnswerTxtBox";
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // AnswerEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TextPanel);
            this.Controls.Add(this.selectorPanel);
            this.Name = "AnswerEditor";
            this.Size = new System.Drawing.Size(502, 58);
            this.TextPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel selectorPanel;
        private System.Windows.Forms.Panel TextPanel;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
    }
}
