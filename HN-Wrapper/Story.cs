using System.Collections.Generic;

namespace HackerNewsWrapper
{
    public class Story : Item
    {
            public List<int> Kids { get; set; }
            public int Score { get; set; }
            
            public string Title { get; set; }

            public string Url { get; set; }
    }
}
