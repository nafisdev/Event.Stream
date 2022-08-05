using Event.Stream;

public class SQLEntitities
{
    public IEnumerable<SQLEntity> Entities { get; set; }
}

// {"Entities":[{"name":"test","dependencies":["string1","string2"]}]}