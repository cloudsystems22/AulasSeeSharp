using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using WebApplication1.Domain.Core.Interfaces.Repositories;
using WebApplication1.Infrastrucure.Data.MSSqlcontext;

namespace WebApplication1.Infrastrucure.Data.Repositories
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {

        private readonly MSSqlContext mSSqlcontext;

        public BaseRepository(MSSqlContext mSSqlcontext)
        {
            this.mSSqlcontext = mSSqlcontext;
        }

        public void Add(TEntity obj)
        {
            try
            {
                mSSqlcontext.Set<TEntity>().Add(obj);
                mSSqlcontext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<TEntity> GetAll()
        {
            return mSSqlcontext.Set<TEntity>().ToList();
        }

        public TEntity GetById(string id)
        {
            return mSSqlcontext.Set<TEntity>().Find(id);
        }

        public void Remove(TEntity obj)
        {
            try
            {
                mSSqlcontext.Set<TEntity>().Remove(obj);
                mSSqlcontext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(TEntity obj)
        {
            try
            {
                mSSqlcontext.Entry(obj).State = EntityState.Modified;
                mSSqlcontext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
