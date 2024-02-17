using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPortal_DataAccess.SeedData.IdentitySeedData
{
    public class IdentityUserRoleSeedData : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData
                (
                    new IdentityUserRole<string>
                    {
                        UserId = "b6e412f3-9b23-4a20-a1af-d5babfd75db5",
                        RoleId = "6bebcad2-b4b3-46ed-b437-dbb5d4373229",
                    },
                    new IdentityUserRole<string>
                    {
                        UserId = "81debc83-817b-4c81-8d04-b1a822be78c9",
                        RoleId = "4554501c-499a-47ef-b2cf-60dfffa42aa9",
                    },
                    new IdentityUserRole<string>
                    {
                        UserId = "7c84991e-f980-4c42-8c08-f0c1fad65547",
                        RoleId = "4554501c-499a-47ef-b2cf-60dfffa42aa9",
                    },
                    new IdentityUserRole<string>
                    {
                        UserId = "2de7310f-a715-4887-9919-7ccd29cf474a",
                        RoleId = "0f38a670-2f7b-4e35-99d4-357018ff35fe",
                    },
                    new IdentityUserRole<string>
                    {
                        UserId = "b07931af-b4ed-4e01-9a06-9560d31ab594",
                        RoleId = "32f065e3-1790-4b27-95cf-948252f5d0d6",
                    }
                );
        }
    }
}
