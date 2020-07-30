using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class NetBLL<T> where T:class
    {
        NetDAL<T> _dal =null;
        public NetBLL(NetDAL<T> dal)
        {
            _dal = dal;
        }
        // <summary>
        /// 根据条件返回实体集合
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public List<T> GetEntitysWhere(Expression<Func<T, bool>> predicate)
        {
            return _dal.GetEntitysWhere( predicate);
        }
        public List<T> GetEntitysWhereAsNoTracking(Expression<Func<T, bool>> predicate)
        {
            return _dal.GetEntitysWhereAsNoTracking(predicate);
        }
        /// <summary>
        /// 查询所有
        /// </summary>
        /// <returns></returns>
        public List<T> GetAll()
        {
            return _dal.GetAll();
        }
        /// <summary>
        /// 根据ID查询
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public T SelectId(object id)
        {
            return _dal.SelectId(id);
        }
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool Insert(T entity)
        {
            return _dal.Insert(entity);
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Delete(object id)
        {
            return _dal.Delete(id);
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool Update(T entity)
        {
            return _dal.Update(entity);
        }
    }
}
