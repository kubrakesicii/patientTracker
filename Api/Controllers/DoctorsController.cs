﻿using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DoctorsController : ControllerBase
    {
        private readonly IDoctorService _doctorService;
        
        public DoctorsController(IDoctorService doctorService) 
        {
            _doctorService = doctorService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _doctorService.GetAllAsync());
        }
        
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            return Ok(await _doctorService.GetAsync(id));
        }
        
        [HttpGet("ByDepartment")]
        public async Task<IActionResult> GetAllByDept([FromQuery, Required] int deptId)
        {
            return Ok(await _doctorService.GetAllByDeptAsync(deptId));
        }

        [HttpGet("ByDegree")]
        public async Task<IActionResult> GetAllByDegree([FromQuery, Required] int degreeId)
        {
            return Ok(await _doctorService.GetAllByDegreeAsync(degreeId));
        }

        [HttpPost]
        public async Task<IActionResult> InsertAsync(InsertDoctorDto dto)
        {
            return Ok(await _doctorService.InsertAsync(dto));
        }
        
        [HttpGet("Count")]
        public async Task<IActionResult> Count([FromQuery, Required] int hospitalId)
        {
            return Ok(await _doctorService.CountAsync(hospitalId));
        }

        [HttpGet("ByHospital")]
        public async Task<IActionResult> GetAllByHospital([FromQuery, Required] int hospitalId)
        {
            return Ok(await _doctorService.GetAllByHospitalAsync(hospitalId));
        }
        
        [HttpGet("PersonId")]
        public async Task<IActionResult> GetByPerson([FromQuery, Required] int personId)
        {
            return Ok(await _doctorService.GetByPersonIdAsync(personId));
        }
        
        
        [HttpPut]
        public async Task<IActionResult> Update([FromQuery] int id,[FromBody]  InsertDoctorDto doctorDto)
        {
            return Ok(await _doctorService.UpdateAsync(id,doctorDto));
        }
        
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            return Ok(await _doctorService.DeleteAsync(id));
        }
    }
}