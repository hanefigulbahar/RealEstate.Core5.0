using Microsoft.EntityFrameworkCore.Infrastructure;
using RealEstate.DataAccessLayer.Abstract;
using RealEstate.DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        Context context=new Context();
        public void Delete(T t)
        {
            context.Remove(t);
            context.SaveChanges();
        }

        public List<T> GetList()
        {
            return context.Set<T>().ToList();
        }

        public void Insert(T t)
        {
            context.Add(t);
            context.SaveChanges();
        }

        public void Update(T t)
        {
            context.Update(t);
            context.SaveChanges();
        }
    }
}
