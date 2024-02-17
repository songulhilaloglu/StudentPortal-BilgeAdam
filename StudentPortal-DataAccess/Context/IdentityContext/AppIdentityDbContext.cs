﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StudentPortal_Core.Entities.UserEntities.Concrete;
using StudentPortal_DataAccess.SeedData.IdentitySeedData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPortal_DataAccess.Context.IdentityContext
{
    public class AppIdentityDbContext : IdentityDbContext<AppUser>
    {
        static AppIdentityDbContext()
        {
            AppContext.SetSwitch("Npsql.EnableLegacyTimestampBehavior", true);

        }
        public AppIdentityDbContext(DbContextOptions<AppIdentityDbContext> options) : base(options) 
        {
            Database.Migrate();
        }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new UserSeedData());
            builder.ApplyConfiguration(new RoleSeeedData());
            builder.ApplyConfiguration(new IdentityUserRoleSeedData());
           
        }
    }
}
