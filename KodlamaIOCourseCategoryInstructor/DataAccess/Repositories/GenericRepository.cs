﻿using DataAccess.Abstracts;
using DataAccess.Concretes;
using Entity.Abstracts;

namespace DataAccess.Repositories;

public class GenericRepository<T> : IGenericDal<T> where T : class, IEntity, new()
{
    public void Delete(T t)
    {
        using var context = new Context();
        context.Remove(t);
        context.SaveChanges();
    }

    public T GetByID(int id)
    {
        using var context = new Context();
        return context.Set<T>().Find(id);
    }

    public List<T> GetList()
    {
        using var context = new Context();
        return context.Set<T>().ToList();
    }

    public void Insert(T t)
    {
        using var context = new Context();
        context.Add(t);
        context.SaveChanges();
    }

    public void Update(T t)
    {
        using var context = new Context();
        context.Update(t);
        context.SaveChanges();
    }
}