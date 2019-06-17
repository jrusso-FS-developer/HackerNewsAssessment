using HackerNews.Framework.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HackerNews.Framework.Services.Interfaces
{
    public interface IHackerNewsService
    {
        Task<List<IStory>> GetTopStories();
    }
}
