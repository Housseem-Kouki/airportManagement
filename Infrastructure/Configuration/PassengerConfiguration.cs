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
    public class PassengerConfiguration : IEntityTypeConfiguration<Passenger>
    {
        public void Configure(EntityTypeBuilder<Passenger> builder)
        {
            //Configurer le type détenu
           
            builder.OwnsOne(p => p.FullName,
                full =>
                {
                    full.Property(f => f.FirstName).HasMaxLength(30).HasColumnName("PassFirstName");
                    full.Property(f => f.LastName).IsRequired().HasColumnName("PassLastName");


                });
            //Configurer l'heritage TPH Table pa Hierarchie
            //on a commenter car on configuer TPT dans context
           // builder.HasDiscriminator<int>("isTraveller").HasValue<Passenger>(0).HasValue<Traveller>(1).HasValue<Staff>(2);
        }



    }
}
