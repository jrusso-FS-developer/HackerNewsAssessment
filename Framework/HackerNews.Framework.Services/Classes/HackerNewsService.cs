using HackerNews.Framework.Interfaces;
using HackerNews.Framework.Services.Interfaces;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using HackerNews.Framework.Classes;
using System.Linq;

namespace HackerNews.Framework.Services.Classes
{
    public class HackerNewsService : IHackerNewsService
    {
        static HttpClient client = new HttpClient();

        public async Task<List<IStory>> GetTopStories()
        {
            var stories = new List<IStory>();
            HttpResponseMessage storyListResponse = await client.GetAsync("https://hacker-news.firebaseio.com/v0/newstories.json");

            if (storyListResponse.IsSuccessStatusCode)
            {
                string storyIdListString  = await storyListResponse.Content.ReadAsStringAsync();
                List<int> storyIds = JsonConvert.DeserializeObject<List<int>>(storyIdListString);
                storyIds = storyIds.Take(20).ToList();

                foreach (var id in storyIds) {
                    HttpResponseMessage storyResponse = await client.GetAsync(string.Format("https://hacker-news.firebaseio.com/v0/item/{0}.json", id.ToString()));
                    string storyJson = await storyResponse.Content.ReadAsStringAsync();
                    stories.Add(JsonConvert.DeserializeObject<Story>(storyJson));
                }
            }

            return stories;
        }
    }
}
