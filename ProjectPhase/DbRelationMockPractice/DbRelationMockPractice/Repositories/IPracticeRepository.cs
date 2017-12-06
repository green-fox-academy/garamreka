using DbRelationMockPractice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DbRelationMockPractice.Repositories
{
    public interface IPracticeRepository
    {
        string ChangeName(string oldName, string newName);
    }
}
