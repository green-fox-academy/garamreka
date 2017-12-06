using DbRelationMockPractice.Entities;
using DbRelationMockPractice.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DbRelationMockPractice.Repositories
{
    public class PracticeRepository : IPracticeRepository
    {
        PracticeContext PracticeContext;
        IPracticeRepository PracticeRepo;

        public PracticeRepository(PracticeContext practiceContext)
        {
            this.PracticeContext = practiceContext;
        }

        public PracticeRepository(IPracticeRepository practiceRepo)
        {
            this.PracticeRepo = practiceRepo;
        }

        public string ChangeName(string oldName, string newName)
        {
            //TODO
            return newName;
        }

        public List<Address> GetEverything()
        {
            return PracticeContext.Addresses.Include(a => a.Student).ThenInclude(b => b.Grade).ToList();
        }

        public List<Student> GetStudents()
        {
            return PracticeContext.Students.Include(a => a.Address).ToList();
        }

        public List<Address> GetAddresses()
        {
            return PracticeContext.Addresses.Include(a => a.Student).ToList();
        }

        public List<Grade> GetGrades()
        {
            return PracticeContext.Grades.Include(a => a.Students).ToList();
        }
    }
}
