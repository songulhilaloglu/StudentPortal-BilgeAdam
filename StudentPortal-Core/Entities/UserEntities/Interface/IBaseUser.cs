﻿using StudentPortal_Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPortal_Core.Entities.UserEntities.Interface
{
    public interface IBaseUser
    {
        // BaseEntityden katılım alamıyoruz, çünkü 2 tane id olmasın

        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public Status Status { get; set; }
    }
}
