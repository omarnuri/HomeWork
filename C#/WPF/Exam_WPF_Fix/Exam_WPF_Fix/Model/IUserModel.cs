public interface IUserModel
{
    public User GetUser(string Login, string Password);
    public bool AddUser(User user);
   
} 
