using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication3;
namespace BusinessLayer
{
    class BusinessClass5
    {
        public void Insert(Schedule sched)
        {
            var schedRepo = Service.RepoFactory.Create("Schedule");
            schedRepo.Insert(sched);
        }
        public void Delete (Schedule sched)
        {
            var schedRepo = Service.RepoFactory.Create("Schedule");
            schedRepo.Delete(sched);
        }
        public void Update(Schedule sched)
        {
            var schedRepo = Service.RepoFactory.Create("Schedule");
            schedRepo.Update(sched);
        }
        public IQueryable<Schedule> GetAll()
        {
            var schedRepo = Service.RepoFactory.Create("Contact");
            return (schedRepo.GetAll().OfType<Schedule>());
        }

    }
}
