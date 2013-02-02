﻿using System;
using HomelessHackers.Web.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HomelessHackers.Web.Tests.Controllers
{
    [TestClass]
    public class OrganizationTests
    {
        [TestMethod]
        public void Get()
        {
            OrganizationsController controller = new OrganizationsController();
            var organizations = controller.Get();
            Assert.IsNotNull( organizations );
        }
    }
}