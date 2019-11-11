using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CompileError.Model.Model;
using CompileError.Manager.Manager;


namespace CompilerError.Controllers
{
    public class CustomerController : Controller
    {
        CustomerManager _customerManager = new CustomerManager();
        // public string Add(string code, string name, int? id)
        [HttpGet]
        public ActionResult Add()
        {
            Customer customer = new Customer();

            return View(customer);
        }
        [HttpPost]
        public ActionResult Add(Customer customer)
        {
            string message = "";// customer.Code + customer.Name + customer.Address +
                                //     customer.Email + customer.Contact;
            if (_customerManager.Add(customer))
            {
                message = "save";

            }
            else
            {
                message = "not saved";
            }
            ViewBag.Message = message;
            return View(customer);
        }
        [HttpGet]
        public ActionResult Search()
        {
            var  Customers = _customerManager.Search(1);
           // Customer customer = new Customer();

            return View(Customers);
        }
        [HttpGet]
        public ActionResult GetAll()
        {
            Customer customer = new Customer();
            var Customers=_customerManager.GetAll();
            ViewBag.Message = Customers;
            return View();

        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
           _customerManager.Delete(id);
            return RedirectToAction("GetAll");

        }
        
    }
}