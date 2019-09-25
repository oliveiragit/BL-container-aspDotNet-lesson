﻿using BLContainer_TP02.DAO;
using BLContainer_TP02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BLContainer_TP02.Controllers
{
    public class ContainerController : Controller
    {
        // GET: Container
        public ActionResult Index()
        {
            ContainerDAO dao = new ContainerDAO();
            IList<Container> containers = dao.Lista();

            ViewBag.Containers = containers;
            return View();
        }
        public ActionResult Form()
        {
            ViewBag.Container = new Container();
            return View();
        }

      
        [HttpPost]
        public ActionResult Adiciona(Container container)
        {
            return View();
        }
}
}