namespace Event.Stream;
public class SQLEntity
{
    public string name {get; set;}
    public IEnumerable<string> dependencies {get; set;}
}
