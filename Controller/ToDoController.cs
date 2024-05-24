class ToDoController  
{
    private TodoService _todoService;

    //Constructor
    public ToDoController(TodoService todoService)
    {
        this._todoService = todoService;
    }

    //Method Add ToDo 
    public Todo AddTodo(string description, User user)
    {
        Todo todo = _todoService.AddTodo(description, user);
        return todo;
    }

    //Method Get All Todo's
    public List<Todo> GetAllTodos(User user)
    {
        return _todoService.GetAllTodos(user);
    }
}