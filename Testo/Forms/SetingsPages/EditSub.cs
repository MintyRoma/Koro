using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Testo.Forms.SetingsPages
{
    public partial class EditSub : SetingsPanel
    {
        #region Private Data
        private bool allowremake = false;
        private bool showright = false;
        private bool randomstasks = false;
        private bool usetimer = false;
        private bool limittasks = false;
        private int timer = 0;
        private int tasksamount = 1;
        private int maxtsk = 1;
        private string name = "";
        #endregion

        #region Events
        public delegate void changedstate();
        public event changedstate ChangedStates;
        #endregion

        #region Public Data
        public bool AllowRemake
        {
            get { return allowremake; }
            set
            {
                allowremake = value;
                AllowReamakeChckBox.Checked = allowremake;
                ChangedStates?.Invoke();
            }
        }
        public bool ShowRight
        {
            get { return showright; }
            set
            {
                showright = value;
                ShowRightChckBox.Checked = showright;
                ChangedStates?.Invoke();
            }
        }
        public bool Randomize
        {
            get { return randomstasks; }
            set
            {
                randomstasks = value;
                RandomTasksChckBox.Checked = value;
                ChangedStates?.Invoke();
            }
        }
        public bool UseTimer
        {
            get { return usetimer; }
            set
            {
                usetimer = value;
                UseTimeChckBox.Checked = usetimer;
                if (!value)
                {
                    TimeLabel.Enabled = false;
                    TimeDescription.Enabled = false;
                    TimeUpDown.Enabled = false;
                }
                else
                {
                    TimeLabel.Enabled = true;
                    TimeDescription.Enabled = true;
                    TimeUpDown.Enabled = true;
                }
                ChangedStates?.Invoke();
            }
        }
        public bool LimitTasks
        {
            get { return limittasks; }
            set
            {
                limittasks = value;
                LimitTasksChckBox.Checked = limittasks;
                if (!value)
                {
                    AmountLabel.Enabled = false;
                    AmountDescription.Enabled = false;
                    TasksAmountUpDown.Enabled = false;
                }
                else
                {
                    AmountLabel.Enabled = true;
                    AmountDescription.Enabled = true;
                    TasksAmountUpDown.Enabled = true;
                }
                ChangedStates?.Invoke();
            }
        }
        public int Timer
        {
            get
            {
                return timer;
            }
            set
            {
                timer = value;
                TimeUpDown.Value = timer;
                ChangedStates?.Invoke();
            }
        }
        public int TasksAmount
        {
            get
            {
                return tasksamount;
            }
            set
            {
                tasksamount = value;
                TasksAmountUpDown.Value = tasksamount;
                ChangedStates?.Invoke();
            }
        }
        public int MaxTasks
        {
            private get
            {
                return maxtsk;
            }
            set
            {
                TasksAmountUpDown.Maximum = value;
                maxtsk = value;
                ChangedStates?.Invoke();
            }
            
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                ChangedStates?.Invoke();
            }
        }
        #endregion

        //Constructor
        public EditSub()
        {
            InitializeComponent();
            UseTimer = false;
            LimitTasks = false;
        }

        #region Functions
        private void EditSub_Load(object sender, EventArgs e)
        {

        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            AllowRemake = AllowReamakeChckBox.Checked;
        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void Label9_Click(object sender, EventArgs e)
        {

        }

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UseTimeChckBox_CheckedChanged(object sender, EventArgs e)
        {
            UseTimer = UseTimeChckBox.Checked;
        }

        private void ShowRightChckBox_CheckedChanged(object sender, EventArgs e)
        {
            ShowRight = ShowRightChckBox.Checked;
        }

        private void RandomTasksChckBox_CheckedChanged(object sender, EventArgs e)
        {
            Randomize = RandomTasksChckBox.Checked;
        }

        private void LimitTasksChckBox_CheckedChanged(object sender, EventArgs e)
        {
            LimitTasks = LimitTasksChckBox.Checked;
        }

        private void NameTxtBox_Click(object sender, EventArgs e)
        {

        }

        private void NameTxtBox_Leave(object sender, EventArgs e)
        {
            Name = NameTxtBox.Text;
        }
        #endregion
    }
}
