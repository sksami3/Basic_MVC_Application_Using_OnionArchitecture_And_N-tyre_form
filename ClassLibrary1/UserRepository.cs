using ClassLibrary1.Project123.Infructructure.Interfaces;
using Project123.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Project123.Infructructure.Repository.Base
{
    public class UserRepository: BaseRepository<UserAccountModel>, IUserAccountRepository
    {
    }
}
