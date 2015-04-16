using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using CheckboxListFor.Models;

namespace CheckboxListFor.Controllers
{
	public class HomeController : Controller
	{
		[HttpGet]
		public ActionResult Index()
		{
			ViewBag.Message = "Please fill the following the form?";
            var model = new MyModel
            {
                LanguageOptions = new Dictionary<MyType, string>()
			                                	{
													{MyType.CSharp, "C# .Net"},
			                                		{MyType.VB, "VB .Net"},
			                                		{MyType.Java, @"Java/Java Scripts/JQurey"},
                                                    {MyType.CPlus, "C++"}
			                                	}
            };
            return View(model);
		}

		[HttpPost]
		public ActionResult Index(MyModel model)
		{
			if (ModelState.IsValid)
			{
                string lanuguages = model.SelectedLanguages.Aggregate("", (current, item) => (String.IsNullOrEmpty(current) ? current : current + ",") + model.LanguageOptions[item].ToString());

                ViewBag.Message = string.Format("Hi {0}, Language{1} you know: {2}. ", model.Name, model.SelectedLanguages.Count() > 1 ? "s" : "", lanuguages);
			}
			return View(model);
		}

		public ActionResult About()
		{
			return View();
		}
	}
}
