using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ToDoList.Models;

namespace ToDoList.Services
{
    public interface IToDoItemService
    {
        Task<List<ToDoItem>> GetAllItemsAsync();

        Task<bool> AddItemAsync(ToDoItem newItem);

        Task<bool> DeleteAsync(Guid id);

        Task<bool> ChangeDoneStateAsync(Guid id);
    }
}