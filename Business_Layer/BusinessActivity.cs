using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication3;

namespace Business_Layer
{
    class BusinessActivity
    {
        public void Insert(Activity act)
        {
            var PersonRepo = Service.RepoFactory.Create("Activity");
            PersonRepo.Insert(act);
        }
        public void Delete(Activity act)
        {
            var PersonRepo = Service.RepoFactory.Create("Activity");
            PersonRepo.Delete(act);
        }
        public void Update (Activity act)
        {
            var PersonRepo = Service.RepoFactory.Create("Activity");
            PersonRepo.Update(act);
        }
        public IQueryable<Activity>GetAll()
        {
            var PersonRepo = Service.RepoFactory.Create("Activity");
            return (PersonRepo.GetAll().OfType<Activity>());
        }
        public IQueryable<Activity> GetByActivityName(string actName)
        {
            var PersonRepo = Service.RepoFactory.Create("Activity");
            return (PersonRepo.GetBySpecificKey("Activity", actName).OfType<Activity>());
        }

    }
}
