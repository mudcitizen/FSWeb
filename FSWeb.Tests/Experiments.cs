using System;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Extensions.Configuration;

namespace FSWeb.Tests
{

    [TestClass]
    public class Experiments
    {
        [TestMethod]
        public void TestDateToString()
        {
            DateTime dt = DateTime.Now;
            String dts = dt.ToString("d");
            Debug.WriteLine(String.Format("{0} -  {1}", dt, dts));
            Debug.WriteLine("Here boss");

        }
    }
}
