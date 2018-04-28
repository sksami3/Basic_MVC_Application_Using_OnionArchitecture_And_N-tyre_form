using ClassLibrary1.Project123.Infructructure.Entity;
using ClassLibrary1.Project123.Infructructure.Interfaces;
using Project123.Core.Base;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Project123.Infructructure.Repository.Base
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseModel
    {
        private readonly AppDbContext Db;
        private DbSet<T> innerDbset;


        public BaseRepository()
        {
            Db = new AppDbContext();
            innerDbset = Db.Set<T>();
        }
        public IEnumerable<T> All()
        {
            return Db.Set<T>().ToList();
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public T Find(long id)
        {
            throw new NotImplementedException();
        }

        public void Insert(T model)
        {
            innerDbset.Add(model);
            Db.SaveChanges();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
