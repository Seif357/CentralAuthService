namespace Api
{
    public interface IUserRepository
    {
        string Add(User user);
        string Update(User user);
        User Get(int id);
    }
}
