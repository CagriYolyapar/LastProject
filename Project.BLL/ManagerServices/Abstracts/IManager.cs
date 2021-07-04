using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Project.BLL.ManagerServices.Abstracts
{
    public interface IManager<T> where T:BaseEntity
    {
        //List Commands
        List<T> GetAll();
        List<T> GetActives();
        List<T> GetPassives();
        List<T> GetModifieds();

        //Modify Commands
        void Add(T item);
        void AddRange(List<T> list);
        void Delete(T item);
        void DeleteRange(List<T> list);
        void Destroy(T item);
        void DestroyRange(List<T> list);
        void Update(T item);
        void UpdateRange(List<T> list);

        //Ling
        List<T> Where(Expression<Func<T, bool>> exp);
        bool Any(Expression<Func<T, bool>> exp);
        T FirstOrDefault(Expression<Func<T, bool>> exp);
        object Select(Expression<Func<T, object>> exp);

        //Find
        T Find(int id);
    }
}
