﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class WriterManager : IWriterService
    {
        IWriterDal _writerDal;

        public WriterManager(IWriterDal writerDal)
        {
            _writerDal = writerDal;
        }

        public void AddWriter(Writer p)
        {
            _writerDal.Insert(p);
        }

        public void DeleteWriter(Writer p)
        {
            throw new NotImplementedException();
        }

        public Writer GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Writer> ListAllWriter()
        {
            throw new NotImplementedException();
        }

        public void UpdateWriter(Writer p)
        {
            throw new NotImplementedException();
        }
    }
}
