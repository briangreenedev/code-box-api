using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace OutsideBoxApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CodeBoxController : ControllerBase
    {
        [HttpPost]
        public JsonResult Create(string input)
        {
            throw new NotImplementedException();
        }
    }
}