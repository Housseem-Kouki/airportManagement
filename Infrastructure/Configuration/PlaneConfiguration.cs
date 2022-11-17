using AM.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Configuration
{
    public class PlaneConfiguration : IEntityTypeConfiguration<Plane>
    {
        public void Configure(EntityTypeBuilder<Plane> builder)
        {
            //spécifier lid de la table
            builder.HasKey(p => p.PlaneId);
            //changer nom de la table 
            builder.ToTable("MyPlanes");
            //changer nom de la colonne
            builder.Property(p=> p.Capacity).HasColumnName("PlaneCapacity");
        }
    }
}
