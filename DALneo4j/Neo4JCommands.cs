using Neo4j.Driver;

namespace DALneo4j
{
    public class Neo4JCommands
    { 
        readonly IDriver driver;
        public Neo4JCommands(string URI, string USER, string PASSWORD)
        { 
            driver = GraphDatabase.Driver(URI, AuthTokens.Basic(USER, PASSWORD)); 
        }


        async public Task CreateNode(string COLLECTION, Dictionary<string, object> props)
        {
            await using (var session = driver.AsyncSession())
            {
                await session.WriteTransactionAsync(async t =>
                {
                    var cmd = $"create (a:{COLLECTION} $properties)";
                    await t.RunAsync(cmd, new { properties = props });
                });
            }
        }
        async public Task CreateRelationship(string COLLECTION1, string COLLECTION2,string PROPERTY1, string PROPERTY2, string VALUE1, string VALUE2, string RELATIONSHIP)
        {
            await using (var session = driver.AsyncSession())
            {
                await session.WriteTransactionAsync(async t =>
                {
                    var cmd = $@"match (a:{COLLECTION1} {{{PROPERTY1}:$value1}}), (b:{COLLECTION2} {{{PROPERTY2}:$value2}}) create (a)-[:{RELATIONSHIP}]->(b)";
                    await t.RunAsync(cmd, new {value1 = VALUE1,value2 = VALUE2});
                });
            }
        }
    }
}
