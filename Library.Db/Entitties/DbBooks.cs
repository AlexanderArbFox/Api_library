using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Db.Entitties
{
    public class DbBooks
    {
        #region Identity
        /// <summary>
        /// Идентификатор, ключ
        /// </summary>
        public int Id { get; set; }
        #endregion

        #region Create
        /// <summary>
        /// Дата-время создания сущности
        /// </summary>
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        #endregion

        #region Delete
        /// <summary>
        /// Дата и время, когда была удалена сущность.
        /// Если null - значит не удалена
        /// </summary>
        public DateTime? DeletedAt { get; set; }
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
        public DbUser User { get; set; }
        public DbAuthors Authors { get; set; }
        #endregion
    }
}
