using Microsoft.AspNetCore.SignalR;
using ChatApp.Server.Models;
using ChatApp.Server.Data;
using Microsoft.EntityFrameworkCore;

namespace ChatApp.Server.Hubs;
public class ChatHub : Hub
{
    private readonly AppDbContext _context;

    public ChatHub(AppDbContext context)
    {
        _context = context;
    }

    public async Task SendMessage(string username, string message)
    {
        var chatMessage = new Message { Username = username, Content = message };
        _context.Messages.Add(chatMessage);
        await _context.SaveChangesAsync();

        await Clients.All.SendAsync("ReceiveMessage", username, message);
    }

    public async Task<List<Message>> GetChatHistory()
    {
        return await _context.Messages.OrderBy(m => m.Timestamp).Take(50).ToListAsync();
    }
}
