class UserService
{
    UserRepo userRepo;
    

    //Constructor
    public UserService(UserRepo userRepo)
    {
        this.userRepo = userRepo;
    }

    //Register User
    public User? RegisterUser(string firstName, string userName, string password)
    {
        User user = new User(firstName, userName, password);
        user = userRepo.AddUser(user);
        return user;
    }
    
    //Login User
    public User Login(string userName, string inputPassword)
    {
        User user = userRepo.GetUserByUsername(userName);

        if (inputPassword == user!.Password)
        {
            return user;
        }
        else
        {
            throw new ArgumentException("Password is incorrect");
        }
    }
}
