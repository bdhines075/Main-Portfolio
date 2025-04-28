using GroupProject2.Models;
using GroupProject2.Data;
using Microsoft.EntityFrameworkCore;


namespace GroupProject2.Data
{
    public interface IDAL
    {
        public List<Event> GetEvents();
        public List<Event> GetMyEvents(string userid);
        public Event GetEvent(int id);
        public void CreateEvent(IFormCollection form);
        public void UpdateEvent(IFormCollection form);
        public void DeleteEvent(int id);
        public List<Location> GetLocations();
        public Location GetLocation(int id);
        public void CreateLocation(Location location);
        void DeleteLocation(int id);

    }
    public class DAL : IDAL
    {
        private readonly ApplicationDbContext _context;
     
        public DAL(ApplicationDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public List<Event> GetEvents()
        {
            return _context.Events
                .Include(e => e.Location) 
                .ToList();
        }
        public List<Event> GetMyEvents(string userid)
        {
            return _context.Events.Where(x => x.User.Id == userid).ToList();
        }

        public Event GetEvent(int id)
        {
            return _context.Events
                .Include(e => e.Location)
                .FirstOrDefault(x => x.Id == id);
        }

        public void CreateEvent(IFormCollection form)
        {
            var locName = form["Location"];
            var newevent = new Event
            {
                Name = form["Event.Name"],
                Description = form["Event.Description"],
                StartTime = Convert.ToDateTime(form["Event.StartTime"]),
                EndTime = Convert.ToDateTime(form["Event.EndTime"]),
                Location = _context.Locations.FirstOrDefault(x => x.Name == locName)
            };
            _context.Events.Add(newevent);
            _context.SaveChanges();
        }

        public void UpdateEvent(IFormCollection form)
        {
            int id = Convert.ToInt32(form["Event.Id"]);
            var existingEvent = _context.Events
                .Include(e => e.Location)
                .FirstOrDefault(e => e.Id == id);

            if (existingEvent != null)
            {
                existingEvent.Name = form["Event.Name"];
                existingEvent.Description = form["Event.Description"];
                existingEvent.StartTime = Convert.ToDateTime(form["Event.StartTime"]);
                existingEvent.EndTime = Convert.ToDateTime(form["Event.EndTime"]);

                var locName = form["Location"];
                var location = _context.Locations.FirstOrDefault(x => x.Name == locName);
                if (location != null)
                {
                    existingEvent.Location = location;
                }

                _context.SaveChanges();
            }
        }


        public void DeleteEvent(int id)
        {
            var myevent = _context.Events.Find(id);
            _context.Events.Remove(myevent);
            _context.SaveChanges();
        }

        public List<Location> GetLocations()
        {
            return _context.Locations.ToList();
        }
        public Location GetLocation(int id)
        {
            return _context.Locations.Find(id);
        }
        public void CreateLocation(Location location)
        {
            _context.Locations.Add(location);
            _context.SaveChanges();
        }
        public void DeleteLocation(int id)
        {
            var location = _context.Locations.Find(id);
            if (location != null)
            {
                _context.Locations.Remove(location);
                _context.SaveChanges();
            }
        }

    }
}
