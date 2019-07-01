
using System.Collections.Generic;

namespace VeryFirstNamespace
{
    public class Group
    {
        public int Id;
        public string Name;
        public List<Post> Posts;

        public Group()
        {
            Posts = new List<Post>();
        }

        public Group(int id)
            : this()
        {
            this.Id = id;
        }

        public Group(int id, string name)
            : this()
        {
            this.Id = id;
            this.Name = name;
        }
         
    }
}