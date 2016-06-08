using System.Web.Mvc;

namespace AzureInputValidationTest.Controllers
{
	public class HomeController: Controller
	{
		// 1
		[ValidateInput(false)]
		public ActionResult Index(string myInput)
		{
			ViewBag.MyInputValue = myInput;
			return View();
		}
	}
}