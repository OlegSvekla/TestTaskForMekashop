using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TestTaskForMekashop.DOMAIN.Enum
{
    public enum Role
    {
        [Display(Name = "User")]
        User = 0,
               
        [Display(Name = "Admin")]
        Admin = 2,
    }
}