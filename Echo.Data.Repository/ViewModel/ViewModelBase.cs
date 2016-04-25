using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Echo.Data.Repository.ViewModel
{
    public abstract class ViewModelBase
    {
        protected EchoEntities Context;
    }

    public abstract class ViewModelBase<TEntity> : ViewModelBase
        where TEntity : class, new()
    {
        protected TEntity Entity;

        protected TEntity DatabaseEntity;

        public ViewModelBase()
        {
            Context = new EchoEntities();
        }

        protected void CreateEntity()
        {
            Entity = new TEntity();
        }

        protected void Add(TEntity _entity)
        {
            _entity.GetType().GetProperty("ID").SetValue(_entity, Guid.NewGuid());

            Context.Set<TEntity>().Add(_entity);

            Context.SaveChanges();
        }   

        protected void Update(TEntity _entity)
        {
            Context.Entry(_entity).State = EntityState.Modified;

            Context.SaveChanges();
        }

        protected TEntity GetEntity(Func<TEntity, Boolean> predicate)
        {
            return Context.Set<TEntity>().FirstOrDefault(predicate);
        }

        protected TEntity GetLast(Func<TEntity, Boolean> predicate)
        {
            return Context.Set<TEntity>().LastOrDefault(predicate);
        }

        protected List<TEntity> Find(Func<TEntity, bool> predicate)
        {
            return Context.Set<TEntity>().Where(predicate).ToList();
        }

        protected List<TEntity> Find()
        {
            return Context.Set<TEntity>().ToList();
        }
    }
}
