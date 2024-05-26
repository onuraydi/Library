using Library.Library.Business.Abstract;
using Library.Library.DataAccess.Abstract;
using Library.Library.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Library.Business.Concrete
{
    public class StatusManager : IStatusService
    {
        private IStatusDal _statusDal;

        public StatusManager(IStatusDal statusDal)
        {
            _statusDal = statusDal;
        }

        public List<Status> GetAll()
        {
            return _statusDal.GetAll();
        }
    }
}
