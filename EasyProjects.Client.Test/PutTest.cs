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
    public class PutTest
    {
        public PutTest()
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
        public void PutProject()
        {
            using (HttpClient client = new HttpClient(Global.BaseAddress,true, Global.Username, Global.Password))
            {
                var project = new Project();

                project.Name = "Test Project from API unittest:" + DateTime.Now.Ticks.ToString();

                project.StartDate = DateTime.Now;

                project.EndDate = DateTime.Now.AddDays(2);

                var new_project = client.Post<Project>(project);

                Assert.IsTrue(new_project.ProjectID != 0);

                new_project.Name += " Test PutProject";

                client.Put<Project>(Convert.ToString(new_project.ProjectID), new_project);

                client.Delete<Project>(Convert.ToString(new_project.ProjectID.ToString()));
            }
        }

        [TestMethod]
        public void PutActivities()
        {
            using (HttpClient client = new HttpClient(Global.BaseAddress, true, Global.Username, Global.Password))
            {
                var projects = client.Query<Project>().Take(1).ToList();

                Assert.IsTrue(projects.Count != 0);

                var activity = new Task();

                activity.Name = "Test Task from API unittest:" + DateTime.Now.Ticks.ToString();
                activity.TaskTypeID = 1;

                activity.ProjectID = projects[0].ProjectID;

                var new_task = client.Post<Task>(activity);

                Assert.IsTrue(new_task.TaskID != 0);

                new_task.Name += " Test PutActivities";

                client.Put<Task>(Convert.ToString(new_task.TaskID), new_task);
            }
        }
        
    }
}
