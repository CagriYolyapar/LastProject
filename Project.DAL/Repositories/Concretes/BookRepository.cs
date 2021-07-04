using Project.DAL.Context;
using Project.DAL.Repositories.Abstracts;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.DAL.Repositories.Concretes
{
    public class BookRepository : BaseRepository<Book>, IBookRepository
    {
        public BookRepository(MyContext db) : base(db)
        {
        }
    }
}
