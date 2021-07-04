using System;
using System.Collections.Generic;
using System.Text;

namespace Project.ENTITIES.Models
{
    public  class Genre:BaseEntity
    {
        public string Title { get; set; }

        //Relational Properties

        public virtual List<Book> Books { get; set; }

    }
}
