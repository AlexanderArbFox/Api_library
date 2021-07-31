using Library.Db.Entitties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_library.Models
{
    public class DtoUser
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
    }
}
