using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Db.Entitties
{
    public class DbAuthors
    {
        #region Identity
        /// <summary>
        /// Идентификатор, ключ
        /// </summary>
        public int Id { get; set; }
        #endregion

        #region Other
        /// <summary>
        /// Имя 
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Фамилия
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Изображение, например iqzJpG4atE.png
        /// </summary>
        public string Avatar { get; set; }

        /// <summary>
        /// Пол
        /// </summary>
        public UserGender? Gender { get; set; }

        #endregion

        #region Reference
        #endregion
    }
}
