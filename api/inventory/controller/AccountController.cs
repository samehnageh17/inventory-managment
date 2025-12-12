using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using inventory.Dtos.Account;
using inventory.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace inventory.controller
{
    [Route("api/Account")]
    [ApiController]
    public class AccountController:ControllerBase
    {
        private readonly UserManager<AppUser> _userManager;
        public AccountController(UserManager<AppUser> userManager)
        {
            _userManager=userManager;
        }
        [HttpPost("Register")]
        public async Task<IActionResult> Register([FromBody] RegisterDto registerDto)
        {
            try
            {
               if(!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                var appUser=new AppUser
                {
                    UserName=registerDto.UserName,
                    Email=registerDto.Email
                };
                var CreatedUser=await _userManager.CreateAsync(appUser,registerDto.Password);
                if(CreatedUser.Succeeded)
                {
                    var RoleResult=await _userManager.AddToRoleAsync(appUser,"User");
                    if(RoleResult.Succeeded)
                    {
                        return Ok("User Registered Successfully");
                    }
                    else
                    {
                        return StatusCode(500,"Error while assigning role");
                    }
                }
                else
                {
                    return StatusCode(500,"User Registration Failed");
                }
            }
            catch(Exception ex)
            {
                return StatusCode(500,ex.Message);
            }
        }
    }
}