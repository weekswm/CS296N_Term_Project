using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using CS296N_Term_Project.Models;
using CS296N_Term_Project.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CS296N_Term_Project.Controllers
{
    public class FanStoryController : Controller
    {
        IStoryRepository repo;
        public FanStoryController(IStoryRepository r)
        {
            repo = r;
        }

        // GET: FanStories
        public IActionResult Stories()
        {
            List<FanStory> fanStories = repo.FanStories;
            return View(fanStories);
        }

        // GET: FanStory/AddStory
        [Authorize(Roles = "Member")]
        public IActionResult AddStory()
        {
            return View();
        }

        // POST: FanStory/AddStory
        [Authorize(Roles = "Member")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public RedirectToActionResult AddStory(FanStory storyForm)
        {
            if (ModelState.IsValid)
            {
                FanStory fanStory = new FanStory
                {
                    StoryText = storyForm.StoryText,
                    Name = storyForm.Name
                };
                repo.AddFanStory(fanStory);
            }
            repo.SortFanStoryByStoryTeller();
            return RedirectToAction("Stories");
        }

        [Authorize(Roles = "Member")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public RedirectToActionResult AddStoryNoSort(FanStory storyForm)
        {
            if (ModelState.IsValid)
            {
                FanStory fanStory = new FanStory
                {
                    StoryText = storyForm.StoryText,
                    Name = storyForm.Name
                };

                repo.AddFanStory(fanStory);
            }
            return RedirectToAction("Stories");
        }

        // GET: FanStory/AddComment
        [Authorize(Roles = "Member")]
        public IActionResult AddComment(string storyText)
        {
            return View("AddComment", HttpUtility.HtmlDecode(storyText));
        }

        // POST: FanStory/AddComment
        [Authorize(Roles = "Member")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public RedirectToActionResult AddComment(string storyText,
                                                 string fanName,
                                                 string commentText)
        {
            FanStory fanStory = repo.GetFanStoryByStoryText(storyText);

            Comment comment = new Comment()
            {
                CommentText = commentText,
                Commenter = fanName,
            };
            repo.AddComment(fanStory, comment);
            return RedirectToAction("Stories");
        }

        // GET: FanStory/Edit/5
        /*public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: FanStory/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            
        }

        // GET: FanStory/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: FanStory/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            
        }*/
    }
}