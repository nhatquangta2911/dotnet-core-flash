namespace VeryFirstNamespace
{
    public class Text : PowerpointObject
    {
        public int FontSize { get; set; }
        public int FontName { get; set; }
        public void AddHyperLink(string url)
        {
            System.Console.WriteLine("Added a link to" + url);
        }
    }
}