using RepositoryDesignPattern.DAL;
using RepositoryDesignPattern.Repository;
using System.Net;
using System.Web.Mvc;

namespace RepositoryDesignPattern.Controllers
{
    public class EmployeeController : Controller
    {
        //private IEmployeeRepository _employeeRepositoy;

        private IGenericRepository<Employee> _genericReposity;
        private IEmployeeRepository _employeeRepository;

        public EmployeeController()
        {
            //_employeeRepositoy = new EmployeeRepository();
            _genericReposity = new GenericRepository<Employee>();
            _employeeRepository = new EmployeeRepository();
        }

        //public EmployeeController(IEmployeeRepository employeeRepositoy)
        //{
        //    _employeeRepositoy = employeeRepositoy;
        //}

        public ActionResult Index()
        {
            //return View(_genericReposity.GetAll());
            return View(_employeeRepository.GetEmployeesByGender("Male"));
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = _genericReposity.GetById((int)id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EmployeeID,Name,Gender,Salary,Dept")] Employee employee)
        {
            if (ModelState.IsValid)
            {
                _genericReposity.Insert(employee);
                _genericReposity.Save();
                return RedirectToAction("Index");
            }

            return View(employee);
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = _genericReposity.GetById((int)id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EmployeeID,Name,Gender,Salary,Dept")] Employee employee)
        {
            if (ModelState.IsValid)
            {
                _genericReposity.Update(employee);
                _genericReposity.Save();
                return RedirectToAction("Index");
            }
            return View(employee);
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = _genericReposity.GetById((int)id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            _genericReposity.Delete(id);
            _genericReposity.Save();

            return RedirectToAction("Index");
        }

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}
    }
}
