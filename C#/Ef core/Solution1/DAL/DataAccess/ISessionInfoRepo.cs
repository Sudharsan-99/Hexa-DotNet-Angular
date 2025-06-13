using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;

namespace DAL.DataAccess
{
    public interface ISessionInfoRepo<SessionInfo>
    {
        List<SessionInfo> GetAll();
        SessionInfo GetById(int id);
        List<SessionInfo> GetByEventId(int eventId);
        void Add(SessionInfo session);
        void Update(SessionInfo session);
        void Delete(int id);
        void Save();
    }
}
