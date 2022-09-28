﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntitiesLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class WriterManager : IWriterService
    {
        private readonly IWriterDal _writerDal;
        public WriterManager(IWriterDal writerDal)
        {
            _writerDal = writerDal;
        }
        public void DeleteT(Writer entity)
        {
            throw new NotImplementedException();
        }

        public Writer GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Writer> GetListAll()
        {
            return _writerDal.GetListAll();
        }

        public void InsertT(Writer entity)
        {
            _writerDal.Insert(entity);
        }

        public void UpdateT(Writer entity)
        {
            throw new NotImplementedException();
        }
    }
}
