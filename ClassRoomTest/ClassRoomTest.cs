using ClassRoomNet60;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assert = NUnit.Framework.Assert;

namespace ClassRoomTest
{
    public class ClassRoomTest
    {
        [TestCase("Mogens", 2, 12)]
        public void Create_Student(string name, int month, int day)
        {
            //Assign
            Student test = new Student(name, month, day);

            //Act


            //Assert
            Assert.That(test.Name.Equals(name));
        }
    }
}
