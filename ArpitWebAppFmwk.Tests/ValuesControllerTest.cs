using System;
using ArpitWebAppFmwk.Controllers;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ArpitWebAppFmwk.Controllers.Tests
{
    /// <summary>This class contains parameterized unit tests for ValuesController</summary>
    [TestClass]
    [PexClass(typeof(ValuesController))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class ValuesControllerTest
    {
    }
}
