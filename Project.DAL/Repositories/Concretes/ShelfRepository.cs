using Project.DAL.Context;
using Project.DAL.Repositories.Abstracts;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.DAL.Repositories.Concretes
{
    public class ShelfRepository : BaseRepository<Shelf>, IShelfRepository
    {
        public ShelfRepository(MyContext db) : base(db)
        {
        }
    }
}
