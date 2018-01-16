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
using TestWebApi.Domain.Entities;
using TestWebApi.Helpers;
using TestWebApi.Services;
using TestWebApi.Services.Dtos;

namespace TestWebApi.Controllers
{
    [Authorize]
    [Route("[controller]")]
    public class AddIndividualController : Controller
    {
        private IUserService _userService;
        private IMapper _mapper;
        private readonly AppSettings _appSettings;

        public AddIndividualController(
            IUserService userService,
            IMapper mapper,
            IOptions<AppSettings> appSettings)
        {
            _userService = userService;
            _mapper = mapper;
            _appSettings = appSettings.Value;
        }

        [HttpPost("/{people}")]
        public IActionResult Register([FromBody]PeopleDto peopleDto)
        {
            // map dto to entity
            //var user = _mapper.Map<People>(peopleDto);

            try 
            {
                // save 
                //_userService.Create(user, userDto.Password);
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
