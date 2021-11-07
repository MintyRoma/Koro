using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Koro.Classes;
using Koro.Forms.SetingsPages;
using System.IO;
using Newtonsoft.Json;


namespace Koro.Forms
{
    public partial class EditSubjectForm : MetroForm
    {

        int selectedTaskIndex = -1;
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
                    taskfile = TasksListBox.Items.IndexOf(taskfile) + ";" + taskfile;
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
            if (!CheckOrdering()) ReBuildOrder();
            TasksListBox.Items.Clear();
            string[] files = Directory.GetFiles(rntdir+"\\tasks");
            foreach(string f in files)
            {
                string title = Path.GetFileName(f).Replace(".json", "");
                int sep = title.IndexOf(';');
                title = title.Remove(0, sep+1);
                TasksListBox.Items.Add(title);
            }
        }

        private void ReBuildOrder()
        {
            int locator = 0;
            foreach(string filepath in Directory.GetFiles(rntdir + "\\tasks\\"))
            {
                string filename = Path.GetFileName(filepath);
                int separator = filename.IndexOf(';');
                int actualID = Convert.ToInt32(filename.Substring(0, separator));
                if (locator!=actualID)
                {
                    string newfilename = filename.Replace(actualID + ";", locator + ";");
                    File.Move(rntdir+"\\tasks\\"+filename, rntdir + "\\tasks\\" + newfilename);
                }
                locator++;
            }
        }

        private bool CheckOrdering()
        {
            int locator = 0;
            foreach (string filename in Directory.GetFiles(rntdir+"\\tasks\\"))
            {
                if (!filename.Contains(Convert.ToString(locator)+";"))
                {
                    return false;
                }
                locator++;
            }
            return true;
        }

        private void GenerateNewSubject()
        {
            
            File.WriteAllBytes(rntdir+"\\manifest.json",Koro.Properties.Resources.manifest);
            File.WriteAllBytes(rntdir+"\\marks.json", Koro.Properties.Resources.marks);
            Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\runtime\\media");
            Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\runtime\\tasks");
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
            string filename = $"{TasksListBox.Items.Count};Задание #{num}";
            File.WriteAllBytes(rntdir + $"\\tasks\\{filename}.json", Koro.Properties.Resources.task);
            UpdateTasksList();
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
            if (TasksListBox.SelectedItem == null) return;
            if (TasksListBox.SelectedIndex == selectedTaskIndex) return;
            selectedTaskIndex = TasksListBox.SelectedIndex;
            taskfile = TasksListBox.SelectedItem.ToString();
            Mode = Type.Tasks;
            TasksListBox.SetSelected(selectedTaskIndex,true);
        }

        private void MoveUp_Click(object sender, EventArgs e)
        {
            if (TasksListBox.SelectedItem == null) return;
            if (TasksListBox.SelectedIndex == 0) return;

            int position = TasksListBox.SelectedIndex;
            string[] files = Directory.GetFiles(rntdir+"\\tasks\\");

            string toCopy = files[position];
            string toMove = files[position - 1];

            string newname = toMove.Replace(Convert.ToString(position - 1)+";", Convert.ToString(position)+";");
            File.Move(toCopy, toCopy + ".upd");
            File.Move(toMove, newname);
            string selectedname = toCopy.Replace(Convert.ToString(position)+";", Convert.ToString(position - 1)+";");
            File.Move(toCopy + ".upd", selectedname);

            UpdateTasksList();
        }

        private void MoveDown_Click(object sender, EventArgs e)
        {
            if (TasksListBox.SelectedItem == null) return;
            if (TasksListBox.SelectedIndex == TasksListBox.Items.Count-1) return;

            int position = TasksListBox.SelectedIndex;
            string[] files = Directory.GetFiles(rntdir + "\\tasks\\");

            string toCopy = files[position];
            string toMove = files[position + 1];

            string newname = toMove.Replace(Convert.ToString(position + 1)+";", Convert.ToString(position)+";");
            File.Move(toCopy, toCopy + ".upd");
            File.Move(toMove, newname);
            string selectedname = toCopy.Replace(Convert.ToString(position)+";", Convert.ToString(position + 1)+";");
            File.Move(toCopy + ".upd", selectedname);

            UpdateTasksList();
        }
    }
}
