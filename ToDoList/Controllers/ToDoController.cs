﻿using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToDoList.Services;
using ToDoList.Models;


namespace ToDoList.Controllers
{
    public class ToDoController : Controller
    {
        private readonly IToDoItemService _toDoItemService;

        public ToDoController(IToDoItemService toDoItemService)
        {
            _toDoItemService = toDoItemService;
        }

        public async Task<IActionResult> Index()
        {
            var items = await _toDoItemService.GetAllItemsAsync();

            var model = new ToDoViewModel()
            {
                Items = items
            };

            return View(model);
        }

        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddItem(ToDoItem newItem)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }

            var successful = await _toDoItemService.AddItemAsync(newItem);
            if (!successful)
            {
                return BadRequest("Could not add item.");
            }

            return RedirectToAction("Index");
        }
               
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(Guid id)
        {
            if (id == Guid.Empty)
            {
                return RedirectToAction("Index");
            }

            var successful = await _toDoItemService.DeleteAsync(id);
            if (!successful)
            {
                return BadRequest("Could not delete this item.");
            }

            return RedirectToAction("Index");
        }

        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ChangeDoneState(Guid id)
        {
            if (id == Guid.Empty)
            {
                return RedirectToAction("Index");
            }

            var successful = await _toDoItemService.ChangeDoneStateAsync(id);
            if (!successful)
            {
                return BadRequest("Could not mark item as done.");
            }

            return RedirectToAction("Index");
        }
    }
}
