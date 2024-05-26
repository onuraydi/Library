using Library.Library.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Library.Business.Abstract
{
    public interface IStatusService
    {
        List<Status> GetAll();
    }
}
