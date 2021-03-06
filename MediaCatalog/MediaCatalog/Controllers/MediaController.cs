﻿using System;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using System.Web.WebPages;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using MediaCatalog.Data;
using MediaCatalog.Domain;
using MediaCatalog.Models;

namespace MediaCatalog.Controllers
{
    [Authorize]
    public class MediaController : Controller
    {
        private readonly AppContext db = new AppContext();

        public ActionResult Index()
        {
            var media = db.Media.Where(m => m.IsDeleted == false).Include(m => m.Company).Include(m => m.MediaType);
            return View(media.ToList());
        }

        public ActionResult GetGridMediaList([DataSourceRequest] DataSourceRequest request)
        {

            var media = db.Media.Where(m => m.IsDeleted == false).Include(m => m.Company).Include(m => m.MediaType).Project().To<MediaViewModel>();
            return Json(media.ToDataSourceResult(request));
        }


        public ActionResult Details(int? id)
        {
            if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var media = db.Media.Find(id);
            if (media == null)
            {
                return HttpNotFound();
            }
            return View(media);
        }

        public ActionResult Create()
        {
            ViewBag.MediaTypeId = new SelectList(db.MediaTypes, "Id", "Name");

            return View(new CreateMediaViewModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Title,ISBN,Summary,ReceiptDate,Review,Purchased,Donate,Active,CompanyId,MediaTypeId")] CreateMediaViewModel model)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.CompanyId = new SelectList(db.Companies, "Id", "Name", model.CompanyId);
                ViewBag.MediaTypeId = new SelectList(db.MediaTypes, "Id", "Name", model.MediaTypeId);
                return View(model);
            }

            var media = new Media();
            Mapper.Map(model, media);
            if (model.CompanyId.IsInt())
            {
                media.CompanyId = Convert.ToInt32(model.CompanyId);
            }
            else
            {
                var company = new Company()
                {
                    Name = model.CompanyId,
                    DateCreated = DateTime.Now,
                    DateModified = DateTime.Now,
                    CreatedUser = User.Identity.Name,
                    ModifiedUser = User.Identity.Name
                };
                db.Companies.Add(company);
                db.SaveChanges();
                media.Company = company;
            }

            media.DateCreated = DateTime.Now;
            media.DateModified = DateTime.Now;
            media.CreatedUser = User.Identity.Name;
            media.ModifiedUser = User.Identity.Name;

            db.Media.Add(media);
            db.SaveChanges();

            if (!Request.IsAjaxRequest()) return RedirectToAction("Details", media);

            var list = db.Media.Where(x => x.IsDeleted == false).Where(x => x.CompanyId == media.CompanyId).Include(m => m.Company).Include(m => m.MediaType);
            return PartialView("_MediaListView", list);
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var media = db.Media.Find(id);
            if (media == null)
            {
                return HttpNotFound();
            }
            //ViewBag.CompanyId = new SelectList(db.Companies, "Id", "Name", media.CompanyId);
            ViewBag.MediaTypeId = new SelectList(db.MediaTypes, "Id", "Name", media.MediaTypeId);
            return View(media);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Title,ISBN,Summary,ReceiptDate,Review,Purchased,Donate,Active,CompanyId,MediaTypeId")] Media media)
        {
            if (ModelState.IsValid)
            {
                media.DateModified = DateTime.Now;
                media.ModifiedUser = User.Identity.Name;
                db.Entry(media).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CompanyId = new SelectList(db.Companies, "Id", "Name", media.CompanyId);
            ViewBag.MediaTypeId = new SelectList(db.MediaTypes, "Id", "Name", media.MediaTypeId);
            return View(media);
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            var media = db.Media.Find(id);
            if (media == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //TODO: Change media delete to use remove context function
            media.DateDeleted = DateTime.Now;
            media.IsDeleted = true;
            media.DeletedUser = User.Identity.Name;
            db.SaveChanges();

            if (!Request.IsAjaxRequest()) return RedirectToAction("Index");

            var list = db.Media.Where(x => x.IsDeleted == false).Where(x => x.CompanyId == media.CompanyId).Include(m => m.Company).Include(m => m.MediaType).ToList();
            return PartialView("_MediaListView", list);
        }

        public ActionResult CreateCompanyMedia(int? companyId)
        {
            var media = new Media
            {
                CompanyId = companyId
            };
            ViewBag.MediaTypeId = new SelectList(db.MediaTypes, "Id", "Name");
            return PartialView("_CreateMedia", media);
        }

        public ActionResult CreatePersonMedia(int personId)
        {
            ViewBag.RoleId = new SelectList(db.Roles.OrderBy(r => r.Name), "Id", "Name");
            ViewBag.MediaId = new SelectList(db.Media.Where(x => x.IsDeleted == false), "Id", "Title");
            var staff = new StaffMember { PersonId = personId };

            return PartialView("_CreatePersonMedia", staff);
        }

        [HttpPost]
        public ActionResult CreatePersonMedia([Bind(Include = "PersonId,MediaId,RoleId")] StaffMember staff)
        {
            if (ModelState.IsValid)
            {
                staff.DateCreated = DateTime.Now;
                staff.DateModified = DateTime.Now;
                staff.CreatedUser = User.Identity.Name;
                staff.ModifiedUser = User.Identity.Name;

                db.StaffMembers.Add(staff);
                db.SaveChanges();


                if (!Request.IsAjaxRequest()) return new HttpStatusCodeResult(HttpStatusCode.OK);

                var list = db.StaffMembers.Where(x => x.IsDeleted == false).Where(x => x.PersonId == staff.PersonId).Include(m => m.Media).Include(r => r.Role);
                return PartialView("_PersonMediaListView", list);
            }

            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            //ViewBag.RoleId = new SelectList(db.Roles, "Id", "Name");
            //ViewBag.MediaId = new SelectList(db.Media.Where(x => x.IsDeleted == false), "Id", "Title");
            //return PartialView("_CreatePersonMedia", staff);
        }

        public ActionResult DeletePersonMedia(int id)
        {
            var mediaStaffMember = db.StaffMembers.Find(id);
            if (mediaStaffMember == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            db.StaffMembers.Remove(mediaStaffMember);
            db.SaveChanges();
            if (!Request.IsAjaxRequest()) return new HttpStatusCodeResult(HttpStatusCode.OK);

            var list = db.StaffMembers.Where(x => x.IsDeleted == false).Where(x => x.PersonId == mediaStaffMember.PersonId).Include(m => m.Media).Include(r => r.Role);
            return PartialView("_PersonMediaListView", list);
        }

        public ActionResult GetPersonMedia(int? personId)
        {
            var list = db.StaffMembers.Where(x => x.IsDeleted == false).Where(x => x.PersonId == personId).Include(m => m.Media).Include(r => r.Role);
            return PartialView("_PersonMediaListView", list);
        }

        public ActionResult GetMediaList(string term)
        {
            if (term == null) term = Request.Params["filter[filters][0][value]"];
            //TODO: Code Smell. Refactor If..Else statement
            if (string.IsNullOrWhiteSpace(term))
            {
                var list = db.Media.Where(x => x.IsDeleted == false).Select(x => new
                {
                    x.Id,
                    x.Title,
                    Company = x.Company.Name
                }).Take(20);
                return Json(list.ToArray(), JsonRequestBehavior.AllowGet);
            }
            else
            {
                var list = db.Media.Where(x => x.IsDeleted == false).Where(x => x.Title.Contains(term)).Select(x => new
                {
                    x.Id,
                    x.Title,
                    Company = x.Company.Name
                });
                return Json(list.ToArray(), JsonRequestBehavior.AllowGet);
            }

        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
