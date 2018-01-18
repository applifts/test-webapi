using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using TestWebApi.Domain;
using TestWebApi.Domain.Entities;
using TestWebApi.Helpers;
using TestWebApi.Services;
using TestWebApi.Services.Dtos;

namespace TestWebApi.Controllers
{
    [Authorize]
    [Route("[controller]")]
    public class CompanyController : Controller
    {
        private readonly DataContext _context;
        private IMapper _mapper;
        private readonly AppSettings _appSettings;

        public CompanyController(IMapper mapper, IOptions<AppSettings> appSettings, DataContext context)
        {
            _mapper = mapper;
            _appSettings = appSettings.Value;
            _context = context;
        }

        [AllowAnonymous]
         [HttpGet("/company")]
         public IActionResult GetAll()
         {
             var companies =   _context.Companies;
        
             var companyDtos = _mapper.Map<IList<CompanyDto>>(companies);
             return Ok(companyDtos);
         }

        [AllowAnonymous]
        [HttpPost("/company/{company}")]
        public IActionResult Register([FromBody]CompanyDto companyDto)
        {
            // map dto to entity
            var company = _mapper.Map<Company>(companyDto);

            try 
            {
                // save 
                
                _context.Companies.Add(company);
                _context.SaveChanges();
    
                return Ok();
            } 
            catch(AppException ex)
            {
                // return error message if there was an exception
                return BadRequest(ex.Message);
            }
        }
    }
}
