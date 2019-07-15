using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToDoList.Services;
using ToDoList.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ToDoList.Controllers
{
    public class ToDoController : Controller
    {
        private readonly IToDoItemService _toDoItemService;

        public ToDoController(IToDoItemService toDoItemService)
        {
            _toDoItemService = toDoItemService;
        }

        // GET: /<controller>/
        public async Task<IActionResult> IndexAsync()
        {
            var items = await _toDoItemService.GetIncompleteItemsAsync();

            var model = new ToDoViewModel()
            {
                items = items
            };

            return View(model);
        }   
    }
}
