using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Testo.Classes
{
    public class Task
    {
        private string id;
        private string head;
        private string body;
        private string right;
        private List<Answer> ans = new List<Answer>();
        private List<string> imgs = new List<string>();
        private TaskType type;
        private bool randomize;

        public string ID => id;
        public string Header => head;
        public string Text => body;
        public List<Answer> Answers
        {
            get
            {
                if (RandomizeAnswers)
                {
                    List<Answer> answers = new List<Answer>();
                    int amount = answers.Count();
                    List<int> exist = new List<int>();
                    for (int i=0;i<amount;i++)
                    {
                        exist.Add(i);
                    }
                    for (int i=0; i<amount;i++)
                    {
                        Random rnd = new Random();
                        int id = rnd.Next(0, exist.Count);
                        answers[i] = ans[id];
                        exist.Remove(id);
                    }
                    return answers;
                }
                else
                {
                    return ans;
                }
            }
        }
        public List<string> Images => imgs;
        public TaskType Type => type;
        public bool RandomizeAnswers => randomize;

        /// <summary>
        /// Функция контроллируемой переинициализации задания из временного задания
        /// </summary>
        /// <param name="tpmTask">Временное задание</param>
        public void ReInit(Task tmpTask)
        {
            head = tmpTask.head;
            body = tmpTask.Text;
            imgs = tmpTask.Images;
            ans = tmpTask.Answers;
            type = tmpTask.Type;
        }

        /// <summary>
        /// Конструктор задания. здесь задаются параметры по умолчанию.
        /// </summary>
        public Task ()
        {
            string lib = "ABCDEFGHIJKLMOPQRSTUVWXYZ0123456789";
            string genid = "";
            Random rnd = new Random();
            for (int i = 0; i < 4; i++)
            {
                genid += lib[rnd.Next(lib.Length + i)];
            }

            id = genid;

            head = "Задание" + id;
            body = "Сюда вписывается текст задания";
            ans.Add(new Answer("Ответ"));
            right = "Ответ";
            type = TaskType.String;
        }

        /// <summary>
        /// Конструктор задания с полными параметрами
        /// </summary>
        /// <param name="header">Заголовок задания</param>
        /// <param name="txt">Текст задания</param>
        /// <param name="taskType">Тип задания</param>
        /// <param name="anss">Набор ответов</param>
        /// <param name="rightans">Верный ответ</param>
        public Task(string header, string txt,TaskType taskType, List<Answer> anss, string rightans)
        {
            string lib = "ABCDEFGHIJKLMOPQRSTUVWXYZ0123456789";
            string genid = "";
            Random rnd = new Random();
            for (int i = 0; i < 4; i++)
            {
                genid += lib[rnd.Next(lib.Length + i)];
            }

            id = genid;
            head = header;
            body = txt;
            ans = anss;
            right = rightans;
            type = taskType;
        }

        /// <summary>
        /// Нужен для сверки ответов с формы. В случае если ответ верный, выдает true, иначе false.
        /// Для типа Radio - ID ответа; для типа Checkbox - строка из ID через запятую; для типа Order - строка из ID по порядку, через запятую; для типа String - ответ в виде строки
        /// </summary>
        /// <param name="ansID">Для типа Radio - ID ответа; для типа Checkbox - строка из ID через запятую; для типа Order - строка из ID по порядку, через запятую; для типа String - ответ в виде строки</param>
        /// <returns></returns>
        public bool Check(string ansID)
        {
            switch (Type)
            {
                case TaskType.Radio:
                    if (right == ansID) return true;
                    else return false;
                    break;
                case TaskType.Checkbox:
                    string[] anss = right.Split(',');
                    string[] ansgot = ansID.Split(',');
                    int amount = anss.Count();
                    int now = 0;
                    for(int i=0; i<amount;i++)
                    {
                        if (anss.Contains(ansgot[i]))
                        {
                            now++;
                        }
                        else
                        {
                            return false;
                            break;
                        }
                    }
                    if (now!=amount)
                    {
                        return false;
                        break;
                    }
                    return true;
                    break;
                case TaskType.Order:
                    string[] tmp = right.Split(',');
                    Queue<string> ansq = new Queue<string>();
                    foreach(string n in tmp) ansq.Enqueue(n);
                    Queue<string> ansqgot = new Queue<string>();
                    foreach (string n in ansID.Split(',')) ansqgot.Enqueue(n);
                    if (ansq == ansqgot) return true;
                    else return false;
                    break;
                default:
                    if (right == ansID.ToLower()) return true;
                    else return false;
                    break;
            }
        }

        public string GetMarking()
        {
            if (Type == TaskType.Radio || Type == TaskType.Checkbox) return right;
            else return "";
        }
    }
}
