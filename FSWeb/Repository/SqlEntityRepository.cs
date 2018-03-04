using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FSWeb.Data.DAL;
using FSWeb.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace FSWeb.Repository
{
    public class SqlEntityRepository<T> : IEntityRepository<T> where T: BaseNamedModel
    {
        FSContext DbContext;
        DbSet<T> Entities;

        public SqlEntityRepository(FSContext dbContext)
        {
            DbContext = dbContext;
            Entities = dbContext.Set<T>();
        }
        public void Delete(T entity)
        {
            NullCheck(entity);
            Entities.Remove(entity);
            DbContext.SaveChanges();
        }

        public T Get(int id)
        {
            return Entities.SingleOrDefault(s => s.Id == id);
        }

        public IEnumerable<T> GetAll()
        {
            return Entities.AsEnumerable();
        }

        public void Insert(T entity)
        {
            NullCheck(entity);
            Entities.Add(entity);
            DbContext.SaveChanges();
        }

        public void Update(T entity)
        {
            NullCheck(entity);
            DbContext.SaveChanges();
        }

        void NullCheck(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
        }

    }

}
