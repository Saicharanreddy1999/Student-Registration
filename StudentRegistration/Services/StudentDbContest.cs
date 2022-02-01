using StudentRegistration.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace StudentRegistration.Services
{
    public class StudentDbContest:DbContext
    {
        public DbSet<RegDetails> RegDetail { get; set; }
    }
}