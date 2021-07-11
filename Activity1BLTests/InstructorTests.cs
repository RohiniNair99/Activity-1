using Microsoft.VisualStudio.TestTools.UnitTesting;
using Activity1BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity1BL.Tests
{
    [TestClass()]
    public class InstructorTests
    {
        string[] instructorSkill = new string[] { "C++", "C#", "Java", "JavaScript", "Python" };
        [TestMethod()]
        public void PValidateEligibilityTest()
        {
            Instructor obj = new Instructor("Rahul", 4.9f, 6, instructorSkill);
            bool expected = true;
            Assert.AreEqual(expected, obj.ValidateEligibility());
        }

        [TestMethod()]
        public void NValidateEligibilityTest()
        {
            Instructor obj = new Instructor("Rahul", 2.8f, 6, instructorSkill);
            bool expected = false;
            Assert.AreEqual(expected, obj.ValidateEligibility());
        }

        [TestMethod()]
        public void PCheckSkillTest()
        {
            Instructor obj = new Instructor("Rahul", 4.9f, 6, instructorSkill);
            bool expected = true;
            Assert.AreEqual(expected, obj.CheckSkill("PYTHON"));
        }

        [TestMethod()]
        public void NCheckSkillTest()
        {
            Instructor obj1 = new Instructor("Rahul", 4.9f, 6, instructorSkill);
            Instructor obj2 = new Instructor("Rahul", 2.4f, 6, instructorSkill);
            bool expected = false;
            Assert.AreEqual(expected, obj1.CheckSkill("Ruby"));
            Assert.AreEqual(expected, obj2.CheckSkill("Java"));

        }

        
    }
}