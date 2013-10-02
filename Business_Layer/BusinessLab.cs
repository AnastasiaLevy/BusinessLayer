using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication3;

namespace Business_Layer
{
    public class BusinessLab
    {
        public void Insert(Lab oLab)
        {
            var labRepo = Service.RepoFactory.Create("Lab");
            labRepo.Insert(oLab);
        }
        public void Delete(Lab oLab)
        {
            var labRepo = Service.RepoFactory.Create("Lab");
            labRepo.Delete(oLab);
        }
        public void Update(Lab oLab)
        {
            var labRepo = Service.RepoFactory.Create("Lab");
            labRepo.Update(oLab);
        }
        public IQueryable<Lab> GetAll()
        {
            var labRepo = Service.RepoFactory.Create("Lab");
            return (labRepo.GetAll().OfType<Lab>());
        }

    }
}
