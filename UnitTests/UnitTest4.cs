using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Business_Layer;
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

            BusinessPerson bc = new BusinessPerson();
            bc.Insert(p);
        }
         [TestMethod]
        public void AddLab()
        {
            Lab l = new Lab();
            l.Id = 18;
            l.PersonId = 1023;
            l.ScheduleId = 3;

            BusinessLab bs = new BusinessLab();
            bs.Insert(l);
        }
         
        [TestMethod]
        public void AddPicture()
        {
            Picture pic = new Picture();
            pic.Id = 8;
            pic.PersonId = 1033;
            pic.PictureFile = "file";

            BusinessPicture bp = new BusinessPicture();
            bp.Insert(pic);
        }
        



             
         }


           
            
            

    }


