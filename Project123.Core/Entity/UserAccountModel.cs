using Project123.Core.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project123.Core.Entity
{
    public class UserAccountModel : BaseModel
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }
}
