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

    //IdentityUser için EntityFraework packages indiriyoruz,
    //IBaseUser için implement yapıyoruz, IbaseUser biz oluşturuyoruz, paketten gelmiyor
    
    public class AppUser : IdentityUser, IBaseUser
    {

        private DateTime _createdDate = DateTime.Now;
        private Status _status = Status.Active;


        public DateTime CreatedDate { get => _createdDate; set => _createdDate = value; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public Status Status { get => _status; set => _status = value; }
    }
}
