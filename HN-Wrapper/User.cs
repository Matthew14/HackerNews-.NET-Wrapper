using System.Collections.Generic;

namespace HackerNewsWrapper
{
    public class User
    {
        public string About { get; set; }
        public int Created { get; set; }
        public int Delay { get; set; }
        public string Id { get; set; }
        public int Karma { get; set; }
        public List<int> Submitted { get; set; }
    }
}
