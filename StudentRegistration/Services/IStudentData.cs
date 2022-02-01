using StudentRegistration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentRegistration.Services
{
    public interface IStudentData
    {
        IEnumerable<RegDetails> GetAll();
        RegDetails Get(string id);
        void Add(RegDetails details);
        void Update(RegDetails details);
        void Delete(string id);
    }
}