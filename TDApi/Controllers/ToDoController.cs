using Microsoft.AspNetCore.Mvc;
using TDApi.Models;

namespace TDApi.Controllers;


[ApiController]
[Route("api/[controller]")]
public class ToDosController : ControllerBase
{
    private static readonly ToDo[] ToDos = {
       new ToDo { Id = 0, Title = "Todo 0", Complete = false, Due = "01/01/2023"},
       new ToDo { Id = 1, Title = "Todo 1", Complete = false, Due = "01/01/2023"},
       new ToDo { Id = 2, Title = "Todo 2", Complete = false, Due = "01/01/2023"},
       new ToDo { Id = 3, Title = "Todo 3", Complete = false, Due = "01/01/2023"},
       new ToDo { Id = 4, Title = "Todo 4", Complete = false, Due = "01/01/2023"},
    };
    
    [HttpGet(Name = "GetToDos")]
    public List<ToDo> Get()
    {
        return ToDos.ToList();
    }
}