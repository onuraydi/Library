using Library.Library.Entities.Concrete;
using Library.Library.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Library.DataAccess.Abstract
{
    public interface IStatusDal : IEntityRepository<Status>
    {
        // Ientity kurallarına uygun status
    }
}
