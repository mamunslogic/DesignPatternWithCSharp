using DependencyInjectionDesignPatternInWebProject.BLL;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjectionDesignPatternWithUnity.Controllers
{
    public class CustomerController : Controller
    {
        private ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        public ActionResult Index()
        {
            var customers = _customerService.GetCustomers();
            return View(customers);
        }
    }
}
