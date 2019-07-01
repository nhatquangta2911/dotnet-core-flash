using System;

namespace VeryFirstNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            var group = new Group(2911, "Shawn");
            var post = new Post 
                        {
                            Id = 1,
                            Content = "First Post Ever"
                        };
            group.Posts.Add(post);
            System.Console.WriteLine(group.Id);
            System.Console.WriteLine(group.Name);
            System.Console.WriteLine(group.Posts[0].Content);
        }
    }
}
