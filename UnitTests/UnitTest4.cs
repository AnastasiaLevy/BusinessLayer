using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLayer;
using WebApplication3;
namespace UnitTests

{
    [TestClass]
    public class UnitTest4
    {
        [TestMethod]
        public void AddPerson()
        {
            Person p = new Person();
            p.FirstName = "I am ";
            p.LastName = "Soo Tired";

            BusinessClass1 bc = new BusinessClass1();
            bc.Insert(p);
        }
         [TestMethod]
        public void AddLab()
        {
            Lab l = new Lab();
            l.Id = 18;
            l.PersonId = 1023;
            l.ScheduleId = 3;

            BusinessClass2 bs = new BusinessClass2();
            bs.Insert(l);
        }

           
            
            

    }
}

