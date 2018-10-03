﻿using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JackBank.Models;

namespace JackBank.Tests.Model
{
    /// <summary>
    /// Summary description for UserTest
    /// </summary>
    [TestClass]
    public class UserTest
    {

        private User testUser;
        private string testUsername;
        private string testPassword;

        public UserTest()
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

        [TestInitialize()]
        public void initialize()
        {
            testUser = new User();
            testUser.Username = testUsername;
            testUser.Password = testPassword;
            
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
        public void usernameTest()
        {
            Assert.AreEqual(testUsername, testUser.Username);
        }

        [TestMethod]
        public void passwordTest()
        {
            Assert.AreEqual(testPassword, testUser.Password);
        }
    }
}
