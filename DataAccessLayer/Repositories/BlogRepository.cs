﻿using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class BlogRepository : IBlogDal
    {
        public void AddBlog(Blog p)
        {
            using var c = new Context();
            c.Add(p);
            c.SaveChanges();
        }

        public void DeleteBlog(Blog p)
        {
            using var c = new Context();
            c.Remove(p);
            c.SaveChanges();
        }

        public Blog GetById(int id)
        {
            using var c = new Context();
            return c.Blogs.Find(id);
        }

        public List<Blog> ListAllBlog()
        {
            using var c = new Context();
            return c.Blogs.ToList();
        }

        public void UpdateBlog(Blog p)
        {
            using var c = new Context();
            c.Update(p);
            c.SaveChanges();
        }
    }
}
