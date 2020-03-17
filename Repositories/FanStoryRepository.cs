using CS296N_Term_Project.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CS296N_Term_Project.Repositories
{
    public class FanStoryRepository : IStoryRepository
    {
        private AppIdentityDbContext context;
        public FanStoryRepository(AppIdentityDbContext appDbContext)
        {
            context = appDbContext;
        }

        public List<FanStory> FanStories
        {
            get
            {
                var userStories = context.FanStories
                    .Include(story => story.Comments)
                    .ToList();

                return userStories;
            }
        }

        public void AddFanStory(FanStory fanStory)
        {
            context.FanStories.Add(fanStory);
            context.SaveChanges();
        }

        public void AddComment(FanStory fanStory, Comment comment)
        {
            context.Comments.Add(comment);
            fanStory.Comments.Add(comment);
            context.FanStories.Update(fanStory);
            context.SaveChanges();
        }

        public FanStory GetFanStoryByStoryText(string storyText)
        {
            FanStory fanStory = context.FanStories.FirstOrDefault(f => f.StoryText == storyText);
            return fanStory;
        }

        public FanStory GetFanStoryByFanName(string fanName)
        {
            FanStory fanStory = context.FanStories.FirstOrDefault(f => f.Name == fanName);
            return fanStory;
        }

        public void SortFanStoryByStoryText()
        {
            context.FanStories.OrderBy(fanStory => fanStory.StoryText);
        }

        public void SortFanStoryByStoryTeller()
        {
            context.FanStories.OrderBy(fanStory => fanStory.Name);
        }
    }
}
