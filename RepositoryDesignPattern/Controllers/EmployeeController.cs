using RepositoryDesignPattern.DAL;
using RepositoryDesignPattern.Repository;
using System.Net;
using System.Web.Mvc;

namespace RepositoryDesignPattern.Controllers
{
    public class EmployeeController : Controller
    {
        private IEmployeeRepository _employeeRepositoy;

        public EmployeeController()
        {
            _employeeRepositoy = new EmployeeRepository();
        }

        //public EmployeeController(IEmployeeRepository employeeRepositoy)
        //{
        //    _employeeRepositoy = employeeRepositoy;
        //}

        public ActionResult Index()
        {
            return View(_employeeRepositoy.GetAll());
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = _employeeRepositoy.GetById((int)id);
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
                _employeeRepositoy.Insert(employee);
                _employeeRepositoy.Save();
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
            Employee employee = _employeeRepositoy.GetById((int)id);
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
                _employeeRepositoy.Update(employee);
                _employeeRepositoy.Save();
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
            Employee employee = _employeeRepositoy.GetById((int)id);
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
            _employeeRepositoy.Delete(id);
            _employeeRepositoy.Save();

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
