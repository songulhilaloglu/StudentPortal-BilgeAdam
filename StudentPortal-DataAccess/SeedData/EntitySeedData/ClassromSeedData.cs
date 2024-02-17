using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentPortal_Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPortal_DataAccess.SeedData.EntitySeedData
{
    public class ClassromSeedData : IEntityTypeConfiguration<ClassromSeedData>
    {
        public void Configure(EntityTypeBuilder<ClassromSeedData> builder)
        {
            builder.HasData
                (
                new Classroom
                {
                   Id = 1,
                   ClassroomName = "YZL-8445", 
                   //ClassroomNo = 10,
                   ClassroomDescription = "320 Saat .NET Full Stack Yazılım Uzmanlığı Eğitimi",
                   TeacherId = 1,
                }
                
                );
        }
    }
}
