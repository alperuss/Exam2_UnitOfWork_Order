using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Sınav2.Controllers
{
    public class UsersController : Controller
    {
       
        private readonly Interfaces.IUnitOfWork _unitOfWork;
        public UsersController(Interfaces.IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var users = _unitOfWork.UserRepository.GetAll();
            return new JsonResult(users);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var users = _unitOfWork.UserRepository.GetById(id);
            return new JsonResult(users);
        }
        [HttpPost]
        public IActionResult Insert([FromBody]Models.User user)
        {
            _unitOfWork.UserRepository.Insert(user);
            _unitOfWork.Complete();
            return new JsonResult(user);
        }
        [HttpPut]
        public IActionResult Update([FromBody]Models.User user)
        {
            _unitOfWork.UserRepository.Update(user);
            _unitOfWork.Complete();
            return new JsonResult(user);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _unitOfWork.UserRepository.Delete(id);
            _unitOfWork.Complete();
            return Ok();
        }
    }
}