using System;
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
    public class GetByIdTest
    {
        public GetByIdTest()
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
        public void GetProjectsById()
        {
            EPHttpClient client = new EPHttpClient(Global.BaseAddress);

            client.Authorize(Global.Username, Global.Password);

            var projects = client.Query<Project>("projects").Take(1).ToList();

            Assert.IsFalse(projects.Count == 0);

            var projectId = projects[0].ProjectID;

            var project =client.Get<Project>(projectId.ToString());

            Assert.IsTrue(project.ProjectID == projectId);
        }


        [TestMethod]
        public void GetActivityById()
        {
            EPHttpClient client = new EPHttpClient(Global.BaseAddress);

            client.Authorize(Global.Username, Global.Password);

            var activities = client.Query<Task>("activities").Take(1).ToList();

            Assert.IsFalse(activities.Count == 0);

            var taskId = activities[0].TaskID;

            var task =client.Get<Task>(taskId.ToString());

            Assert.IsTrue(task.TaskID == taskId);
        }

    }
}
