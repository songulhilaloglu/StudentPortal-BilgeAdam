using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentPortal_Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPortal_DataAccess.SeedData.EntitySeedData
{
    public class StudentSeedData : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasData
                (

                new Student
                {
                    Id = 1,
                    FirstName = "Öğrenci-1",
                    LastName = "ÖğrenciSoyadi-1",
                    BirthDate = new DateTime(1996,01,01),
                    Email = "student1@testcom",
                    ClassromId = 1,
                },
                new Student
                {
                    Id = 2,
                    FirstName = "Öğrenci-2",
                    LastName = "ÖğrenciSoyadi-2",
                    BirthDate = new DateTime(1996, 02, 02),
                    Email = "student2@testcom",
                    ClassromId = 1,
                }
                );
        }
    }
}
