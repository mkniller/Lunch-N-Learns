using UnitTesting.Application.TodoLists.Queries.ExportTodos;

namespace UnitTesting.Application.Common.Interfaces;

public interface ICsvFileBuilder
{
    byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
}
