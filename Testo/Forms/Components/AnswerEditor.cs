using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Testo.Classes;
using MetroFramework.Controls;

namespace Testo.Forms.Components
{
    public partial class AnswerEditor : UserControl
    {
        public bool Selected => selected;
        private bool selected;

        public int OrderNum => ordernum;
        private int ordernum;


        public AnswerEditor(TaskType tsk)
        {
            InitializeComponent();
            switch (tsk)
            {
                case TaskType.Checkbox:
                    MetroCheckBox checkselector = new MetroCheckBox();
                    checkselector.Text = "";
                    checkselector.Location = new Point(25, 25);
                    selectorPanel.Controls.Add(checkselector);
                    checkselector.CheckedChanged += SelectorCheckedChanged;
                    break;
                case TaskType.Radio:
                    MetroRadioButton radselector = new MetroRadioButton();
                    radselector.Text = "";
                    radselector.Location = new Point(25, 25);
                    selectorPanel.Controls.Add(radselector);
                    break;
            }
        }

        private void SelectorCheckedChanged(object sender, EventArgs e)
        {
            if (sender is MetroCheckBox)
            {
                MetroCheckBox replica = (MetroCheckBox)sender;
                selected = replica.Checked;
            }
            if (sender is MetroRadioButton)
            {
                MetroRadioButton replica = (MetroRadioButton)sender;
                selected = replica.Checked;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
