using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_Project_4162_4271.Model
{
    public class AdminUser
    {

        public string AdminUsername { get; set; }
        public int AdminPassword { get; set; }
        public int AdminId { get; set; }
        public UserType UserType { get; set; }
    }
    public enum UserType
    {
        Admin,
        Normal
    }
}
