using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Koro.Classes;
using System.IO;
using Newtonsoft.Json;

namespace Koro.Forms.SetingsPages
{
    public partial class TaskEditPage : SetingsPanel, IEditSubForm
    {
        private string jsonfile;
        private string RuntimeDir = @".\runtime\tasks\";
        private string oldFilename = "";

        private string name;
        private string description;
        private List<string> media = new List<string>();
        private TaskType oldtype;
        private TaskType _type;
        private ImageList imgsList = new ImageList();
        private TaskType type
        {
            get
            {
                return _type;
            }
            set
            {
                oldtype = _type;
                _type = value;
                UpdateAnswerContent();
            }
        }

        private void UpdateAnswerContent()
        {
            if (type == oldtype) return;
            switch (type)
            {
                case TaskType.String:
                    if (answers.Count > 1)
                    {
                        DialogResult res = MetroFramework.MetroMessageBox.Show(Parent.Parent, "При наличии нескольких вариантов ответа и смены типа ответа на \"Строка\", все ответы кроме первого будут удалены.\nВы уверены, что хотите поменять тип ответа?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (res == DialogResult.Yes)
                        {
                            right.Clear();
                            string stay = answers[0];
                            answers.Clear();
                            answers.Add(stay);
                            right.Add(stay);
                        }
                        if (res == DialogResult.No)
                        {
                            type = oldtype;
                        }
                    }
                    ConstructData();
                    break;
                case TaskType.Radio:
                    {
                        if (right.Count > 1)
                        {
                            DialogResult res = MetroFramework.MetroMessageBox.Show(Parent.Parent, "При наличии нескольких отметок правильного ответа и смены типа ответа на \"Один из многих\", все отметки правильных ответов кроме первого будут удалены.\nВы уверены, что хотите поменять тип ответа?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (res == DialogResult.Yes)
                            {
                                string stay = right[0];
                                right.Clear();
                                right.Add(stay);
                                ConstructData();
                            }
                            if (res == DialogResult.No)
                            {
                                type = oldtype;
                            }
                        }
                        ConstructData();
                        break;
                    }
                case TaskType.Order:
                    if (right.Count>1)
                    {
                        
                        DialogResult res = MetroFramework.MetroMessageBox.Show(Parent.Parent, "При наличии нескольких вариантов ответа и смены типа ответа на \"Порядок\", все отметки правильных ответов будут заменены на порядок по списку возможных ответов.\nВы уверены, что хотите поменять тип ответа?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (res == DialogResult.Yes)
                        {
                            right = answers.GetRange(0,answers.Count);
                        }
                        if (res == DialogResult.No)
                        {
                            type = oldtype;
                        }
                    }
                    ConstructData();
                    break;
                default:
                    ConstructData();
                    break;
            }
        }

        private List<string> answers = new List<string>();
        private List<string> right = new List<string>();

        private string oldAnsName = "";

        public TaskEditPage(string filename)
        {
            name = filename;
            jsonfile = RuntimeDir + filename + ".json";
            InitializeComponent();
            ImgsListView.LargeImageList = new ImageList();
            Import();
        }

        private void ConstructData()
        {
            ImgsListView.Items.Clear();
            ImgsListView.LargeImageList.Images.Clear();
            ImgsListView.MultiSelect = false;
            NameTxtBox.Text = jsonfile.Replace(RuntimeDir, "").Replace(".json","");
            AnswerUpDown.Minimum = 1;
            TaskDescriptionTxtBox.Text = description;
            string typ = "";
            switch (type)
            {
                case TaskType.Checkbox:
                    typ = "Выбор нескольких";
                    break;
                case TaskType.Order:
                    typ = "Порядок";
                    break;
                case TaskType.String:
                    typ = "Строка";
                    break;
                default:
                    typ = "Выбор одного";
                    break;
            }
            TypeSelector.SelectedItem = typ;
            AnswersListBox.Items.Clear();
            foreach (string ans in answers)
            {
                AnswersListBox.Items.Add(ans);
            }
            EditAnswerNamePanel.Hide();
            AnswerRightPanel.Hide();
            ImgsListView.View = View.LargeIcon;
            ImgsListView.LargeImageList.ImageSize = new Size(100, 100);
            int i = 0;
            foreach(string file in media)
            {
                ImgsListView.LargeImageList.Images.Add(new Bitmap(file));
                ListViewItem item = new ListViewItem();
                item.Text = Path.GetFileName(file);
                item.ImageIndex = i;
                ImgsListView.Items.Add(item);
                i++;
            }
            AnswerUpDown.Maximum = AnswersListBox.Items.Count;
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

        private void AddMediaBtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog fd = new OpenFileDialog();
                fd.Filter = "Файлы изображений|*.bmp;*.png;*.jpg";
                DialogResult res = fd.ShowDialog();
                if (res == DialogResult.OK)
                {
                    string pic = fd.FileName;
                    string storage = @".\runtime\media\" + Path.GetFileName(pic);
                    if (media.Contains(storage)) throw new Exception("Filename exist");
                    if (!File.Exists(storage))File.Copy(pic, storage);
                    media.Add(storage);
                    ConstructData();
                }
            }
            catch (Exception ex)
            {
                if (ex.Message == "Filename exist") MetroFramework.MetroMessageBox.Show(Parent.Parent, "Файл с таким уменем уже добавлен", "Неверный файл", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else MetroFramework.MetroMessageBox.Show(Parent.Parent, "Произошла ошибка добавления изображения.", "Неверный файл", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void DeleteMediaBtn_Click(object sender, EventArgs e)
        {
            if (ImgsListView.SelectedItems == null) return;
            ListViewItem item = ImgsListView.SelectedItems[0];
            string filename = @".\runtime\media\"+item.Text;
            media.Remove(filename);
            ConstructData();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        public bool Import()
        {
            try
            {
                answers.Clear();
                right.Clear();
                media.Clear();
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
                description = manif.description;
                foreach (string pic in manif.media) media.Add(pic);
                foreach (string ans in manif.answers) answers.Add(ans);
                foreach (string rig in manif.right) right.Add(rig);
                ConstructData();
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
                if (!ErrorCorrection()) throw new Exception("Wrong config");
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
                if (File.Exists(oldFilename)) File.Delete(oldFilename);
                else File.Delete(jsonfile);
                File.Move(jsonfile + ".upd", jsonfile);
                return true;
            }
            catch (Exception ex)
            {
                if (ex.Message == "Wrong config")
                {
                    MetroFramework.MetroMessageBox.Show(Parent.Parent, "Выставлены неверные настройки ответов, исправьте и после сохраните еще раз", "Неверный файл", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return true;
                }
                if (File.Exists(jsonfile + ".upd")) File.Delete(jsonfile + ".upd");
                return false;
            };
        }

        private bool ErrorCorrection()
        {
            if (right.Count > answers.Count) return false;
            foreach (string ans in right)
            {
                if (!answers.Contains(ans)) return false;
            }
            switch (type)
            {
                case TaskType.Radio:
                    if (right.Count > 1) return false;
                    break;
                case TaskType.String:
                    if (right.Count > 1) return false;
                    break;
                case TaskType.Checkbox:
                    if (right.Count < 1) return false;
                    break;
                case TaskType.Order:
                    if (right.Count != answers.Count) return false;
                    break;
            }
            return true;
        }

        public void Reconstruct()
        {
            File.WriteAllBytes(jsonfile, Koro.Properties.Resources.marks);
            Import();
        }

        private void TypeSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            string mode = TypeSelector.SelectedItem.ToString();
            switch (mode)
            {
                case "Выбор нескольких":
                    type = TaskType.Checkbox;
                    break;
                case "Порядок":
                    type = TaskType.Order;
                    break;
                case "Строка":
                    type = TaskType.String;
                    break;
                default:
                    type = TaskType.Radio;
                    break;
            }
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void EditAnswerNamePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AnswersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            EditAnswerNamePanel.Show();
            AnswerNameTxtbox.Text = AnswersListBox.SelectedItem.ToString();
            if (type!=TaskType.String)
            {
                AnswerRightPanel.Show();
                switch (type)
                {
                    case TaskType.Checkbox:
                        AnswerRadioBtn.Hide();
                        AnswerUpDown.Hide();
                        AnswerCheckBox.Show();
                        if (right.Contains(AnswerNameTxtbox.Text)) AnswerCheckBox.Checked = true;
                        else AnswerCheckBox.Checked = false;
                        break;
                    case TaskType.Radio:
                        AnswerRadioBtn.Show();
                        AnswerUpDown.Hide();
                        AnswerCheckBox.Hide();
                        if (right.Contains(AnswerNameTxtbox.Text)) AnswerRadioBtn.Checked = true;
                        else AnswerRadioBtn.Checked = false;
                        break;
                    case TaskType.Order:
                        AnswerRadioBtn.Hide();
                        AnswerUpDown.Show();
                        AnswerCheckBox.Hide();
                        AnswerUpDown.Value = right.IndexOf(AnswerNameTxtbox.Text)+1;
                        break;
                }
            }
        }

        private void AnswerNameTxtbox_Enter(object sender, EventArgs e)
        {
            oldAnsName = AnswerNameTxtbox.Text;
        }

        private void AnswerNameTxtbox_Leave(object sender, EventArgs e)
        {
            if (oldAnsName == AnswerNameTxtbox.Text) return;
            if (answers.Contains(AnswerNameTxtbox.Text))
            {
                AnswerNameTxtbox.Text = oldAnsName;
                MetroFramework.MetroMessageBox.Show(Parent.Parent, "Ответ с таким содержимым уже существует!", "Действие запрещено", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                int position = 0;
                if (type == TaskType.String)
                {
                    answers.Clear();
                    answers.Add(AnswerNameTxtbox.Text);
                    right.Clear();
                    right.Add(AnswerNameTxtbox.Text);
                }
                else
                {
                    position = answers.IndexOf(oldAnsName);
                    answers[position] = AnswerNameTxtbox.Text;
                    if (right.Contains(oldAnsName))
                    {
                        int index = right.IndexOf(oldAnsName);
                        right[index] = AnswerNameTxtbox.Text;
                    }
                }
                               
                ConstructData();
                AnswersListBox.SelectedIndex = position;
            }
        }

        private void AnswerRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (AnswerRadioBtn.Checked)
            {
                right.Clear();
                right.Add(AnswerNameTxtbox.Text);
            }
        }

        private void AnswerCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (AnswerCheckBox.Checked)
            {
                if (!right.Contains(AnswerNameTxtbox.Text))
                {
                    right.Add(AnswerNameTxtbox.Text);
                }
            }
            else
            {
                if (right.Contains(AnswerNameTxtbox.Text))
                {
                    right.Remove(AnswerNameTxtbox.Text);
                }
            }
        }

        private void TaskDescriptionTxtBox_Click(object sender, EventArgs e)
        {

        }

        private void TaskDescriptionTxtBox_Leave(object sender, EventArgs e)
        {
            description = TaskDescriptionTxtBox.Text;
        }

        private void NameTxtBox_Leave(object sender, EventArgs e)
        {
            oldFilename = jsonfile;
            jsonfile = RuntimeDir + NameTxtBox.Text + ".json";
            name = NameTxtBox.Text;
        }

        private void AddAnswerBtn_Click(object sender, EventArgs e)
        {
            if (type != TaskType.String)
            {
                answers.Add($"Ответ #{AnswersListBox.Items.Count + 1}");
                if (type==TaskType.Order) right.Add($"Ответ #{AnswersListBox.Items.Count + 1}");
            }
            ConstructData();
        }

        private void DeleteAnswerBtn_Click(object sender, EventArgs e)
        {
            string del="";
            if (AnswersListBox.SelectedItem != null) del = AnswersListBox.SelectedItem.ToString();
            else return;
            answers.Remove(del);
            if (right.Contains(del)) right.Remove(del);
            ConstructData();
        }

        private void DeleteTask_Click(object sender, EventArgs e)
        {
            DialogResult res = MetroFramework.MetroMessageBox.Show(Parent.Parent, "Вы действительно желаете удалить задание?\nДействие отменить будет невозможно!", "Вы уверены?", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (res == DialogResult.Yes)
            {
                File.Delete(jsonfile);
                this.Dispose();
            }
            else return;
        }

        private void AnswerUpDown_Leave(object sender, EventArgs e)
        {
            string ans = AnswerNameTxtbox.Text;
            int position = (int)AnswerUpDown.Value;
            right.Remove(ans);
            right.Insert(position - 1, ans);
        }

        private void AnswerNameTxtbox_Click(object sender, EventArgs e)
        {

        }

        private void NameTxtBox_Click(object sender, EventArgs e)
        {

        }

        private void NameTxtBox_KeyUp(object sender, KeyEventArgs e)
        {
            List<char> BannedSymbols = new List<char> { '\\', '/', ':', '*', '?', '"', '<', '>', '|', '+', ',', '.', '%', '@' };
            foreach(char c in NameTxtBox.Text)
            {
                if (BannedSymbols.Contains(c))
                {
                    NameTxtBox.Text = NameTxtBox.Text.Replace(Convert.ToString(c), "");
                }
            }
        }
    }
}
