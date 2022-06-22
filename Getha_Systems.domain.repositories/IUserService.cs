using Geta_Systems.API.Entities;
using Geta_Systems.API.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getha_Systems.domain.repositories
{
    public interface IUserService
    {
        #region
        //metodos basicos do crud
        IEnumerable<User> GetAll();
        User GetById(int id);
        void Create(CreateRequest model);
        void Update(int id, UpdateRequest model);
        void Delete(int id);
        #endregion
    }
}
