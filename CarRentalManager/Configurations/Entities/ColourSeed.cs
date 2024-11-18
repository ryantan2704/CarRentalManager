using CarRentalManager.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRentalManager.Configurations.Entities
{
    public class ColourSeed : IEntityTypeConfiguration<Colours>
    {
        public void Configure(EntityTypeBuilder<Colours> builder)
        {
            builder.HasData(
                new Colours
                {
                    Id=1,
                    Name="Black",
                    DateCreated= DateTime.Now,
                    DateUpdated= DateTime.Now,
                    CreatedBy= "System",
                    UpdatedBy="System"
                },
                new Colours
                {
                    Id = 2,
                    Name="Blue",
                    DateCreated= DateTime.Now,
                    DateUpdated= DateTime.Now,
                    CreatedBy= "System",
                    UpdatedBy= "System"
                }
                );

        }
    }
}
