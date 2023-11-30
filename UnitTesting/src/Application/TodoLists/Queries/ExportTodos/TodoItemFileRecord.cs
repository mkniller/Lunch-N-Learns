using UnitTesting.Application.Common.Mappings;
using UnitTesting.Domain.Entities;

namespace UnitTesting.Application.TodoLists.Queries.ExportTodos;

public class TodoItemRecord : IMapFrom<TodoItem>
{
    public string? Title { get; init; }

    public bool Done { get; init; }
}
