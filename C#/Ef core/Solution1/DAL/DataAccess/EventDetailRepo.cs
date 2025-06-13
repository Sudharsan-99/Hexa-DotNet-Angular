using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace DAL.DataAccess
{
    public class EventDetailsRepo : IEventDetailsRepo<EventDetails>
    {
        private readonly EventDBContext _context;

        public EventDetailsRepo(EventDBContext context)
        {
            _context = context;
        }

        public List<EventDetails> GetAll()
        {
            return _context.EventDetails.ToList();
        }

        public EventDetails GetById(int id)
        {
            return _context.EventDetails.FirstOrDefault(e => e.EventId == id);
        }

        public List<EventDetails> GetByCategory(string category)
        {
            return _context.EventDetails.Where(e => e.EventCategory == category).ToList();
        }

        public void Add(EventDetails eventDetail)
        {
            _context.EventDetails.Add(eventDetail);
        }

        public void Update(EventDetails eventDetail)
        {
            _context.EventDetails.Update(eventDetail);
        }

        public void Delete(int id)
        {
            var evt = GetById(id);
            if (evt != null)
                _context.EventDetails.Remove(evt);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void AddUsingSP(EventDetails entity)
        {
            _context.Database.ExecuteSqlRaw("EXEC AddEvent @p0, @p1, @p2, @p3, @p4",
                entity.EventName,
                entity.EventCategory,
                entity.EventDate,
                entity.Description ?? "",
                entity.Status);
        }

        public void UpdateUsingSP(EventDetails entity)
        {
            _context.Database.ExecuteSqlRaw("EXEC UpdateEvent @p0, @p1, @p2, @p3, @p4, @p5",
                entity.EventId,
                entity.EventName,
                entity.EventCategory,
                entity.EventDate,
                entity.Description ?? "",
                entity.Status);
        }

        public void DeleteUsingSP(int id)
        {
            var param = new SqlParameter("@EventId", id);
            _context.Database.ExecuteSqlRaw("EXEC DeleteEvent @EventId", param);
        }


    }
}
