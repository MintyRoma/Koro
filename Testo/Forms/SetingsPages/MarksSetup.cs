using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Testo.Classes;
using Testo.Forms.Components;

namespace Testo.Forms.SetingsPages
{
    public partial class MarksSetup : SetingsPanel
    {
        public MarksSetup()
        {
            ImportMarks();
            InitializeComponent();
        }

        private void ImportMarks()
        {
            MarksManifest manifest = new MarksManifest();
        }

        private void MarksSetup_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AddMarkBtn_Click(object sender, EventArgs e)
        {
            NumericAnswerBox box = new NumericAnswerBox(true);
            box.Dock = DockStyle.Top;
            ElementsPanel.Controls.Add(box);
        }

    }
}
