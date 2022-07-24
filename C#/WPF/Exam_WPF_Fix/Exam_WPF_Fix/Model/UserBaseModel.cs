using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;
public class UserBaseModel:IUserModel
{
    public List<User> _users { get; set; } = new();
    public User CurrentUser { get; set; }
    private string UsersPath = @"Resources\Users.json";


    public User? GetUser(string Login, string Password)
    {
        foreach (var item in _users)
        {
            if (item.Login == Login && item.Password == Password)
            {
                return item;
            }
        }
        return null;
    }
    public UserBaseModel()
    {
       



        if (File.ReadAllText(UsersPath).Length != 0)
            {
                if (JsonSerializer.Deserialize<List<User>>(File.ReadAllText(UsersPath)) != null)
                {
                    _users = JsonSerializer.Deserialize<List<User>>(File.ReadAllText(UsersPath));
                }
            }
    }
    public bool IsExsist(User user)
    {
        foreach (var item in _users)
        {
            if (user.Login == item.Login )
            {
                return true;
            }
        }
            return false;
    }
    public bool AddUser(User user)
    {
        if (!IsExsist(user))
        {
            _users.Add(user);
            File.WriteAllText(UsersPath, JsonSerializer.Serialize(_users)); 
            return true;
        }
        return false;
        

        
    }

}

