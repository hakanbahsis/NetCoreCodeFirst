﻿using Casgem_CodeFirstProject.DAL.Context;
using Casgem_CodeFirstProject.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Casgem_CodeFirstProject.Controllers
{
    public class SocialMediaController : Controller
    {
        TravelContext context = new TravelContext();
        // GET: SocialMedia
        public ActionResult Index()
        {
            var values = context.SocialMedias.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddSocialMedia()
        {
            List<SelectListItem> values = (from x in context.Guides.ToList()
                                           select new SelectListItem
                                           {
                                               Value = x.GuideId.ToString(),
                                               Text = x.GuideName
                                           }).ToList();

            ViewBag.v = values;
            return View();
        }
        [HttpPost]
        public ActionResult AddSocialMedia(SocialMedia media)
        {
            
            return View();
        }
    }
}