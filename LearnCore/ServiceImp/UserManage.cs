using LearnCore.Domain;
using LearnCore.IService;
using LearnCore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnCore.ServiceImp
{
    public class UserManage : Repository<SYS_USER>, IUserManage
    {
        public UserManage(ApplicationDbContext Context) : base(Context)
        {
        }
    }
}
