using DALneo4j.Abstract;
using DTO;

namespace DALneo4j.Beton
{
    //all properties that identify a user:     firstname, lastname, username, email, interests, address (followings and followers (relationships))
    public class UserDALneo : IUserDALneo
    {
        Neo4JCommands cmd;
        public UserDALneo(Neo4JCommands cmd)
        {
            this.cmd = cmd;
        }



        public void Add(User user)
        {
            
        }

        public void DeleteByID(string ID)
        {
            
        }

        public List<User> GetAll()
        {
            return null;
        }

        public User GetByID(string ID)
        {
            return null;
        }

        public void Update(User user)
        {
            
        }
    }
}
