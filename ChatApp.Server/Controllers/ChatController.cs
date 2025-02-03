using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ChatApp.Server.Data;
using ChatApp.Server.Models;

namespace ChatApp.Server.Controllers;
[ApiController]
[Route("api/chat")]
public class ChatController : ControllerBase
{
    private readonly AppDbContext _context;

    public ChatController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet("messages")]
    public async Task<IActionResult> GetMessages()
    {
        var messages = await _context.Messages.OrderBy(m => m.Timestamp).Take(50).ToListAsync();
        return Ok(messages);
    }
}
