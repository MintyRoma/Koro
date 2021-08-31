using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Testo.Classes;
using Testo.Forms.SetingsPages;
using System.IO;
using Newtonsoft.Json;


namespace Testo.Forms
{
    public partial class EditSubjectForm : MetroForm
    {
        public enum Type
        {
            Setup,
            Marks,
            Tasks
        }


        private Type mode = Type.Setup;
        public Type Mode 
        {
            get
            {
                return mode;
            }
            set
            {
                ChangeState();
                mode = value;
            }
        }

        private SubjectManifest Manifest = new SubjectManifest();
        private Task RntTask;
        private EditSub SubData;
        private MarksSetup MarkData;
        private string rntdir = Directory.GetCurrentDirectory() + "\\runtime";

        public EditSubjectForm()
        {
            InitializeComponent();
            if (!File.Exists("runtime/manifest.json"))
            {
                GenerateNewSubject();
            }
            UpdateTasksList();
            SubData = new EditSub();
            FillSubjectData();
            MarkData = new MarksSetup();
            FillMarkData();
            Mode = Type.Setup;
            
        }

        private void FillMarkData()
        {
            try
            {

            }
            catch (Exception ex)
            {

            }
        }

        private void FillSubjectData()
        {
            try
            {
                string manfile = File.ReadAllText(rntdir + @"\manifest.json");
                dynamic manifest = JsonConvert.DeserializeObject(manfile);
                SubData.Name = manifest.Name;
                SubData.Randomize = manifest.Randomize;
                SubData.ShowRight = manifest.ShowRight;
                SubData.UseTimer = manifest.UseTimer;
                SubData.AllowRemake = manifest.AllowRemake;
                SubData.LimitTasks = manifest.LimitTasks;
                SubData.Timer = manifest.Timer;
                SubData.TasksAmount = manifest.Tasks;
                SubData.MaxTasks = Directory.GetFiles(rntdir + @"\tasks\").Length;
                SubData.ChangedStates += RewriteManifest;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }

        private void RewriteManifest()
        {
            Manifest.AllowRemake = SubData.AllowRemake;
            Manifest.ShowRight = SubData.ShowRight;
            Manifest.UseTimer = SubData.UseTimer;
            Manifest.Randomize = SubData.Randomize;
            Manifest.LimitTasks = SubData.LimitTasks;
            Manifest.Timer = SubData.Timer;
            Manifest.Name = SubData.Name;
            string manfile = JsonConvert.SerializeObject(Manifest);
            File.WriteAllText(rntdir+"\\manifest.json", manfile);
        }

        private void ChangeState()
        {
            switch (Mode)
            {
                case Type.Setup:
                    DetailsPanel.Controls.Clear();
                    DetailsPanel.Controls.Add(SubData);
                    break;
                case Type.Marks:
                    DetailsPanel.Controls.Clear();
                    DetailsPanel.Controls.Add(MarkData);
                    break;
                case Type.Tasks:
                    break;
            }
        }

        private void UpdateTasksList()
        {
            TasksListBox.Items.Clear();
            string[] files = Directory.GetFiles(rntdir+"\\tasks");
            foreach(string f in files)
            {
                TasksListBox.Items.Add(f);
            }
        }

        private void GenerateNewSubject()
        {
            
            File.WriteAllBytes(rntdir+"\\manifest.json",Testo.Properties.Resources.manifest);
            File.WriteAllBytes(rntdir+"\\marks.json", Testo.Properties.Resources.marks);
            Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\runtime\\media");
            Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\runtime\\tasks");
        }

        public EditSubjectForm(Classes.Subject sub)
        {
            InitializeComponent();
        }

        private void EditSubjectForm_Load(object sender, EventArgs e)
        {

        }


        private void SubjectsBtn_Click(object sender, EventArgs e)
        {
            Mode = Type.Setup;
        }

        private void AddTaskBtn_Click_1(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddTaskBtn_Click_2(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int num = rnd.Next(0, 956633);
            string filename = $"Задание #{num}";
            TasksListBox.Items.Add(filename);
            File.WriteAllBytes(rntdir + $"\\tasks\\{filename}.json", Testo.Properties.Resources.manifest);
        }

        private void History_Click(object sender, EventArgs e)
        {
            Mode = Type.Marks;
        }
    }
}
