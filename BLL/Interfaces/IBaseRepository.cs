﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Interfaces
{
    public interface IBaseRepository<T> where T : class
    {
        int Save(T obj);
        int Update(T obj);
        int Delete(T obj);
        IList<T> GetAll();
    }
}
