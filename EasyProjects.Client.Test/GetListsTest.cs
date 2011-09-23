﻿using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EasyProjects.ClientModel.Entities;

namespace EasyProjects.Client.Test
{
    /// <summary>
    /// Summary description for GetListsTest
    /// </summary>
    [TestClass]
    public class GetListsTest
    {
        public GetListsTest()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void GetProjects()
        {
            EPHttpClient client = new EPHttpClient(Global.BaseAddress, true);

            client.AddBaseAuthenticationHeaders(Global.Username, Global.Password);
            
            var projects = client.Query<Project>("projects").ToList();
        }

        [TestMethod]
        public void GetActivities()
        {
            EPHttpClient client = new EPHttpClient(Global.BaseAddress);

            client.AddBaseAuthenticationHeaders(Global.Username, Global.Password);

            var tasks = client.Query<Task>("activities").ToList();
        }

        [TestMethod]
        public void GetPortfolios()
        {
            EPHttpClient client = new EPHttpClient(Global.BaseAddress);

            client.AddBaseAuthenticationHeaders(Global.Username, Global.Password);

            var portfolios = client.Query<Portfolio>("portfolios").ToList();
        }

        [TestMethod]
        public void GetUsers()
        {
            EPHttpClient client = new EPHttpClient(Global.BaseAddress);

            client.AddBaseAuthenticationHeaders(Global.Username, Global.Password);

            var users = client.Query<User>("users").ToList();
        }

    }
}
