using API.DTOs;
using API.Entities;
using API.Helpers;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace API.Interfaces
{
    public interface IMessageRepository
    {
        void AddMessage(Message message);
        void DeleteMessage(Message message);
        Task<Message> GetMessage(int id);
        Task<PagedList<MessageDto>> GetMessagesForUser(MessageParams messageParams);
        Task<IEnumerable<MessageDto>> GetMessageThread(string currentUserName, string recipientName);  
        Task<bool> SaveAllAsync();

        // Task<PagedList<MessageDto>> GetMessagesForUser(MessageParams messageParams);
        // Task<IEnumerable<MessageDto>> GetMessageThread(string currentUserName, string recipientUserName); 
        // void AddGroup(Group group);
        // void RemoveConnection(Connection connection);
        // Task<Connection> GetConnection(string connectionId);
        // Task<Group> GetMessageGroup(string groupName);
        // Task<Group> GetGroupForConnection(string connectionId);
    }
}