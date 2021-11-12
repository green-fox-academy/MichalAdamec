using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UrlAliaser.Database;
using UrlAliaser.Models;

namespace UrlAliaser.Services
{
    public class DbService
    {
        public ApplicationDbContext DbContext { get; set; }
        public DbService(ApplicationDbContext dbContext)
        {
            DbContext = dbContext;
        }

        public string Add(string url, string alias)
        {
            string text = "";
            string code = GenerateCode();

            var exists = DbContext.FormDatabase.Find(alias);
            if (exists == null)
            {
                DbContext.FormDatabase.Add(new Form() { Alias = alias, Url = url, Code = code });
                DbContext.SaveChanges();
                return text = $"Your url is aliased to {alias} and your secret code is {code}.";
            }
            else
            {
                return text = "Your alias is already in use!";
            }
        }

        public static string GenerateCode()
        {
            string code = "";
            Random rd = new Random();
            for (int a = 1; a <= 4; a++)
            {
                int num = rd.Next(0, 10);
                code += num.ToString();
            }
            return code;
        }

        public Form FindByAlias(string alias)
        {
            Form form = DbContext.FormDatabase.Find(alias);
            return form;
        }

        public List<Form> FindAll()
        {
            return DbContext.FormDatabase.ToList();
        }

    }
}
