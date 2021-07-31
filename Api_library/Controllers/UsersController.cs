using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api_library.Models;
using Api_library.Services;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace Api_library.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserInfoService _userInfoService;
        private readonly IMapper _mapper;
        public UsersController(IUserInfoService userInfoService,
                                    IMapper mapper)
        {
            _userInfoService = userInfoService;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<DtoUser> GetUserById([FromHeader]string userIdHeader)
        {
            return Ok($"Name = {userIdHeader}");
            //var dbUser = _userInfoService.GetUserInfoById(int.Parse(userIdHeader));
            //if (dbUser == null)
            //{
            //    return null;
            //}
            //var result = _mapper.Map<DtoUser>(dbUser);
            //return result;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

       
     
    }
}
