using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Dotnet1.Persistance;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service;

namespace dotnet1.Controllers
{
    [Route("api/[controller]/")]
    [ApiController]
    public class ProfilesController : Controller
    {
        private readonly Dotnet1Context _context;
        private readonly ProfileService _profilService;

        public ProfilesController (Dotnet1Context context)
        {
            _context = context;
            _profilService = new ProfileService(context);
        }
        
        [HttpPost]
        [Route("")]
        [ProducesResponseType(typeof(Profils),statusCode:StatusCodes.Status200OK)]
        public async Task<ActionResult> CreateProfile ([FromBody] Profils profils)
        {
            try
            {
                var result = await _profilService.CreateProfile(profils);
                return Ok(result);
            }
            catch(Exception e)
            {
                var msg = $"Error When Create Profile. {e.Message}";
                return StatusCode(500, msg);
            }
        }

        [HttpGet]
        [Route("")]
        [ProducesResponseType(typeof(Profils), statusCode: StatusCodes.Status200OK)]
        public async Task<ActionResult> GetAllProfile()
        {
            try
            {
                var result = await _profilService.GetAllProfilsAsync();
                return Ok(result);
            }
            catch (Exception e)
            {
                var msg = $"Error When get All Profile. {e.Message}";
                return StatusCode(500, msg);
            }
        }

    }
}
