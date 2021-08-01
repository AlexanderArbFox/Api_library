using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using Api_library.Models;
using Api_library.Services;
using AutoMapper;
using Library.Db;
using Library.Db.Entitties;
using Microsoft.AspNetCore.Mvc;


namespace Api_library.Controllers
{
    [System.Web.Http.Route("[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserInfoService _userInfoService;
        private readonly IMapper _mapper;
        private readonly MainContext _db;
        public UsersController(IUserInfoService userInfoService,
                                    IMapper mapper,
                                    MainContext db)
        {
            _userInfoService = userInfoService;
            _mapper = mapper;
            _db = db;
        }

        // get user by header
        [System.Web.Http.HttpGet]
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

        // GET all users
        [System.Web.Http.HttpGet]
        public async Task<ActionResult<IEnumerable<DbUser>>> Get()
        {
            return await _db.Users.ToListAsync();
        }

        // POST api/values
        [System.Web.Http.HttpPost]
        public async Task<ActionResult<DtoUser>> Post([System.Web.Http.FromBody] DbUser user)
        {
            if (user == null)
            {
                return BadRequest();
            }

            _db.Users.Add(user);
            await _db.SaveChangesAsync();
            return Ok(user);
        }

        public HttpResponseMessage PutName([System.Web.Http.FromBody] int id, [FromUri] DbUser user)
        { 
            HttpRequestMessage request = new HttpRequestMessage();
            try
            {
                var getUserId = _db.Users.FirstOrDefault(f => f.Id == id);
                if(getUserId == null)
                {

                   
                    var response = request.CreateResponse(HttpStatusCode.NotFound, $"Пользователь с номером: {id} не найден");

                    return (response);
                }
                else
                {
                    getUserId.FirstName = user.FirstName;
                    var response = request.CreateResponse(HttpStatusCode.OK, $"Пользователь с номером: {id} найден");
                    return response;
                }
            }
           catch(Exception ex) 
            {
                var response = request.CreateResponse(HttpStatusCode.BadRequest, ex);
                return response;
            }
        }
       
     
    }
}
