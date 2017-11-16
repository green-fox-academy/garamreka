using AuthorApp.Entities;
using AuthorApp.Models;
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

        public List<Author> GetAllAuthor()
        {
            return AuthorContext.Author.ToList();
        }

        public Author GetAuthorById(long id)
        {
            return AuthorContext.Author.FirstOrDefault(a => a.Id == id);
        }

        public void AddAuthor(Author author)
        {
            AuthorContext.Author.Add(author);
            AuthorContext.SaveChanges();
        }

        public void RemoveAuthor(Author author)
        {
            AuthorContext.Author.Remove(author);
            AuthorContext.SaveChanges();
        }

        public void UpdateAuthor(Author author, long id)
        {
            var selectedAuthor = GetAuthorById(id);
            selectedAuthor.City = author.City;

            AuthorContext.Author.Update(selectedAuthor);
            AuthorContext.SaveChanges();
        }
    }
}
