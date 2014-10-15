using System.Linq;

namespace HackerNewsWrapper.ConsoleApp
{
    static class Program
    {
        static void Main(string[] args)
        {
            var hackerNews = new HackerNews();
            hackerNews.GetTopStories();

            var stories = hackerNews.GetTopStories().Take(3).Select(hackerNews.GetStoryById).ToList();
            var user = hackerNews.GetUserById("dhouston");
            var comment = hackerNews.GetCommentById(2921983);
            var poll = hackerNews.GetPollById(126809);
            var pollOpt = hackerNews.GetPollOptionById(160705);
            var maxItemId = hackerNews.GetMaxItemId();
            var item = hackerNews.GetItemById(126809);
        }
    }
}
