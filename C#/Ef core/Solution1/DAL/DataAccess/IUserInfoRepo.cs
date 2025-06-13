using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;

namespace DAL.DataAccess
{
    public interface IUserInfoRepo<UserInfo>
    {
        List<UserInfo> GetAll();
        UserInfo GetByEmail(string email);
        void Add(UserInfo user);
        void Update(UserInfo user);
        void Delete(string email);
        void Save();

        UserInfo GetUserById(string emailId);
    }
}
