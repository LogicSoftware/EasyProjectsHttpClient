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
    public class OrderingTest
    {
        public OrderingTest()
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
        public void Projects_By_Name()
        {
            using (HttpClient client = new HttpClient(Global.BaseAddress, Global.Username, Global.Password))
            {
                string prefix = DateTime.Now.Ticks.ToString();

                var project = new Project();
                project.Name = prefix + "_ProjectByName2";
                client.Post(project);

                project.Name = prefix + "_ProjectByName1";
                client.Post(project);

                var projects = client.Query<Project>().OrderBy(p => p.Name).ToList();

                var index1 = projects.FindIndex(p => p.Name == prefix + "_ProjectByName1");
                var index2 = projects.FindIndex(p => p.Name == prefix + "_ProjectByName2");

                Assert.IsTrue(index1 < index2);
            }
        }

        [TestMethod]
        public void Tasks_By_Name()
        {
            using (HttpClient client = new HttpClient(Global.BaseAddress, Global.Username, Global.Password))
            {
                string prefix = DateTime.Now.Ticks.ToString();

                var project = new Project();
                project.Name = prefix + "_TasksByName";
                var createdProject = client.Post<Project>(project);

                var task2 = new Task
                {
                    ProjectID = createdProject.ProjectID,
                    Name = prefix + "_TaskByName2",
                    TaskTypeID = 1
                };
                client.Post(task2);

                var task1 = new Task
                {
                    ProjectID = createdProject.ProjectID,
                    Name = prefix + "_TaskByName1",
                    TaskTypeID = 1
                };
                client.Post(task1);

                var tasks = client.Query<Task>().OrderBy(t => t.Name).ToList();

                var index1 = tasks.FindIndex(t => t.Name == prefix + "_TaskByName1");
                var index2 = tasks.FindIndex(t => t.Name == prefix + "_TaskByName2");

                Assert.IsTrue(index1 < index2);
            }
        }
    }
}
