﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EFDiyetProgramiProje_DAL.Repository.Abstract
{
    public interface IRepository<T>
    {
        public void Insert(T entity);
        public void Update(T entity);
        public void Delete(T entity);
        public void Remove(T entity);
        public IQueryable<T> GetAll();
        public IQueryable<T> GetAllWithIncludes();
        public IQueryable<T> GetAllWithIncludes(params string[] mavigationProperties);
        public IQueryable<T> GetAllDeleted();
        public T GetById(int id);
        public T GetByDeletedId(int id);
        public IQueryable<T> Search(Expression<Func<T, bool>> predicate);
        public IQueryable<T> SearchWithIncludes(Expression<Func<T, bool>> predicate);
    }
}
