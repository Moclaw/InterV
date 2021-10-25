using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoApp.Data;

namespace TodoApp.Services
{
    public class TodoService
    {   
        protected readonly ApplicationDbContext _dbcontext;
        public TodoService(ApplicationDbContext _db)
        {
            _dbcontext = _db;
        }
        public List<TodoItem> GetAllTodo()
        {
            return _dbcontext.todolist.ToList();
        }
        public bool InserTodo(TodoItem addTodo)
        {
            _dbcontext.todolist.Add(addTodo);
            _dbcontext.SaveChanges();
            return true;
        }
        public bool UpdateTodo(TodoItem updateTodo)
        {
            var TodoUpdate = _dbcontext.todolist.FirstOrDefault(u => u.id == updateTodo.id);
            if (TodoUpdate != null)
            {
                TodoUpdate.title = updateTodo.title;
                TodoUpdate.note = updateTodo.note;
                TodoUpdate.done = updateTodo.done;
                _dbcontext.SaveChanges();
            }
            else
            {
                return false;
            }
            return true;
        }
        public bool DeleteTodo(TodoItem deleteTodo)
        {
            var TodoDel = _dbcontext.todolist.FirstOrDefault(u => u.id == deleteTodo.id);
            if (TodoDel != null)
            {
                _dbcontext.Remove(TodoDel);
                _dbcontext.SaveChanges();
            }
            else
            {
                return false;
            }
            return true;
        }

    }
}
