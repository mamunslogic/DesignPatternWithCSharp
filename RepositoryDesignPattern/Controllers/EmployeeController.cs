using RepositoryDesignPattern.DAL;
using RepositoryDesignPattern.Repository;
using System;
using System.Net;
using System.Web.Mvc;

namespace RepositoryDesignPattern.Controllers
{
    public class EmployeeController : Controller
    {
        //private IEmployeeRepository _employeeRepositoy;

        //private IGenericRepository<Employee> _genericReposity;
        //private IEmployeeRepository _employeeRepository;

        private UnitOfWork _unitOfWork;

        public EmployeeController()
        {
            //_employeeRepositoy = new EmployeeRepository();
            //_genericReposity = new GenericRepository<Employee>();
            //_employeeRepository = new EmployeeRepository();
            _unitOfWork = new UnitOfWork();
        }

        //public EmployeeController(IEmployeeRepository employeeRepositoy)
        //{
        //    _employeeRepositoy = employeeRepositoy;
        //}

        public ActionResult Index()
        {
            //return View(_genericReposity.GetAll());
            //return View(_unitOfWork.EmployeeRepository.GetEmployeesByDepartment(3));
            return View(_unitOfWork.EmployeeRepository.GetAll());
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = _unitOfWork.EmployeeRepository.GetById((int)id);
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
        public ActionResult Create([Bind(Include = "EmployeeID,Name,Gender,Salary,DepartmentID")] Employee employee)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _unitOfWork.CreateTransaction();
                    if (employee.DepartmentID > 0)
                    {
                        var department = _unitOfWork.DepartmentRepository.GetById(employee.DepartmentID);
                        if (department is null)
                        {
                            _unitOfWork.DepartmentRepository.Insert(new Department
                            {
                                DepartmentID = employee.DepartmentID,
                                Name = "New Department"
                            });
                        }
                    }
                    _unitOfWork.EmployeeRepository.Insert(employee);
                    _unitOfWork.Save();
                    //Convert.ToInt16("tt");
                    _unitOfWork.CommitTransaction();
                }
                catch (Exception)
                {
                    _unitOfWork.RolebackTransaction();
                }
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
            Employee employee = _unitOfWork.EmployeeRepository.GetById((int)id);
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
                _unitOfWork.EmployeeRepository.Update(employee);
                _unitOfWork.Save();
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
            Employee employee = _unitOfWork.EmployeeRepository.GetById((int)id);
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
            _unitOfWork.EmployeeRepository.Delete(id);
            _unitOfWork.EmployeeRepository.Save();

            return RedirectToAction("Index");
        }
    }
}
