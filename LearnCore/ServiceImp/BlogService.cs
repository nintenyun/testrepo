using LearnCore.Domain;
using LearnCore.IService;
using LearnCore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnCore.ServiceImp
{
    public class BlogService : Repository<Blog>, IBlog
    {
        public BlogService(ApplicationDbContext Context) : base(Context)
        {
        }
    }
}
