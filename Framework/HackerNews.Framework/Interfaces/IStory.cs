using System;
using System.Collections.Generic;

namespace HackerNews.Framework.Interfaces
{
    public interface IStory
    {
        string By { get; set; }
        string Descendants { get; set; }
        int Id { get; set; }
        List<int> Kids { get; set; }
        int Score { get; set; }
        string Text { get; set; }
        int Time { get; set; }
        string Title { get; set; }
        string Type { get; set; }
        string Url { get; set; }
    }
}
