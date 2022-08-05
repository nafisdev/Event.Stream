public static class EntityLoader
{
    public static SQLEntitities SQLEntitities;
    public static List<QueryEntityMap> QueryEntityMap;

    public static void Initialize()
    {
        SQLEntitities = JsonReader.readEntityDependenciesFromConfig();
        QueryEntityMap = JsonReader.readQueryEntityMapperFromConfig();
    }

}