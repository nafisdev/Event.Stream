using Event.Stream;

EntityLoader.Initialize();

ConstructQuery c= new ConstructQuery();

var k = c.CreateQueryListFromString("EntityA");
Console.WriteLine(k.ToList()[0].queryString);
foreach(var a in k)
{
    Console.WriteLine(a.queryString);
}

