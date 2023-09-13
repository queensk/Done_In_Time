using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Done_In_Time.Data
{
    public class TodoService
    {
        private List<TodoItem> todoItems = new List<TodoItem>();

        public List<TodoItem> GetTodoItems()
        {
            return todoItems;
        }

        public void AddTodo(TodoItem todoItem)
        {
            todoItems.Add(todoItem);
        }

        public void UpdateTodoItem(TodoItem todoItem)
        {
            var index = todoItems.IndexOf(todoItem);
            if (index >= 0)
            {
                todoItems[index] = todoItem;
            }
        }

        public void DeleteTodoItem(TodoItem todoItem)
        {
            todoItems.Remove(todoItem);
        }
    }
}