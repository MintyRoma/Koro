using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Koro.Classes
{
    interface IAnswerEditor
    {
        string ID { get; }
        string Text { get; set; }
        TaskType Type { get;}

        Object TakeResult();
    }
}
