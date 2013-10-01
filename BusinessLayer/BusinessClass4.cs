using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication3;

namespace BusinessLayer
{
    class BusinessClass4
    {
        public void Insert(Grade gr)
        {
            var grRepo = Service.RepoFactory.Create("Grade");
            grRepo.Insert(gr);
        }
        public void Delete (Grade gr)
        {
            var grRepo = Service.RepoFactory.Create("Grade");
            grRepo.Delete(gr);
        }
        public void Update(Grade gr)
        {
            var grRepo = Service.RepoFactory.Create("Grade");
            grRepo.Update(gr);
        }
        public IQueryable<Grade> GetAll()
        {
            var grRepo = Service.RepoFactory.Create("Grade");
            return (grRepo.GetAll().OfType<Grade>());
        }
    }
}
