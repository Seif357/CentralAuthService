namespace Api
{
    public class UserRepository : IUserRepository
    {
        public string Add(User user)
        {
            return user.UserName;
        }
        public string Update(User user)
        {
            return "Updated";
        }
        public User Get(int id)
        {
            return new User {
            Id = id,
            UserName = "kabs",
            Email="idm",
            PasswordHash="hi",
            PhoneNumber="1932"
            };
        }
    }
}
