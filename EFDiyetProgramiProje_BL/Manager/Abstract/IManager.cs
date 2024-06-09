using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EFDiyetProgramiProje_BL.Manager.Abstract
{
    internal interface IManager<TModel>
    {
        public void Insert(TModel model);
        public void Update(TModel model);
        public void Delete(TModel model);
        public TModel GetDeletedById(int model);
        public void Remove(TModel model);
        public List<TModel> GetAll();
        public List<TModel> GetAllWithIncludes();
        public List<TModel> GetAllWithIncludes(params string[] mavigationProperties);
        public List<TModel> GetAllDeleted();
        public TModel GetById(int id);
        public List<TModel> Search(Expression<Func<TModel, bool>> predicate);
        public List<TModel> SearchWithIncludes(Expression<Func<TModel, bool>> predicate);
    }
}
