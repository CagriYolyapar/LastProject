using Project.DAL.Context;
using Project.DAL.Repositories.Abstracts;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.DAL.Repositories.Concretes
{
    public class AuthorRepository:BaseRepository<Author>,IAuthorRepository
    {

        public AuthorRepository(MyContext db):base(db)
        {

        }
    }
}
