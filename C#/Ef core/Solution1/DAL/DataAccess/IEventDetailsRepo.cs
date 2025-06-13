using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;

namespace DAL.DataAccess
{
    public interface IEventDetailsRepo<EventDetails>
    {
        List<EventDetails> GetAll();
        EventDetails GetById(int id);
        List<EventDetails> GetByCategory(string category);
        void Add(EventDetails eventDetail);
        void Update(EventDetails eventDetail);
        void Delete(int id);
        void Save();

        
        void AddUsingSP(EventDetails entity);
        void UpdateUsingSP(EventDetails entity);
        void DeleteUsingSP(int id);
    }
}
