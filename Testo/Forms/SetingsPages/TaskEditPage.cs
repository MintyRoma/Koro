using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Testo.Classes;
using System.IO;
using Newtonsoft.Json;

namespace Testo.Forms.SetingsPages
{
    public partial class TaskEditPage : SetingsPanel, IEditSubForm
    {
        private string jsonfile;
        private string RuntimeDir = @".\runtime\tasks\";

        private string name;
        private string description;
        private List<string> media = new List<string>();
        private TaskType type = TaskType.Checkbox;
        private List<string> answers = new List<string>();
        private List<string> right = new List<string>();

        public TaskEditPage(string filename)
        {
            name = filename;
            jsonfile = RuntimeDir + filename + ".json";
            InitializeComponent();
            Import();
            ConstructData();
        }

        private void ConstructData()
        {
            Name
        }

        private void TaskEditPage_Load(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddMarkBtn_Click(object sender, EventArgs e)
        {

        }

        private void DeleteMarkBtn_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        public bool Import()
        {
            try
            {
                string manfile = File.ReadAllText(jsonfile);
                dynamic manif = JsonConvert.DeserializeObject(manfile);
                switch ((string)manif.type)
                {
                    case "checkbox":
                        type = TaskType.Checkbox;
                        break;
                    case "string":
                        type = TaskType.String;
                        break;
                    case "order":
                        type = TaskType.Order;
                        break;
                    default:
                        type = TaskType.Radio;
                        break;
                }
                foreach (string pic in manif.media) media.Add(pic);
                foreach (string ans in manif.answers) answers.Add(ans);
                foreach (string rig in manif.right) right.Add(rig);
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
                TaskManifest manif = new TaskManifest();
                manif.type = "";
                switch (type)
                {
                    case TaskType.Checkbox:
                        manif.type = "checkbox";
                        break;
                    case TaskType.Order:
                        manif.type = "order";
                        break;
                    case TaskType.String:
                        manif.type = "string";
                        break;
                    default:
                        manif.type = "radio";
                        break;
                }
                manif.description = description;
                manif.media = media;
                manif.answers = answers;
                manif.right = right;
                string manfile = JsonConvert.SerializeObject(manif);
                File.WriteAllText(jsonfile+".upd", manfile);
                File.Delete(jsonfile);
                File.Move(jsonfile + ".upd", jsonfile);
                return true;
            }
            catch (Exception ex)
            {
                if (File.Exists(jsonfile + ".upd")) File.Delete(jsonfile + ".upd");
                return false;
            };
        }

        public void Reconstruct()
        {
            File.WriteAllBytes(jsonfile, Testo.Properties.Resources.marks);
            Import();
        }
    }
}
