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
        public IBlog _iblog;
        public ValuesController(IBlog iblog)
        {
            _iblog = iblog;
        }
        // GET api/values
        [HttpGet]
        public List<Blog> Get()
        {
            return _iblog.LoadListAll(q => q.title=="1");
        }

    }
}
