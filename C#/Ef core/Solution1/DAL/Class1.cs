using System;
using DAL.Models;
using DAL.DataAccess;

namespace DAL
{
    class Program
    {
        static void Main(string[] args)
        {
            using var context = new EventDBContext(); // Make sure your connection string is correct
            var events = new EventDetailsRepo(context);

            // Add new event
            events.Add(new EventDetails
            {
                EventId = 1,
                EventName = "Tech Summit",
                EventCategory = "Technology",
                EventDate = DateTime.Now.AddDays(10),
                Description = "Annual tech event.",
                Status = "Active"
            });

            events.Save();

            // Retrieve all events
            var allEvents = events.GetAll();
            foreach (var ev in allEvents)
            {
                Console.WriteLine($"{ev.EventId}: {ev.EventName} on {ev.EventDate.ToShortDateString()} [{ev.Status}]");
            }

            Console.WriteLine("Done.");
        }
    }
}
