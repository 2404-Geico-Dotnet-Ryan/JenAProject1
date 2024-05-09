class Task
{
    private int id;
    public int clientId { get; set;}
    public string message = "";



    //Constructor
    public Task(string Message, int ClientId)
    {
       
        ClientId = clientId;
        Message = message;
    }

    //ToString
    /* public override ToString()
    {
        ToString will go here
    }*/

}