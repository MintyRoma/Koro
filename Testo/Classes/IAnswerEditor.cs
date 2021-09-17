using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Testo.Classes
{
    interface IAnswerEditor
    {
        string ID { get; }
        string Text { get; set; }
        TaskType Type { get;}

        Object TakeResult();
    }
}
