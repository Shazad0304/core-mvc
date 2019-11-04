using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AspNetCoreTodo.Models;
namespace AspNetCoreTodo.Services
{
public class FakeTodoItemService : ITodoItemService
{
public Task<TodoItem[]> GetIncompleteItemsAsync()
{
var item1 = new TodoItem
{
Title = "Learn ASP.NET Core",

};
var item2 = new TodoItem
{
Title = "Build awesome apps",

};


return Task.FromResult(new[] { item1, item2 });
}
}
}