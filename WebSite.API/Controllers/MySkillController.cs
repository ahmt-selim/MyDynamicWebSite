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
    public class MySkillController : Controller
    {
        private IMySkillService _mySkillService;
        public MySkillController()
        {
            _mySkillService = new MySkillManager();
        }
        [HttpGet]
        public List<MySkill> Get()
        {
            return _mySkillService.GetAllMySkills();
        }
        [HttpGet("{id}")]
        public MySkill Get(int id)
        {
            return _mySkillService.GetMySkillById(id);
        }
        [HttpPost]
        public List<MySkill> Post([FromBody] List<MySkill> myskills)
        {
            return _mySkillService.CreateMySkill(myskills);
        }
        [HttpPut]
        public MySkill Put([FromBody] MySkill myskill)
        {
            return _mySkillService.UpdateMySkill(myskill);
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _mySkillService.DeleteMySkill(id);
        }
    }
}
