using System;

namespace VeryFirstNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = new Text();
            //TODO: Both text and shape are both reference 
            //      to the same object in memory
            PowerpointObject shape = text;
            text.Width = 2911;
            shape.Width = 1997;
            System.Console.WriteLine(text.Width);
        }
    }
}
