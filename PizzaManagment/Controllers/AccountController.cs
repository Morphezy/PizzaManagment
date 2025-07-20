using Application.Dto;
using Application.Interfaces;
using Application.Mappers;
using Domain.Models;
using Infrastructure.DataBase;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace PizzaManagment.Controllers;
[ApiController]
[Route("Account")]
public class AccountController : ControllerBase
{
    private readonly UserManager<Customer> _userManager;
    private readonly ITokenService _tokenService;
    private readonly SignInManager<Customer> _signInManager;
    
    public AccountController(UserManager<Customer> userManager,
        ITokenService tokenService, SignInManager<Customer> signInManager)
    {
        _userManager = userManager;
        _tokenService = tokenService;
        _signInManager = signInManager;
    }
    
    [HttpPost("register")]
    public async Task<IActionResult> Register([FromBody] RegisterDto registerDto)
    {
        if(!ModelState.IsValid)
        {
            return Unauthorized("Model state is not valid");
        }

        var appUser = new Customer()
        {
            UserName = registerDto.Email,
            Email = registerDto.Email,
        };
        var result = await _userManager.CreateAsync(appUser, registerDto.Password);
        if(!result.Succeeded)
        {
            return Unauthorized(result.Errors);
        }
        var model = await  _userManager.FindByEmailAsync(registerDto.Email);
        if(model == null)
            return BadRequest("Error");
        return Ok(model.ToNewCustomerDto());
        
    }

    [HttpPost("Login")]
    public async Task<IActionResult> Login([FromBody] LoginDto loginDto)
    {
      if(!ModelState.IsValid)
          return BadRequest();
      var user = await _userManager.FindByEmailAsync(loginDto.Email);
      if(user == null)
          return Unauthorized();
      var result = await _signInManager.CheckPasswordSignInAsync(user, loginDto.Password, false);
      if(!result.Succeeded)
          return Unauthorized();
      var token = await _tokenService.GenerateToken(user);
      Response.Cookies.Append("token", token);
      return Ok(user.ToNewCustomerDto());
    }
    
    
}