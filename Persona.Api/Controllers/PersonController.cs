using System.Net;
using System;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Collections.Generic;
using Persona.Domain.Interfaces;

namespace Persona.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class PersonController : ControllerBase
    {
        private readonly IPersonService _service;

        public PersonController(IPersonService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("all")]
        public async Task<IActionResult> GetAll()
        {
            var lst = await _service.GetAllPerson();
            return Ok(lst);
        }

        [HttpGet]
        [Route("fields")]
        public async Task<IActionResult> GetFields()
        {
            var lst = await _service.GetFieldsPerson();
            return Ok(lst);
        }

        [HttpGet]
        [Route("f")]
        public async Task<IActionResult> GetFeminine()
        {
            var lst = await _service.GetFemininePerson();
            return Ok(lst);
        }

        [HttpGet]
        [Route("age")]
        public async Task<IActionResult> GetByAge()
        {
            var lst = await _service.GetByAgePerson();
            return Ok(lst);
        }

        [HttpGet]
        [Route("job")]
        public async Task<IActionResult> GetJobs()
        {
            var lst = await _service.GetJobPerson();
            return Ok(lst);
        }

        [HttpGet]
        [Route("name")]
        public async Task<IActionResult> GetContainsName()
        {
            var lst = await _service.GetContainsNamePerson();
            return Ok(lst);
        }

        [HttpGet]
        [Route("agefive")]
        public async Task<IActionResult> GetByAgeFive()
        {
            var lst = await _service.GetByAgeFivePerson();
            return Ok(lst);
        }

        [HttpGet]
        [Route("orderedage")]
        public async Task<IActionResult> GetOrdered()
        {
            var lst = await _service.GetOrderedPerson();
            return Ok(lst);
        }

        [HttpGet]
        [Route("ordereddes")]
        public async Task<IActionResult> GetOrderedDes()
        {
            var lst = await _service.GetOrderedDesPerson();
            return Ok(lst);
        }

        [HttpGet]
        [Route("count")]
        public IActionResult GetCount()
        {
            var lst = _service.GetCountPerson();
            return Ok(lst);
        }

        [HttpGet]
        [Route("exist")]
        public IActionResult GetExist()
        {
            var lst = _service.GetExistPerson();
            return Ok(lst);
        }

        [HttpGet]
        [Route("unique")]
        public IActionResult GetUnique()
        {
            var lst = _service.GetUniquePerson();
            return Ok(lst);
        }

        [HttpGet]
        [Route("take")]
        public async Task<IActionResult> GetTakeJob()
        {
            var lst = await _service.GetTakeJobPerson();
            return Ok(lst);
        }

        [HttpGet]
        [Route("skip")]
        public async Task<IActionResult> GetSkip()
        {
            var lst = await _service.GetSkipPerson();
            return Ok(lst);
        }

        [HttpGet]
        [Route("skipjob")]
        public async Task<IActionResult> GetSkipJob()
        {
            var lst = await _service.GetSkipJobPerson();
            return Ok(lst);
        }
    }
}