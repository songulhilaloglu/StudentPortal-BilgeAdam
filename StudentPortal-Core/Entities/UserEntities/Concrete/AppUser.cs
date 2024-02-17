using Microsoft.AspNetCore.Identity;
using StudentPortal_Core.Entities.Abstract;
using StudentPortal_Core.Entities.UserEntities.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPortal_Core.Entities.UserEntities.Concrete
{

    //ıdentity user için entityframewrok core nuget VE IBASE USER IMPLAMENT EDECEĞİZ
    public class AppUser : IdentityUser, IBaseUser
    {

        private DateTime _createdDate = DateTime.Now;

        private Status _status = Status.Active;
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public Status Status { get; set; }
    }
}
