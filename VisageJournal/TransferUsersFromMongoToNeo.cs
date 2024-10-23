using DALmongoDB.Beton;
using DALneo4j;
using DTO;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;

namespace VisageJournal
{
    public class TransferUsersFromMongoToNeo
    {
       public async static Task DoTheThing(List<User> users)
        {
            Neo4JCommands neoCMD = new Neo4JCommands("neo4j+s://81ba7aa4.databases.neo4j.io", "neo4j", "vLTbyIDajDgR9zpPMa4pxD3bYlivHkJC5OZOTyYfG9s");

            //adding users
            for(int i = 0; i < users.Count; i++)
            {
                User userToTransfer = users[i];
                List<string> interests = new List<string>();
                for(int j = 0; j < userToTransfer.Interests.Count;j++)
                    interests.Add(userToTransfer.Interests[j].AsString);
                var dictUser = new Dictionary<string, object>
                    {
                        { "id",userToTransfer.UserID.ToString()},
                        { "userName", userToTransfer.UserName },
                        { "firstName", userToTransfer.FirstName },
                        { "lastName", userToTransfer.LastName},
                        {"email", userToTransfer.Email },
                        {"interests", interests}
                    };
                try
                {
                    await neoCMD.CreateNode("User", dictUser);
                    Console.WriteLine($"User {userToTransfer.UserName} was added!");
                }catch
                {
                    Console.WriteLine("Quelque chose ne marche pas!!!!");
                }
            }
            //adding relations
            for(int i = 0;i< users.Count;i++)
            {
                User userToAddRelationFrom = users[i];
                List<string> followings = new List<string>();
                string uID = userToAddRelationFrom.UserID.ToString();
                for(int j = 0;j<userToAddRelationFrom.FollowingIDs.Count;j++)
                {
                    string uIDToFollow = userToAddRelationFrom.FollowingIDs[j].AsString;
                    await neoCMD.CreateRelationship("User", "User", "id", "id", uID, uIDToFollow, "FOLLOWS");
                    Console.WriteLine($"Added ({userToAddRelationFrom.UserName})-[FOLLOWS]->({uIDToFollow}) sadly, its just an id, but i dont want to search whoever that person was");
                }
            }
        }
    }
}
