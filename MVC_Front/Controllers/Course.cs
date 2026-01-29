using BusinessLogicLib;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVC_Front.Models;

namespace MVC_Front.Controllers
{
    public class Course : Controller
    {
        // GET: Course
        public ActionResult Index()
        {
            BLL model = new BLL();
            var courseData = model.GetCourseData();
            List<CourseModel> courses = new List<CourseModel>();
            foreach (var course in courseData)
            {
                courses.Add(new CourseModel
                {
                    Id = course.Id,
                    Title = course.Title,
                    Teacher = course.Teacher,
                    DurationInWeeks = course.DurationInWeeks
                });
            }
            return View(courses);
        }

        // GET: Course/Details/5
        public ActionResult Details(int id)
        {
            BLL model = new BLL();
            var courseData = model.GetCourseData(id);
            CourseModel courseModel = new CourseModel
            {
                Id = courseData.Id,
                Title = courseData.Title,
                Teacher = courseData.Teacher,
                DurationInWeeks = courseData.DurationInWeeks
            };
            return View(courseModel);
        }

        // GET: Course/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Course/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Course/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Course/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Course/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Course/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
