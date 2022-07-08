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
        if (JsonSerializer.Deserialize<List<User>>(File.ReadAllText(@"C:\HomeWork\Exam_WPF\Exam_WPF\Recources\Users.json")) != null)
        {
            _users = JsonSerializer.Deserialize<List<User>>(File.ReadAllText(@"C:\HomeWork\Exam_WPF\Exam_WPF\Recources\Users.json"));
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
            File.WriteAllText(@"C:\HomeWork\Exam_WPF\Exam_WPF\Recources\Users.json", JsonSerializer.Serialize(_users)); 
            return true;
        }
        return false;
        

        
    }

}

