using Api;
using System;

public class UsersService (IUserRepository userRepository) :IUserService
{
    public string AddUser(UserDTO userDTO)
    {
        if (userDTO == null)
        {
            return "failed";
        }
        var user = new User( );
        return userRepository.Add(user);
    }
    public string UpdateUser(UserDTO userDTO)
    {
        if (userDTO == null)
        {
            return "failed";
        }
        var user = new User();
        return userRepository.Update(user);
    }
    public User GetUser(int id)
    {
        return userRepository.Get(id);
    }
}
