using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentPortal_Core.Entities.UserEntities.Concrete;
using StudentPortal_DataAccess.SeedData.EntitySeedData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPortal_DataAccess.SeedData.IdentitySeedData
{
    public class UserSeedData : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            var hasher = new PasswordHasher<AppUser>();

            var admin = new AppUser
            {
                Id = "b6e412f3-9b23-4a20-a1af-d5babfd75db5",
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "admin@test.com",
                NormalizedEmail = "ADMIN@TEST.COM",
                PasswordHash = hasher.HashPassword(null, "123")
            };

            var student = new AppUser
            {
                Id = "81debc83-817b-4c81-8d04-b1a822be78c9",
                UserName = "student",
                NormalizedUserName = "STUDENT",
                Email = "student@test.com",
                NormalizedEmail = "STUDENT@TEST.COM",
                PasswordHash = hasher.HashPassword(null, "123")
            };

            var student2 = new AppUser
            {
                Id = "7c84991e-f980-4c42-8c08-f0c1fad65547",
                UserName = "student2",
                NormalizedUserName = "STUDENT2",
                Email = "student2@test.com",
                NormalizedEmail = "STUDENT2@TEST.COM",
                PasswordHash = hasher.HashPassword(null, "123")
            };

            var teacher = new AppUser
            {
                Id = "2de7310f-a715-4887-9919-7ccd29cf474a",
                UserName = "teacher",
                NormalizedUserName = "TEACHER",
                Email = "teacher@test.com",
                NormalizedEmail = "TEACHER@TEST.COM",
                PasswordHash = hasher.HashPassword(null, "123")
            };

            var hrPersonel = new AppUser
            {
                Id = "b07931af-b4ed-4e01-9a06-9560d31ab594",
                UserName = "hrPersonel",
                NormalizedUserName = "HRPERSONEL",
                Email = "hrPersonel@test.com",
                NormalizedEmail = "HRPERSONEL@TEST.COM",
                PasswordHash = hasher.HashPassword(null, "123")
            };

            builder.HasData
                (
                    admin, student, student2,teacher,hrPersonel
                );

        }
    }
}

