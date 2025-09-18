namespace Api
{
    public interface IUserService
    {
        string AddUser(UserDTO userDTO);
        string UpdateUser(UserDTO userDTO);
        User GetUser(int id);
    }
}
