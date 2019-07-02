namespace VeryFirstNamespace
{
    public class PowerpointObject
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public void Copy()
        {
            System.Console.WriteLine("Object copied to clipboard.");
        }
        public void Duplicate()
        {
            System.Console.WriteLine("Object was duplicated.");
        }
    }
}