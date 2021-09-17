using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Testo.Classes
{
    interface IEditSubForm
    {
        //Импортирует файл конкретный для формы
        bool Import();

        /// <summary>
        /// Экспортирует для формы конкретный файл
        /// </summary>
        /// <returns>
        /// false = не удалось экспортировать файл
        /// true = успешный экспорт файла</returns>
        bool Export();

        void Reconstruct();
    }
}
