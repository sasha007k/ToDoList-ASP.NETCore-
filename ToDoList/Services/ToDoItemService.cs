using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoList.Data;
using ToDoList.Models;
using Microsoft.EntityFrameworkCore;

namespace ToDoList.Services
{
    public class ToDoItemService : IToDoItemService
    {
        private readonly ApplicationDbContext _context;

        public ToDoItemService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<ToDoItem>> GetAllItemsAsync()
        {
            var items = await _context.Items
                .ToListAsync();
            return items;
        }

        public async Task<bool> AddItemAsync(ToDoItem newItem)
        {
            newItem.Id = Guid.NewGuid();
            newItem.IsDone = false;

            _context.Items.Add(newItem);

            var saveResult = await _context.SaveChangesAsync();
            return saveResult == 1;
        }


        public async Task<bool> DeleteAsync(Guid id)
        {
            var item = await _context.Items
                .Where(x => x.Id == id)
                .AsNoTracking()
                .SingleOrDefaultAsync();

            _context.Items.Remove(item);
            var saveResult = await _context.SaveChangesAsync();
            return saveResult == 1;
        }

        public async Task<bool> ChangeDoneStateAsync(Guid id)
        {
            var item = await _context.Items
                .Where(x => x.Id == id)
                .AsNoTracking()
                .SingleOrDefaultAsync();

            item.IsDone = !item.IsDone;

            _context.Items.Update(item);
            var saveResult = await _context.SaveChangesAsync();
            return saveResult == 1;
        }
    }
}
