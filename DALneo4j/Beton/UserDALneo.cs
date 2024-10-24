using DALneo4j.Abstract;
using DTO;
using Neo4jClient.Cypher;

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
        async public Task Add(User user)
        {
            List<string> interests = new List<string>();
            for (int j = 0; j < user.Interests.Count; j++)
                interests.Add(user.Interests[j].AsString);
            var dictUser = new Dictionary<string, object>
                    {
                        { "id",user.UserID.ToString()},
                        { "userName", user.UserName },
                        { "firstName", user.FirstName },
                        { "lastName", user.LastName},
                        {"email", user.Email },
                        {"interests", interests}
                    };
            await cmd.CreateNode("User", dictUser);
        }
        async public Task DeleteByID(string ID)
        {
            await cmd.DetachDelete("User", "id", ID);
        }

        //public List<User> GetAll()
        //{
        //    return null;
        //}

        //asypublic User GetByID(string ID)
        //{
        //    return null;
        //}

        async public Task Update(User user)
        {
            
        }
    }
}
