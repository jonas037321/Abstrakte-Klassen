using System;
using System.Collections.Generic;
using System.Text;

namespace Basics.Models
{
    // public class Article { }
    // generisches Interface
    // T ... steht für den zu verwendenden Datentyp (statt T könnte
    //      jeder beliebige Buchstabe verwendet werden)



    public interface IRepository<T>
    {
        bool Add(T t);
        bool Remove(T t);
        T getById(int id);
        List<T> GetAll();
        T Update(int id, T t);
    }
}
