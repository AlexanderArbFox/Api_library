using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Db.Entitties
{
    public class DbUser
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
        /// Имя 
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Фамилия
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Почтовый адрес 
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Изображение, например iqzJpG4atE.png
        /// </summary>
        public string Avatar { get; set; }

        /// <summary>
        /// Пол
        /// </summary>
        public UserGender? Gender { get; set; }

        /// <summary>
        /// Телефон
        /// </summary>
        public long NumberPhone { get; set; }

        #endregion
        public virtual ICollection<DbBooks> Books { get; set; } = new List<DbBooks>(); 
        #region Reference
        #endregion
    }


    /// <summary>
    /// Выбор пола 
    /// </summary>
    public enum UserGender
    {
        /// <summary>
        /// Женский
        /// </summary>
        Woman,

        /// <summary>
        /// Мужской
        /// </summary>
        Men
    }
}
