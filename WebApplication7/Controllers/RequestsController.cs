using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication7.Data;
using WebApplication7.Models;

namespace WebApplication7.Controllers
{
    public class RequestsController : Controller
    {
        // GET: Requests
        public ActionResult Index()
        {
            return View(RequestStore.Requests);
        }
        [HttpGet]
        public ActionResult Filter(RequestStatus? status)
        {
            if (status == null)
            {
                return View("Index", RequestStore.Requests);
            }
            var Requests = RequestStore.Requests.Where(r => r.Status == status).ToList();
            return View("Index", Requests);

        }
        [HttpGet]
        public ActionResult Details(int id)
        {
            var request = RequestStore.Requests.FirstOrDefault(r => r.Id == id);
            if (request == null)
            {
                return HttpNotFound();
            }
            return View(request);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(ConsultationRequest request)
        {
            if (!ModelState.IsValid)
            {
                return View(request);
            }
            request.Status = RequestStatus.New;
            request.Id = RequestStore.Requests.Max(r => r.Id) + 1;
            RequestStore.Requests.Add(request);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var request = RequestStore.Requests.FirstOrDefault(r => r.Id == id);
            if (request == null)
            {
                return HttpNotFound();
            }
            return View(request);
        }

        [HttpPost]
        public ActionResult Edit(ConsultationRequest request)
        {
            if (!ModelState.IsValid)
            {
                return View(request);
            }
            var existingRequest = RequestStore.Requests.FirstOrDefault(r => r.Id == request.Id);
            if (existingRequest == null)
            {
                return HttpNotFound();
            }
            existingRequest.StudentName = request.StudentName;
            existingRequest.Date = request.Date;
            existingRequest.Status = request.Status;
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var request = RequestStore.Requests.FirstOrDefault(r => r.Id == id);
            if (request == null)
            {
                return HttpNotFound();
            }
            return View(request);
        }

        [HttpPost]
        public ActionResult DeleteConfirmed(int id)
        {
            var request = RequestStore.Requests.FirstOrDefault(r => r.Id == id);
            if (request == null)
            {
                return HttpNotFound();
            }
            RequestStore.Requests.Remove(request);
            return RedirectToAction("Index");


        }
    }
}