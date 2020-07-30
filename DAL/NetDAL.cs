using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NetDAL<T> where T : class
    {

        /// <summary>
        /// 根据条件返回实体集合
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public List<T> GetEntitysWhere(Expression<Func<T, bool>> predicate)
        {
            NET net = new NET();
            return net.Set<T>().Where(predicate).ToList();
        }
        public List<T> GetEntitysWhereAsNoTracking(Expression<Func<T, bool>> predicate)
        {
            NET net = new NET();
            return net.Set<T>().AsNoTracking().Where(predicate).ToList();
        }
        /// <summary>
        /// 查询所有
        /// </summary>
        /// <returns></returns>
        public List<T> GetAll() {
            NET net = new NET();
            return net.Set<T>().ToList();
        }
        /// <summary>
        /// 根据ID查询
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public T SelectId(object id) {
            NET net = new NET();
            return net.Set<T>().Find(id);
        }
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool Insert(T entity) {
            NET net = new NET();
            net.Set<T>().Add(entity);
            return net.SaveChanges() > 0;
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Delete(object id) {
            NET net = new NET();
            T entity = net.Set<T>().Find(id);
            net.Set<T>().Remove(entity);
            return net.SaveChanges() > 0;
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool Update(T entity) {
            NET net = new NET();
            net.Entry<T>(entity).State = EntityState.Modified;
            return net.SaveChanges()>0;
        }
    }
}
