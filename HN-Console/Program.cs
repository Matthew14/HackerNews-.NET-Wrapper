using System.Linq;
using HN_Wrapper;

namespace HN_Console
{
    static class Program
    {
        static void Main(string[] args)
        {
            var hackerNews = new HackerNews();
            hackerNews.GetTopStories();


            var stories = hackerNews.GetTopStories().Take(10).Select(hackerNews.GetStoryById).ToList();
        }
    }
}
