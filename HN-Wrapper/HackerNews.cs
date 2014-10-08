using System;
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

        public Comment GetCommentById(long id)
        {
            var resource = string.Format(HackerNewsConstants.Item, id);
            var request = new RestRequest(resource);
            var response = _restClient.Execute<Comment>(request);
            return response.Data;
        }

        public User GetUserById(string id)
        {
            var resource = string.Format(HackerNewsConstants.User, id);
            var request = new RestRequest(resource);
            var response = _restClient.Execute<User>(request);
            return response.Data;
        }

        public Story GetStoryById(long id)
        {
            var resource = string.Format(HackerNewsConstants.Item, id);
            var request = new RestRequest(resource);
            var response = _restClient.Execute<Story>(request);
            return response.Data;
        }

        public PollPart GetPollOptionById(long id)
        {
            var resource = string.Format(HackerNewsConstants.Item, id);
            var request = new RestRequest(resource);
            var response = _restClient.Execute<PollPart>(request);
            return response.Data;
        }

        public Poll GetPollById(long id)
        {
            var resource = string.Format(HackerNewsConstants.Item, id);
            var request = new RestRequest(resource);
            var response = _restClient.Execute<Poll>(request);
            return response.Data;
        }

        /// <summary>
        /// Returns the id of the Top 100 stories
        /// </summary>
        /// <returns>The id of the Top 100 stories</returns>
        public List<long> GetTopStories()
        {
            var request = new RestRequest(HackerNewsConstants.TopStories);
            var response = _restClient.Execute<List<long>>(request);
            return response.Data;
        }

        /// <summary>
        /// Gets The current largest Item ID
        /// </summary>
        /// <returns>The current largest Item ID</returns>
        public long GetMaxItemId()
        {
            var request = new RestRequest(HackerNewsConstants.MaxItem);
            var response = _restClient.Execute<long>(request);

            long id;
            Int64.TryParse(response.Content, out id);
            return id;
        }
        
    }
}
