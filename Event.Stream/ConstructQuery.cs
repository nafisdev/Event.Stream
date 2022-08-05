namespace Event.Stream;
public class ConstructQuery
{
    public static IDictionary<string, Query> EntityQueryMap = ConstructMap();
    public static SQLEntitities SQLEntities = EntityLoader.SQLEntitities;

    public ConstructQuery()
    {
    }

    public static IDictionary<string, Query> ConstructMap()
    {
        IDictionary<string, Query> Map = new Dictionary<string, Query>();
        foreach (var en in EntityLoader.QueryEntityMap)
        {
            Map.Add(en.name, new Query { queryString = en.query });
        }
        return Map;
    }
    public IEnumerable<Query> CreateQueryListFromEntity(SQLEntity entity)
    {
        IList<Query> QueryList = new List<Query>(){};
        if (entity.dependencies?.Count() > 0)
        {
            foreach (var res in entity.dependencies)
            {
                QueryList=QueryList.Concat(this.CreateQueryListFromString(res)).ToList();
            }
        }
        QueryList.Add(EntityQueryMap[entity.name]);
        return QueryList;
    }

    public IEnumerable<Query> CreateQueryListFromString(String entityString)
    {
        SQLEntity entity = SQLEntities.Entities.Where(x=> x.name==entityString).FirstOrDefault();
        return CreateQueryListFromEntity(entity);
    }

}