using PostgreTest.Entities;
using PostgreTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PostgreTest.Repositories
{
    public class PGRepository
    {
        PGContext PGContext;

        public PGRepository(PGContext pGContext)
        {
            this.PGContext = pGContext;
        }

        public List<PG> ListAll()
        {
            return PGContext.PGs.ToList();
        }

        public void Add()
        {
            var newItem = new PG
            {
                Id = 3,
                PGTest = "tuttoVaBene"
            };

            PGContext.PGs.Add(newItem);
            PGContext.SaveChanges();
        }
    }
}
