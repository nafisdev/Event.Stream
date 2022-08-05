using System.Text.Json;
using Event.Stream;

public class JsonReader
{

    public static SQLEntitities readEntityDependenciesFromConfig()
    {
        // {"Entities":[{"name":"test","dependencies":["string1","string2"]}]}
        SQLEntitities source = new SQLEntitities();
        using (StreamReader r = new StreamReader("config/entityDependencies.json"))
        {
            string json = r.ReadToEnd();
            source = JsonSerializer.Deserialize<SQLEntitities>(json);
        }
        return source;
    }

    public static List<QueryEntityMap> readQueryEntityMapperFromConfig()
    {
        List<QueryEntityMap> source = new List<QueryEntityMap>();
        using (StreamReader r = new StreamReader("config/queryEntityMapper.json"))
        {
            string json = r.ReadToEnd();

            source = JsonSerializer.Deserialize<List<QueryEntityMap>>(json);
        }
        return source;
    }
}

public class QueryEntityMap
{
    public string name { get; set; }
    public string query { get; set; }
}