using StudentRegistration.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace StudentRegistration.Services
{
    public class SqlStudent : IStudentData
    {
        private StudentDbContest db;

        public SqlStudent(StudentDbContest db)
        {
            this.db = db;
        }
        public void Add(RegDetails details)
        {
            db.RegDetail.Add(details);
            db.SaveChanges();
        }

       

        public IEnumerable<RegDetails> GetAll()
        {
            return from r in db.RegDetail orderby r.Id select r;
        }

        public RegDetails Get(string id)
        {
            return db.RegDetail.FirstOrDefault(r => r.Id == id);
        }

        public void Update(RegDetails details)
        {
            var entry=db.Entry(details);
            entry.State = EntityState.Modified;
            db.SaveChanges();
        }

        public void Delete(string id)
        {
            var model=db.RegDetail.Find(id);
            db.RegDetail.Remove(model);
            db.SaveChanges();
        }
    }
}