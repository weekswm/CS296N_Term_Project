using CS296N_Term_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CS296N_Term_Project.Repositories
{
    public interface IStoryRepository
    {
        List<FanStory> FanStories { get; }
        void AddFanStory(FanStory fanStory);
        void AddComment(FanStory fanStory, Comment comment);
        FanStory GetFanStoryByStoryText(string storyText);
        FanStory GetFanStoryByFanName(string user);
        void SortFanStoryByStoryText();
        void SortFanStoryByStoryTeller();
    }
}
