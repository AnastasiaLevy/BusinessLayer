using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication3;


namespace Business_Layer
{
    public class BusinessPerson
    {
        public void Insert(Person oPerson)
        {
            var PersonRepo = Service.RepoFactory.Create("Person");
            PersonRepo.Insert(oPerson);
        }
        public void Delete(Person oPerson)
        {
            var PersonRepo = Service.RepoFactory.Create("Person");
            PersonRepo.Delete(oPerson);
        }
        public void Update(Person oPerson)
        {
            var PersonRepo = Service.RepoFactory.Create("Person");
            PersonRepo.Update(oPerson);
        }
        public IQueryable<Person> GetAll()
        {
            var PersonRepo = Service.RepoFactory.Create("Person");
            return (PersonRepo.GetAll().OfType<Person>());
        }
        public IQueryable<Person> GetByLastName(string lastName)
        {
            var PersonRepo = Service.RepoFactory.Create("Person");
            return (PersonRepo.GetBySpecificKey("LastName", lastName).OfType<Person>());
        }
        public IQueryable<Person>GetByLabNumber(string labId)
        {
            var PersonRepo = Service.RepoFactory.Create("Person");
            return (PersonRepo.GetBySpecificKey("labNumber",labId).OfType<Person>());
        }
    }
}


