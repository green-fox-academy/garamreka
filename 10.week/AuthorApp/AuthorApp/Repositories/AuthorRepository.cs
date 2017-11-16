using AuthorApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthorApp.Repositories
{
    public class AuthorRepository
    {
        AuthorContext AuthorContext;

        public AuthorRepository(AuthorContext authorContext)
        {
            this.AuthorContext = authorContext;
        }
    }
}
