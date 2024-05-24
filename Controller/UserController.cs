class UserController   
{
     public UserService userService;


     //Constructor
    public UserController(UserService userService)
    {
        this.userService = userService;
    }

    //Method - Calls Service Method for RegisterUser
    public User RegisterUser(string firstName, string userName, string password)
    {
        User user = userService.RegisterUser(firstName, userName, password);
        return user!;
    }

    //Method - Calls Service Method for LogIn
    public User Login(string userName, string inputPassword)
    {
        User user = userService.Login(userName, inputPassword);
        return user;
    }
}