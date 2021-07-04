using System;
using System.Collections.Generic;
using System.Text;

namespace Project.ENTITIES.Models
{
    public class Book:BaseEntity
    {
        public string Title { get; set; }
        public string Summary { get; set; }

        public string Description { get; set; }
        public int? GenreID { get; set; }
        public int? ShelfID { get; set; }
        public int? AuthorID { get; set; }



        //Relational Properties
        public virtual Genre Genre { get; set; }
        public virtual Shelf Shelf { get; set; }
        public virtual Author Author { get; set; }



    }
}
