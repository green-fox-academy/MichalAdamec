using Frontend.Database;
using Frontend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Frontend.Services
{
    public class LogService
    {
        private ApplicationDbContext DbContext { get; set; }
        public LogService(ApplicationDbContext dBContext)
        {
            DbContext = dBContext;
        }


        public Log FindById(long id)
        {
            return DbContext.LogDatabase.Find(id);
        }
        public List<Log> FindAll()
        {
            return DbContext.LogDatabase.ToList();
        }

        public void Add(Log log)
        {
            var entity = DbContext.LogDatabase.Add(log).Entity;

            DbContext.SaveChanges();
        }

        public void Delete(long id)
        {
            var deleted = DbContext.LogDatabase.FirstOrDefault(c => c.Id == id);
            DbContext.LogDatabase.Remove(deleted);
            DbContext.SaveChanges();
        }
    }
}
