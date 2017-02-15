using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ex3._0;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3._0.Tests
{
    [TestClass()]
    public class StudentTests
    {
        [TestMethod()]
        public void StudentTest()
        {
            Student S = new Student("John Doe", "Testing for beginners", "Writing unittests", "UCN", "student@ucn.dk", "12345678");
            Assert.AreEqual("John Doe", S.FullName);
            Assert.AreEqual("Testing for beginners", S.Course);
            Assert.AreEqual("Writing unittests", S.Subject);
            Assert.AreEqual("UCN", S.University);
            Assert.AreEqual("student@ucn.dk", S.EMail);
            Assert.AreEqual("12345678", S.PhoneNumber);
        }

        [TestMethod()]
        public void StudentTest1()
        {
            Student S = new Student("John Doe", "UCN", "student@ucn.dk", "12345678");
            Assert.AreEqual("John Doe", S.FullName);
            Assert.AreEqual(null, S.Course);
            Assert.AreEqual(null, S.Subject);
            Assert.AreEqual("UCN", S.University);
            Assert.AreEqual("student@ucn.dk", S.EMail);
            Assert.AreEqual("12345678", S.PhoneNumber);
        }

        [TestMethod()]
        public void StudentTest2()
        {
            Student S = new Student( "John Doe", "UCN", "student@ucn.dk");
            Assert.AreEqual("John Doe", S.FullName);
            Assert.AreEqual(null, S.Course);
            Assert.AreEqual(null, S.Subject);
            Assert.AreEqual("UCN", S.University);
            Assert.AreEqual("student@ucn.dk", S.EMail);
            Assert.AreEqual(null, S.PhoneNumber);
        }

        [TestMethod()]
        public void DisplayStudentInformationTest()
        {
            Student S = new Student("John Doe", "Testing for beginners", "Writing unittests", "UCN", "student@ucn.dk", "12345678");
            S.DisplayStudentInformation();
        }
    }
}