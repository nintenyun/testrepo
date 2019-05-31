using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LearnCore.IService;
using LearnCore.Model;
using LearnCore.ServiceImp;
using Microsoft.AspNetCore.Mvc;

namespace LearnCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public IPosition _ipos;
        public ValuesController(IPosition ipos)
        {
            _ipos = ipos;
        }
        // GET api/values
        [HttpGet]
        public List<Position> Get()
        {
            return _ipos.LoadListAll(q => q.id!=0);
        }

    }
}
