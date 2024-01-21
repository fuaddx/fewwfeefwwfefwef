using ApiExample.Context;
using ApiExample.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        ApiDBContext _dbContext { get; }

        public ValuesController(ApiDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet("all")]
        public async Task<IActionResult> Get()
        {
            return Ok(await _dbContext.users.Select(u => new UserListItemDto
            {
                Id = u.Id,
                Name = u.Name,
                Birthday = u.Birthday,
                Surname = u.Surname,
            }).ToListAsync());
        }
    }
}
