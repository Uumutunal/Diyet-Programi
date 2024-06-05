using EFDiyetProgramiProje_DAL.Context;
using EFDiyetProgramiProje_DAL.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EFDiyetProgramiProje_DAL.Repository.Abstract
{
    public abstract class Repository<T> : IRepository<T> where T : BaseEntity, new()
    {
        private readonly DiyetProgramiDbContext _db;
        private DbSet<T> entities;

        public Repository(DiyetProgramiDbContext db)
        {
            _db = db;
            entities = _db.Set<T>();
        }

        public void Delete(T entity)
        {
            entity.DeletedTime = DateTime.Now;
            entity.DataStatus = DataStatus.Deleted;
            Update(entity);
        }

        public IQueryable<T> GetAll()
        {
            return entities.Where(e => e.DataStatus != DataStatus.Deleted).AsNoTracking();
        }
        public IQueryable<T> GetAllWithIncludes()
        {
            IQueryable<T> query = GetAll();
            // gönderilen türe ait olan bütün navigation propları include etmeli
            // gönderilen türün özellikleri içerisinde döngü ile gezinsek ve IEntity den miras alanları include etsek

            // türü bulabilmek için (T yi) T den bir nesne oluşturup, özellikleri içerisinde döngü ile gezinip, IEntity den miras alanları include edelim
            T instance = new T(); // gönderilenden bir örnek al 
            Type type = instance.GetType(); // onun türünü bul

            // buna ait olan propertyleri elde et
            PropertyInfo[] propertyInfos = type.GetProperties(); // o türün bütün public propertylerini verir bir diziye aktarır

            // bu proplar içerisinde dönelim                                 IEntity den miras alan dediğimiz için 
            foreach (PropertyInfo propInfo in propertyInfos.Where(pi => pi.PropertyType.GetInterfaces().Where(i => i.Name == "IEntity" || i.Name == "ICollection").Any()).ToList())
            {
                if (propInfo.PropertyType.GetInterfaces().Any(i => i.Name == "ICollection"))
                {


                    var elementType = propInfo.PropertyType.GetGenericArguments().FirstOrDefault().BaseType.Name;

                    if (elementType == "BaseEntity")
                        query = query.Include(propInfo.Name);
                }
                else
                    query = query.Include(propInfo.Name);
            }

            return query;
        }
        public IQueryable<T> GetAllWithIncludes(params string[] navigationProperties)
        {
            IQueryable<T> query = GetAll();
            // sadece istenen türden navigationları include edecek           

            // istenen navigation proplar içerisinde foreach ile dönüp include ediyoruz.

            foreach (var navigationProperty in navigationProperties)
            {
                query = query.Include(navigationProperty);
            }

            return query;
        }

        public IQueryable<T> GetAllDeleted()
        {
            return entities.Where(e => e.DataStatus == DataStatus.Deleted).AsNoTracking();
        }


        public T GetByDeletedId(int id)
        {
            return entities.AsNoTracking().FirstOrDefault(e => e.Id == id && e.DataStatus == DataStatus.Deleted);
        }

        public T GetById(int id)
        {
            return entities.AsNoTracking().FirstOrDefault(e => e.Id == id && e.DataStatus != DataStatus.Deleted);
        }

        public void Insert(T entity)
        {
            entity.DataStatus = DataStatus.Added;
            entity.CreatedTime = DateTime.Now;
            entities.Add(entity);
            _db.SaveChanges();
        }

        public void Remove(T entity)
        {
            entities.Remove(entity);
            _db.SaveChanges();
        }

        public IQueryable<T> Search(Expression<Func<T, bool>> predicate)
        {
            var all = entities.Where(e => e.DataStatus != DataStatus.Deleted);
            return all.Where(predicate);
        }
        public IQueryable<T> SearchWithIncludes(Expression<Func<T, bool>> predicate)
        {
            var all = Search(predicate);

            T instance = new T();
            Type type = instance.GetType();

            PropertyInfo[] propertyInfos = type.GetProperties();

            foreach (PropertyInfo propInfo in propertyInfos.Where(p => p.PropertyType.GetInterfaces().Where(i => i.Name == "IEntity").Any()).ToList())
            {
                all = all.Include(propInfo.Name);
            }

            return all;
        }

        public void Update(T entity)
        {

            entity.CreatedTime = entities.AsNoTracking().FirstOrDefault(e => e.Id == entity.Id).CreatedTime;

            //entity.DataStatus = DataStatus.Modified != DataStatus.Deleted ? DataStatus.Modified : DataStatus.Deleted;


            if (entity.DataStatus != DataStatus.Deleted)
            {
                entity.DataStatus = DataStatus.Modified;
                entity.ModifiedTime = DateTime.Now;
            }

            //view modelde createddate olmadığı için updateten önce createddatei getirim tekrar atamalıyız


            entities.Update(entity);
            _db.SaveChanges();

        }
    }
}
