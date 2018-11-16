using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vue2Spa.Services;

namespace Vue2Spa.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        private ITodoItemService _todoItemService;

        public TodoController(ITodoItemService todoItemService)
        {
            _todoItemService = todoItemService;
        }
        
        [HttpGet]
        public async Task<IActionResult> GetAllTodos()
        {
            var userId = "123"; // TODO: Get actual user ID
            var todos = await _todoItemService.GetItems(userId);

            return Ok(todos);
        }
    }
}
