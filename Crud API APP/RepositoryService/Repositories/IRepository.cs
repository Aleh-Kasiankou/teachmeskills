﻿using System.Collections.Generic;

namespace RepositoryService.Repositories
{
    public interface IRepository<T>
    {
        List<T> GetAll();
        T GetById(int id);
        int Create(T attribute);
        void UpdateById(int id);
        void RemoveById(int id);

    }
}