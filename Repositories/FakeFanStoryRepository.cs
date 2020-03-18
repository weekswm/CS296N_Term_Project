using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CS296N_Term_Project.Models;

namespace CS296N_Term_Project.Repositories
{
    public class FakeFanStoryRepository : IStoryRepository
    {
        private List<FanStory> fanStories = new List<FanStory>();
        public List<FanStory> FanStories { get { return fanStories; } }

        public FakeFanStoryRepository()
        {
            if (fanStories.Count == 0) { AddTestData(); }
        }

        public void AddFanStory(FanStory fanStory) => fanStories.Add(fanStory);

        public void AddComment(FanStory fanStory, Comment comment)
        {
            fanStory.Comments.Add(comment);
        }

        public FanStory GetFanStoryByStoryText(string storyText)
        {
            FanStory fanStory = fanStories.Find(s => s.StoryText == storyText);
            return fanStory;
        }

        public FanStory GetFanStoryByFanName(string fan)
        {
            FanStory fanStory = fanStories.Find(f => f.Name == fan);
            return fanStory;
        }

        public void SortFanStoryByStoryText() => FanStories.Sort((sS1, sS2) => string.Compare(sS1.StoryText, sS2.StoryText, StringComparison.Ordinal));

        public void SortFanStoryByStoryTeller() => FanStories.Sort((fS1, fS2) => string.Compare(fS1.Name, fS2.Name, StringComparison.Ordinal));

        void AddTestData()
        {
            // story 1, user 1
            FanStory fanStory1 = new FanStory()
            {
                Name = "FakeUser1",
                StoryText = "Fake Story1"
            };
            fanStories.Add(fanStory1);


            // story 2, user 2
            FanStory fanStory2 = new FanStory()
            {
                Name = "FakeUser2",
                StoryText = "Fake Story2"
            };

            // new comment from user
            Comment comment = new Comment()
            {
                CommentText = "FakeComment",
                Commenter = "Fake Commenter1",
            };
            // Adding comment to story 2
            fanStory2.Comments.Add(comment);

            fanStories.Add(fanStory2);


            // story 3, user 3
            FanStory fanStory3 = new FanStory()
            {
                Name = "FakeUser3",
                StoryText = "Fake StoryText3"
            };
            fanStories.Add(fanStory3);

        }
    }
}
