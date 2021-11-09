using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Servises
{
    public class ToDoService
    {
        private ApplicationDbContext DbContext { get; set; }

        public ToDoService(ApplicationDbContext dbContext)   //DepInjection - controller by neměl komunikovat sám s DB, komunikuje prostřednictvím service
        {                                                    //injekce databáze do třídy ToDoService - ta sdružuje metody pro práci s dB
            DbContext = dbContext;
        }
        public ToDo FindById(long id)
        {
            return DbContext.ToDoDatabase.Find(id);
        }
        public List<ToDo> FindAll()
        {
            return DbContext.ToDoDatabase.ToList();
        }

        public ToDo Add(string title)
        {
            var savedUser = DbContext.ToDoDatabase.Add(new ToDo() { Content=title }).Entity;
            DbContext.SaveChanges();
            return savedUser;
        }

        public void Delete(long id)
        {
            var deletedUser = DbContext.ToDoDatabase.FirstOrDefault(c => c.Id == id);
            DbContext.ToDoDatabase.Remove(deletedUser);
            DbContext.SaveChanges();
        }

        public void Update(ToDo todo)
        {
            var updatedUser = DbContext.ToDoDatabase.FirstOrDefault(c => c.Id == todo.Id);

            updatedUser.Content = todo.Content;
            updatedUser.IsUrgent = todo.IsUrgent;
            updatedUser.IsDone = todo.IsDone;

            DbContext.ToDoDatabase.Update(updatedUser);
            DbContext.SaveChanges();

            //return updatedUser;
        }
    }
}
