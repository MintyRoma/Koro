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
                mode = value;
                ChangeState();
            }
        }

        private string rntdir = Directory.GetCurrentDirectory() + "\\runtime";
        private string taskfile = "";

        public EditSubjectForm()
        {
            InitializeComponent();
            if (!File.Exists("runtime/manifest.json"))
            {
                GenerateNewSubject();
            }
            UpdateTasksList();
            Mode = Type.Setup;
            
        }

        private void ChangeState()
        {
            foreach (Control ctrl in DetailsPanel.Controls) ctrl.Dispose();
            switch (Mode)
            {
                case Type.Setup:
                    EditSubjectPage es = new EditSubjectPage();
                    DetailsPanel.Controls.Add(es);
                    break;
                case Type.Marks:
                    MarksSetup ms = new MarksSetup();
                    DetailsPanel.Controls.Add(ms);
                    break;
                case Type.Tasks:
                    TaskEditPage tp = new TaskEditPage(taskfile);
                    tp.Disposed+=TaskDeleted;
                    DetailsPanel.Controls.Add(tp);
                    break;
            }
        }

        private void TaskDeleted(object sender, EventArgs e)
        {
            UpdateTasksList();
        }

        private void UpdateTasksList()
        {
            TasksListBox.Items.Clear();
            string[] files = Directory.GetFiles(rntdir+"\\tasks");
            foreach(string f in files)
            {
                TasksListBox.Items.Add(Path.GetFileName(f).Replace(".json",""));
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

        private void AddTaskBtn_Click_2(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int num = rnd.Next(0, 956633);
            string filename = $"Задание #{num}";
            TasksListBox.Items.Add(filename);
            File.WriteAllBytes(rntdir + $"\\tasks\\{filename}.json", Testo.Properties.Resources.task);
        }

        private void History_Click(object sender, EventArgs e)
        {
            Mode = Type.Marks;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            IEditSubForm sf = (IEditSubForm)DetailsPanel.Controls[0];
            if (!sf.Export())
            {
                DialogResult ds = MetroFramework.MetroMessageBox.Show(this, "Произошла ошибка записи файла! В целях исправления изменения сохранены не будут. Для продолжения нажмите \"ОК\"", "Ошибка чтения файла", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (ds == DialogResult.OK) sf.Import();
            }
            UpdateTasksList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IEditSubForm sf = (IEditSubForm)DetailsPanel.Controls[0];
            if (!sf.Import())
            {
                DialogResult ds = MetroFramework.MetroMessageBox.Show(this, "Произошла ошибка чтения файла! В целях исправления файл будет пересоздан, а информация удалена. Для продолжения нажмите \"Да\"", "Ошибка чтения файла", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                switch(ds)
                {
                    case DialogResult.Yes:
                        sf.Reconstruct();
                        break;
                    case DialogResult.No:
                        this.Close();
                        break;
                
                }
            }
        }

        private void TasksListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            taskfile = TasksListBox.SelectedItem.ToString();
            Mode = Type.Tasks;
        }
    }
}
