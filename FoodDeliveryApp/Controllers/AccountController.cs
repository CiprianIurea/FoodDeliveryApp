using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FoodDeliveryApp.DataLayers;
using System;
using System.Threading.Tasks;
using FoodDeliveryApp.DataLayers.Entities;

namespace FoodDelivery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly FoodDeliveryAppDb _context;

        public AccountController(FoodDeliveryAppDb context)
        {
            _context = context;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(User utilizator)
        {
            try
            {
                _context.Users.Add(utilizator);
                await _context.SaveChangesAsync();
                return Ok(utilizator);
            }
            catch (Exception ex)
            {
                return BadRequest($"Failed to register user: {ex.Message}");
            }
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginDto loginDto)
        {
            var utilizator = await _context.Users
                .SingleOrDefaultAsync(u => u.Email == loginDto.Email && u.Nume == loginDto.Password);

            if (utilizator == null)
            {
                return Unauthorized();
            }

            // TODO: Implement token generation logic (JWT token or session management)

            return Ok(utilizator);
        }

        [HttpPost("change-password")]
        public async Task<IActionResult> ChangePassword(ChangePasswordDto changePasswordDto)
        {
            var utilizator = await _context.Users
                .SingleOrDefaultAsync(u => u.Email == changePasswordDto.Email);

            if (utilizator == null)
            {
                return NotFound();
            }

            utilizator.Nume = changePasswordDto.NewPassword;
            await _context.SaveChangesAsync();
            return Ok(utilizator);
        }

        [HttpPost("forgot-password")]
        public IActionResult ForgotPassword(ForgotPasswordDto forgotPasswordDto)
        {
            // Simulate sending email/SMS
            Console.WriteLine($"Sending temporary password to {forgotPasswordDto.Email}");
            return Ok();
        }
    }

    public class LoginDto
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }

    public class ChangePasswordDto
    {
        public string Email { get; set; }
        public string NewPassword { get; set; }
    }

    public class ForgotPasswordDto
    {
        public string Email { get; set; }
    }
}