using System;
using System.Net;
using System.Web.Mvc;
using MVCDEMO.Web.Models.Entity;
using MVCDEMO.Web.Models.Interface;
using MVCDEMO.Web.Models.Service;

namespace MVCDEMO.Web.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IDepartmentSevice departmentSevice;
        public DepartmentController()
        {
            departmentSevice = new DepartmentSevice();
        }
        // GET: Department
        public ActionResult Index()
        {
            return View(departmentSevice.GetDepartments());
        }

        // GET: Department/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Department department = departmentSevice.GetDepartment(id.Value);
            if (department == null)
            {
                return HttpNotFound();
            }
            return View(department);
        }

        // GET: Department/Create
        public ActionResult Create()
        {
             return View();
        }

        // POST: Department/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Type,Status")] Department department)
        {
            if (ModelState.IsValid)
            {
                department.Id = Guid.NewGuid();
                departmentSevice.Save(department);
                return RedirectToAction("Index");
            }

            return View(department);
        }

        // GET: Department/Edit/5
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Department department = departmentSevice.GetDepartment(id.Value);
            if (department == null)
            {
                return HttpNotFound();
            }
            return View(department);
        }

        // POST: Department/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Type,Status")] Department department)
        {
            if (ModelState.IsValid)
            {
                departmentSevice.Save(department);
                return RedirectToAction("Index");
            }
            return View(department);
        }

        // GET: Department/Delete/5
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Department department = departmentSevice.GetDepartment(id.Value);
            if (department == null)
            {
                return HttpNotFound();
            }
            return View(department);
        }

        // POST: Department/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            Department department = departmentSevice.GetDepartment(id);
            //db.Departments.Remove(department);
            //db.SaveChanges();
            return RedirectToAction("Index");
        }

       
    }
}
