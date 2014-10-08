using System.Collections.Generic;
using RestSharp;

namespace HN_Wrapper
{
    public class HackerNews
    {
        private readonly RestClient _restClient;

        public HackerNews()
        {
            _restClient = new RestClient(HackerNewsConstants.Url);
        }

        public Story GetStoryById(int id)
        {
            var resource = string.Format(HackerNewsConstants.Story, id);
            var request = new RestRequest(resource);
            var response = _restClient.Execute<Story>(request);
            return response.Data;
        }

        /// <summary>
        /// Returns the id of the Top 100 stories
        /// </summary>
        /// <returns>The id of the Top 100 stories</returns>
        public List<int> GetTopStories()
        {
            var request = new RestRequest(HackerNewsConstants.TopStories);
            var response = _restClient.Execute<List<int>>(request);
            return response.Data;
        }
    }
}
