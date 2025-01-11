using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSite.Business.Abstract;
using WebSite.Business.Concreate;
using WebSite.Entities;

namespace WebSite.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MyInfoSkillsController : Controller
    {
        private IMyInfoSkillsService _myInfoSkillsService;
        public MyInfoSkillsController()
        {
            _myInfoSkillsService = new MyInfoSkillsManager();
        }
        [HttpGet]
        public List<MyInfoSkills> Get()
        {
            return _myInfoSkillsService.GetAllMyInfoSkills();
        }
        [HttpGet("{id}")]
        public List<MyInfoSkills> Get(int id)
        {
            return _myInfoSkillsService.GetMyInfoSkillsById(id);
        }
        [HttpPost]
        public List<MyInfoSkills> Post([FromBody] List<MyInfoSkills> myInfoSkills)
        {
            return _myInfoSkillsService.CreateMyInfoSkills(myInfoSkills);
        }
        [HttpPut]
        public MyInfoSkills Put([FromBody] MyInfoSkills myInfoSkills)
        {
            return _myInfoSkillsService.UpdateMyInfoSkills(myInfoSkills);
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _myInfoSkillsService.DeleteMyInfoSkills(id);
        }
    }
}
