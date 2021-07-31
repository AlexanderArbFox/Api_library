using Library.Db;
using Library.Db.Entitties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_library.Services
{
    public class LibraryService
    {
           
    }
        public interface IUserInfoService
        {
            DbUser GetUserInfoById(int id);
        }
}
