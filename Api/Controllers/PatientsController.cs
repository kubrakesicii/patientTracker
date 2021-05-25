﻿using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PatientsController : ControllerBase
    {
        private readonly IPatientService _patientService;

        public PatientsController(IPatientService patientService)
        {
            _patientService = patientService;
        }
        
        
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _patientService.GetAllAsync());
        }
        
        
        [HttpGet("Actives")]
        public async Task<IActionResult> GetAllActives()
        {
            return Ok(await _patientService.GetAllActivesAsync());
        }
        
        [HttpGet("Removed")]
        public async Task<IActionResult> GetAllRemoved()
        {
            return Ok(await _patientService.GetAllPassivesAsync());
        }
        
        [HttpGet("ById/{patientId}")]
        public async Task<IActionResult> GetById([FromRoute, Required] int patientId)
        {
            return Ok(await _patientService.GetAsync(patientId));
        }
        

        [HttpGet("ByPersonId/{personId}")]

        public async Task<IActionResult> GetByPersonIdAsync([FromRoute, Required] int personId)
        {
            return Ok(await _patientService.GetByPersonIdAsync(personId));
        }


        [HttpPost]
        public async Task<IActionResult> Post([FromBody] InsertPatientDto dto)
        {
            return Ok(await _patientService.InsertAsync(dto));
        }
        
        [HttpPut]
        public async Task<IActionResult> Update([FromQuery] int patientId, [FromBody] InsertPatientDto patientDto)
        {
            return Ok(await _patientService.UpdateAsync(patientId,patientDto));
        }
        
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            return Ok(await _patientService.DeleteAsync(id));
        }
    }
}