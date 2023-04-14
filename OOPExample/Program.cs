using OOPExample;

Creator youtuber = new Youtuber();
Creator programmer = new Programmer();

List<Creator> creators = new List<Creator>() { new Youtuber(), new Programmer() };

foreach (var creator in creators)
{
    Console.WriteLine(creator.GetType().Name);
    creator.Create();
    Console.WriteLine();

}
