using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    public static class DbSetExtensionMethods
    {
        public static DbQuery<TEntity> Include<TEntity, Tresult>(this DbSet<TEntity> set, Expression<Func<TEntity, Tresult>> propertyExpression) where TEntity: class
        {
            var propertyName = ((MemberExpression)propertyExpression.Body).Member.Name;
            return set.Include(propertyName);
        }
    }
}
