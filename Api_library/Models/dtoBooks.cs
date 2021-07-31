using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_library.Models
{
    public class DtoBooks
    {
        #region Identity
        /// <summary>
        /// Идентификатор, ключ
        /// </summary>
        public int Id { get; set; }
        #endregion

        #region Other
        /// <summary>
        /// Название книги
        /// </summary>
        public string NameBook { get; set; }

        /// <summary>
        /// Изображение, например iqzJpG4atE.png
        /// </summary>
        public string Avatar { get; set; }

        /// <summary>
        /// Автор книги
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// Год написания
        /// </summary>
        public int YearsOfWrite { get; set; }

        #endregion

        #region Reference
        #endregion
    }
}

