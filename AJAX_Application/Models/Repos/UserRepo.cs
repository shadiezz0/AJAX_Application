using AJAX_Application.Models.Data;
using AJAX_Application.Models.Repos;
using Repo.Models.Data;

namespace Repo.Models.Repos
{
    public class UserRepo : IRepoProj<User>
    {
        private readonly AppDbConext conext;

        public UserRepo(AppDbConext conext)
        {
            this.conext = conext;
        }
        public void Add(User user)
        {
            conext.Users.Add(user);
            conext.SaveChanges();
        }

        public User Find(int Id)
        {
            throw new NotImplementedException();
        }

        public List<User> List()
        {
            return conext.Users.ToList();
        }

        public List<User> ListByFilter(Func<User, bool> lamda)
        {
            throw new NotImplementedException();
        }
    }
}
