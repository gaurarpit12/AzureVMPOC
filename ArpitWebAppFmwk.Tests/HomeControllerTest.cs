// <copyright file="HomeControllerTest.cs">Copyright ©  2016</copyright>
using System;
using System.Web.Mvc;
using ArpitWebAppFmwk.Controllers;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ArpitWebAppFmwk.Controllers.Tests
{
    /// <summary>This class contains parameterized unit tests for HomeController</summary>
    [PexClass(typeof(HomeController))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class HomeControllerTest
    {
        /// <summary>Test stub for Index()</summary>
        [PexMethod]
        public ActionResult IndexTest([PexAssumeUnderTest]HomeController target)
        {
            ActionResult result = target.Index();
            return result;
            // TODO: add assertions to method HomeControllerTest.IndexTest(HomeController)
        }
    }
}
