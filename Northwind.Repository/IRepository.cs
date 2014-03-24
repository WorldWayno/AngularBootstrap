﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web.Http.OData.Query;
using Northwind.Data;

namespace Northwind.Repository
{
    public interface IRepository<TEntity> where TEntity : EntityBase
    {
        TEntity Find(params object[] keyValues);
        IQueryable<TEntity> SelectQuery(string query, params object[] parameters);
        void Insert(TEntity entity);
        void InsertRange(IEnumerable<TEntity> entities);
        void InsertGraph(TEntity entity);
        void InsertGraphRange(IEnumerable<TEntity> entities);
        void Update(TEntity entity);
        void Delete(object id);
        void Delete(TEntity entity);
        IRepositoryQuery<TEntity> Query(Expression<Func<TEntity, bool>> clause = null);
        IQueryable ODataQueryable(ODataQueryOptions<TEntity> oDataQueryOptions);
        IQueryable<TEntity> All();
    }
}