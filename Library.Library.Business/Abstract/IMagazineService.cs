using Library.Library.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Library.Business.Abstract
{
    public interface IMagazineService
    {
        void Add(Magazine magazine);
        void Update(Magazine magazine);
        void Delete(Magazine magazine);
        List<Magazine> GetAll();
        List<Magazine> GetMagazineByName(string MagazineName);
        List<Magazine> GetMagazineByCategory(string MagazineCategoy);
        List<Magazine> GetMagazineByIssue(string Issue);


    }
}
