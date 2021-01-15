using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AsignmentWCF.Helper;
using AsignmentWCF.Models;
using AsignmentWCF.ServiceReference1;

namespace AsignmentWCF.Controllers
{
    public class StudentClientsController : Controller
    {


        // GET: StudentClients
        public ActionResult Index()
        {
            List<StudentClient> listStudent = new List<StudentClient>();
            ServiceClient serviceClient = new ServiceClient();
            var inDbListStd = serviceClient.GetListStudents();
            //convert to view model
            foreach (var std in inDbListStd)
            {
                var studentClient = ConvertTypeHelper.ConvertServiceStudentToViewStudent(std);
                listStudent.Add(studentClient);
            }
            serviceClient.Close();
            return View(listStudent);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(StudentClient student)
        {
            if (ModelState.IsValid)
            {
                ServiceClient client = new ServiceClient();
                //convert to servive student

                var inDatabaseStudent = ConvertTypeHelper.ConvertViewStudentToServiceStudent(student);
                var res = client.CreateStudent(inDatabaseStudent);
                if (res != null)
                {
                    return RedirectToAction("Index");
                }
                client.Close();
            }
            return View(student);

        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            ServiceClient client = new ServiceClient();
            var serviceStd = client.GetStudentById(id);
            var viewStd = ConvertTypeHelper.ConvertServiceStudentToViewStudent(serviceStd);
            if (viewStd == null)
            {
                return RedirectToAction("Index");
            }
            return View(viewStd);
        }
        [HttpPost]
        public ActionResult Edit(StudentClient student)
        {
            if (ModelState.IsValid)
            {
                ServiceClient client = new ServiceClient();
                client.UpdateStudent(student.Id, ConvertTypeHelper.ConvertViewStudentToServiceStudent(student));
                client.Close();
                return RedirectToAction("Index");

            }
            return View(student);
        }

        public ActionResult Delete(int id)
        {
            ServiceClient client = new ServiceClient();
            client.DeleteStudent(id);
            client.Close();
            return RedirectToAction("Index");
        }
    }
}
