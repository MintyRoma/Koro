using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Testo.Classes
{
    interface IEditSubForm
    {
        /// <summary>
        /// Импорт файла конкретной формы. Вызов при загрузке панели или при нажатии "Отмена"
        /// </summary>
        /// <returns></returns>
        bool Import();

        /// <summary>
        /// Экспортирует для формы конкретный файл
        /// </summary>
        /// <returns>
        /// false = не удалось экспортировать файл
        /// true = успешный экспорт файла</returns>
        bool Export();

        /// <summary>
        /// Пересоздает с нуля файл с которым оперирует панель.
        /// </summary>
        void Reconstruct();
    }
}
