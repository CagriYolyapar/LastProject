using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.MAP.Configurations
{
    public class ShelfConfiguration:BaseConfiguration<Shelf>
    {
        public override void Configure(EntityTypeBuilder<Shelf> builder)
        {
            base.Configure(builder);
        }
    }
}
