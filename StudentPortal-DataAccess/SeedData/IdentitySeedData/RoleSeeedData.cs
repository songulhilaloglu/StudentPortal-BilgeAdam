using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentPortal_Core.Entities.UserEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPortal_DataAccess.SeedData.IdentitySeedData
{
    public class RoleSeeedData : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            var admin = new IdentityRole
            {
                Id = "6bebcad2-b4b3-46ed-b437-dbb5d4373229",
                Name = "admin",
                NormalizedName = "ADMIN"
            };

            var student = new IdentityRole
            {
                Id = "4554501c-499a-47ef-b2cf-60dfffa42aa9",
                Name = "student",
                NormalizedName = "STUDENT"
            };


            var teacher = new IdentityRole
            {
                Id = "0f38a670-2f7b-4e35-99d4-357018ff35fe",
                Name = "teacher",
                NormalizedName = "TEACHER"
            };

            var hrPersonal = new IdentityRole
            {
                Id = "32f065e3-1790-4b27-95cf-948252f5d0d6",
                Name = "hrPersonal",
                NormalizedName = "HRPERSONAL"
            };

            builder.HasData(admin, student, teacher, hrPersonal);

        }
    }
}
