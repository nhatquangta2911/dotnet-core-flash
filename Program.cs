using System;

namespace VeryFirstNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
           var dbMigrator = new DBMigrator(new ConsoleLogger());
           dbMigrator.Migrate();
        }
    }
}
