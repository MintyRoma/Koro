using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Koro.Classes;

namespace Koro.Forms.Components
{
    public partial class NumericAnswerBox : UserControl, IAnswerEditor
    {
        string id;
        
        public NumericAnswerBox()
        {
            InitializeComponent();
        }

        public NumericAnswerBox(bool editable)
        {
            InitializeComponent();
            Guid newid = Guid.NewGuid();
            id = newid.ToString();
            textBox.ReadOnly = !editable;
        }

        public NumericAnswerBox(string GUID, string text, bool editable)
        {
            id = GUID;
            InitializeComponent();
            textBox.Text = text;
            textBox.ReadOnly = !editable;
        }

        public NumericAnswerBox(string GUID, string text, int value, bool editable)
        {
            id = GUID;
            InitializeComponent();
            textBox.Text = text;
            textBox.ReadOnly = !editable;
            numericUpDown.Value = value;
        }

        public int Limit
        {
            get
            {
                return (int)numericUpDown.Maximum;
            }
            set
            {
                if (value > 0) numericUpDown.Maximum = value; 
            }
        }

        public TaskType Type { get => TaskType.Order; }

        public object TakeResult()
        {
            return numericUpDown.Value;
        }

        override public string Text
        {
            get
            {
                return textBox.Text;
            }
            set
            {
                textBox.Text = value;
            }
        }

        public string ID =>id;

        private void InputPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TextPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
