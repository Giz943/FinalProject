using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Core.Entities;
//*** Core katmanı diğer katmanları referans almaz!!***
//Generic constraint: Generic kısıt demek.
//class : referans tip olabilir demek.
//IEntity: IEntity olarabilir veya IEntity implemente eden bir nesne olabilir.
// new(): new'lenebilir olmalı

namespace Core.DataAccess
{
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);//filter=null:filter vermeyedebilirsin demek

        T Get(Expression<Func<T, bool>> filter);

        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);

        
    }
}
