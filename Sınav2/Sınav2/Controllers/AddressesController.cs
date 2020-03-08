using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Sınav2.Controllers
{
    public class AddressesController : Controller
    {
        private readonly Interfaces.IUnitOfWork _unitOfWork;
        public AddressesController(Interfaces.IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var address = _unitOfWork.AddressRepository.GetAll();
            return new JsonResult(address);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var address = _unitOfWork.AddressRepository.GetById(id);
            return new JsonResult(address);
        }
        [HttpPost]
        public IActionResult Insert([FromBody]Models.Address address)
        {
            _unitOfWork.AddressRepository.Insert(address);
            _unitOfWork.Complete();
            return new JsonResult(address);
        }
        [HttpPut]
        public IActionResult Update([FromBody]Models.Address address)
        {
            _unitOfWork.AddressRepository.Update(address);
            _unitOfWork.Complete();
            return new JsonResult(address);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _unitOfWork.AddressRepository.Delete(id);
            _unitOfWork.Complete();
            return Ok();
        }
    }
}