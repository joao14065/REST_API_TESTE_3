﻿using Microsoft.EntityFrameworkCore;
using REST_API_TESTE_3.Model.Base;
using REST_API_TESTE_3.Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;

namespace REST_API_TESTE_3.Repository.Generic
{
    public class GenericRepository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly PostgreSQLContext _context;
        private DbSet<T> dataset;

        public GenericRepository(PostgreSQLContext context)
        {
            _context = context;
            dataset = context.Set<T>();
        }


        public T Create(T item)
        {
            try
            {
                // Adiciona o objeto 'person' no banco e salva as alterações
                dataset.Add(item);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return item;

        }

        public void Delete(long Id)
        {
            var result = dataset.SingleOrDefault(p => p.Id == Id);
            try
            {
                if (result != null) dataset.Remove(result);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Exist(long id)
        {
            return dataset.Any(p => p.Id == id);
        }

        public List<T> FindAll()
        {
            return dataset.ToList();
        }

        public T FindById(long Id)
        {
            return dataset.SingleOrDefault(p => p.Id.Equals(Id));
        }

        public T Update(T item)
        {
            if (!Exist(item.Id ?? default(int))) return null;

            var result = dataset.SingleOrDefault(p => p.Id == item.Id);
            try
            {
                _context.Entry(result).CurrentValues.SetValues(item);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
    }
}
