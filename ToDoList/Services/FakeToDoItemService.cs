using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoList.Models;

namespace ToDoList.Services
{
    public class FakeToDoItemService : IToDoItemService
    {
        public Task<List<ToDoItem>> GetIncompleteItemsAsync()
        {
            var item1 = new ToDoItem
            {
                Title = "Learn ASP.NET Core",
                DueAt = DateTimeOffset.Now.AddDays(1)
            };

            var item2 = new ToDoItem
            {
                Title = "Build awesome apps",
                DueAt = DateTimeOffset.Now.AddDays(2)
            };

            return Task.FromResult(new List<ToDoItem> { item1, item2 });
        }
    }
}
