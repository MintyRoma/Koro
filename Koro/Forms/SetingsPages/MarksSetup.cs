﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Koro.Classes;
using Koro.Forms.Components;

namespace Koro.Forms.SetingsPages
{
    public partial class MarksSetup : SetingsPanel, IEditSubForm
    {
        private string RuntimeDir = @".\runtime\";
        private List<Mark> marks = new List<Mark>();
        private MarkSystem system = MarkSystem.amount;
        private string oldName = "";
        private int oldamount = 0;
        
        public MarksSetup()
        {
            InitializeComponent();
            Import();
        }

        private void ConstructData()
        {
            MarksListBox.Items.Clear();
            foreach (Mark mark in marks)
            {
                MarksListBox.Items.Add(mark.Name);
            }
            TypeOfMarks.SelectedItem = "";
            switch (system)
            {
                case MarkSystem.percent:
                    TypeOfMarks.SelectedItem = "Процентное";
                    break;
                default:
                    TypeOfMarks.SelectedItem = "Количественное";
                    break;
            }
        }

        private void MarksSetup_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AddMarkBtn_Click(object sender, EventArgs e)
        {
            marks.Add(new Mark($"Оценка #{MarksListBox.Items.Count + 1}", 1));
            ConstructData();
        }

        public bool Import()
        {
            try
            {
                marks.Clear();
                string manfile = File.ReadAllText(RuntimeDir + @"\marks.json");
                dynamic manif = JsonConvert.DeserializeObject(manfile);
                switch ((string)manif.system)
                {
                    case "percent":
                        system = MarkSystem.percent;
                        break;
                    default:
                        system = MarkSystem.amount;
                        break;
                }
                foreach (dynamic mark in manif.marks)
                {
                    Mark mk = new Mark((string)mark.description,(double)Convert.ToDouble(mark.percentage));
                    marks.Add(mk);
                }
                ConstructData();
                MarkInfoPanel.Hide();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Export()
        {
            try
            {
                MarksManifest manif = new MarksManifest();
                manif.system = "";
                switch (system)
                {
                    case MarkSystem.percent:
                        manif.system = "percent";
                        break;
                    default:
                        manif.system = "amount";
                        break;
                }
                foreach (Mark mk in marks)
                {
                    dynamic mark = new ExpandoObject();
                    mark.description = mk.Name;
                    mark.percentage = mk.Percentage;
                    manif.marks.Add(mark);
                }
                string manfile = JsonConvert.SerializeObject(manif);
                File.WriteAllText(RuntimeDir + "\\marks.upd", manfile);
                File.Delete(RuntimeDir + "\\marks.json");
                File.Move(RuntimeDir + "\\marks.upd", RuntimeDir + "\\marks.json");
                return true;
            }
            catch (Exception ex)
            {
                if (File.Exists($"{RuntimeDir}+\\marks.upd")) File.Delete($"{RuntimeDir}+\\marks.upd");
                return false;
            }
        }

        public void Reconstruct()
        {
            File.WriteAllBytes(RuntimeDir + "\\marks.json", Koro.Properties.Resources.marks);
            Import();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MarksListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (MarksListBox.SelectedItem == null) return;
            string name = MarksListBox.SelectedItem.ToString();
            foreach(Mark mk in marks)
            {
                if (name == mk.Name)
                {
                    NameTxtBox.Text = mk.Name;
                    int percent = Convert.ToInt32(mk.Percentage * 100);
                    AmountUpDown.Value = percent;
                    MarkInfoPanel.Show();
                    return;
                }
            }
        }


        private void NameTxtBox_Enter(object sender, EventArgs e)
        {
            oldName = NameTxtBox.Text;
        }

        private void NameTxtBox_Leave(object sender, EventArgs e)
        {
            string newName = NameTxtBox.Text;
            if (newName == oldName) return;
            foreach (Mark mk in marks)
            {
                if (newName == mk.Name)
                {
                    NameTxtBox.Text = oldName;
                    MetroFramework.MetroMessageBox.Show(Parent.Parent, "Оценка с таким именем уже существует!", "Действие запрещено", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            foreach (Mark mk in marks)
            {
                if (oldName == mk.Name)
                {
                    mk.Name = newName;
                    break;
                }
            }
            ConstructData();
        }

        private void DeleteMarkBtn_Click(object sender, EventArgs e)
        {
            string mkname="";
            if (MarksListBox.SelectedItem != null) mkname = MarksListBox.SelectedItem.ToString();
            else return;
            if (mkname == null) return;
            Mark delete = new Mark();
            foreach (Mark mk in marks)
            {
                if (mk.Name == mkname)
                {
                    delete = mk;
                    break;
                }
            }
            if (NameTxtBox.Text == delete.Name) MarkInfoPanel.Hide();
            marks.Remove(delete);
            ConstructData();
        }

        private void AmountUpDown_Enter(object sender, EventArgs e)
        {
            oldamount = (int)AmountUpDown.Value;
        }

        private void AmountUpDown_Leave(object sender, EventArgs e)
        {
            double newAmount = (double)AmountUpDown.Value/100;
            string markname = NameTxtBox.Text;
            if (oldamount == newAmount) return;
            //Check if contains
            foreach (Mark mk in marks)
            {
                if (newAmount == mk.Percentage)
                {
                    AmountUpDown.Value = oldamount;
                    MetroFramework.MetroMessageBox.Show(Parent.Parent, $"Оценка с таким значением уже существует! \nОценка: {mk.Name}", "Действие запрещено", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            foreach (Mark mk in marks)
            {
                if (markname == mk.Name)
                {
                    mk.Percentage = newAmount;
                    break;
                }
            }
        }

        private void ElementsPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void NameTxtBox_Click(object sender, EventArgs e)
        {

        }

        private void AmountUpDown_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
