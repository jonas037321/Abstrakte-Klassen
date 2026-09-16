using System;
using System.Collections.Generic;
using System.Text;

namespace Basics.Models
{
    public class RepositoryDb<T> : IRepository<T>
    {
        public bool Add(T t)
        {
            // hier steht der Code, um eine Instanz von Typ T 
            // in der DB abzuspeichern.
            return true;
        }

        public List<T> GetAll()
        {
            return new List<T>();
        }

        public T getById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Remove(T t)
        {
            throw new NotImplementedException();
        }

        public T Update(int id, T t)
        {
            throw new NotImplementedException();
        }
    }
}
