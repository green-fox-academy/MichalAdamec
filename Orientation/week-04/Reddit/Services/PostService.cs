using Reddit.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reddit.Services
{
    public class PostService
    {
        private ApplicationDbContext Database { get; set; }
        public PostService(ApplicationDbContext db)
        {
            Database = db;
        }

        public void Add(Post post)
        {
            Database.PostDatabase.Add(post);                //.Entity => vrátí objekt z databáze
            Database.SaveChanges();
        }
        public List<Post> ListAll()
        {
            return Database.PostDatabase.ToList();
        }
        public void Vote(int vote, long id)
        {
            var obj = Database.PostDatabase.Find(id);
            obj.Votes = vote == 1 ? obj.Votes += 1 : obj.Votes -= 1;
            Database.SaveChanges();
        }
    }
}
