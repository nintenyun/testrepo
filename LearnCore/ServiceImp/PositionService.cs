using LearnCore.Domain;
using LearnCore.IService;
using LearnCore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnCore.ServiceImp
{
    public class PositionService : Repository<Position>, IPosition
    {
        public PositionService(ApplicationDbContext Context) : base(Context)
        {
        }
    }
}
