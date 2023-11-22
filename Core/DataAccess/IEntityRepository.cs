using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    //generic constraint
    //class ; referans tip olabilir demek
    //IEntity; IEntity veya IEntity implement eden bir nesne olabilir
    //newlenebilir olmalı; interface için bir filtre
    public interface IEntityRepository<T> where T: class, IEntity, new()
    {
        //interfacein kendisi default internaldır. Ancak içindeki operasyonlar(metotlar) default publictir.
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
