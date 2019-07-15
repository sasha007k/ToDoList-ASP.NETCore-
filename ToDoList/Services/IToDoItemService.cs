﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoList.Models;

namespace ToDoList.Services
{
    public interface IToDoItemService
    {
        Task<List<ToDoItem>> GetIncompleteItemsAsync();
    }
}
