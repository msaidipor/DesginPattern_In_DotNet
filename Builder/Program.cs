// See https://aka.ms/new-console-template for more information
using Builder;

QueryBuilder builder = new SqlServerQuery();
var query =builder.Table("Products").Select("Title").Where("where").Take(10).Skip(10).GetQuery();
Console.WriteLine(query);


QueryBuilder mongoBuilder = new MongoDbQuery();
var mongoQuery = mongoBuilder.Table("Posts").Select("Title").Where("where").Take(10).Skip(10).GetQuery();
Console.WriteLine(mongoQuery);

Console.ReadKey();