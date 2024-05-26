using Library.Library.Business.Abstract;
using Library.Library.Business.Utilities;
using Library.Library.Business.ValidationRules.FluentValidation;
using Library.Library.DataAccess.Abstract;
using Library.Library.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Library.Business.Concrete
{
    public class MagazineManager : IMagazineService
    {
        private IMagazineDal _magazineDal;
        public MagazineManager(IMagazineDal magazineDal)
        {
            _magazineDal = magazineDal;
        }

        public void Add(Magazine magazine)
        {
            ValidationTool.Validate(new MagazineValidator(), magazine);
            _magazineDal.Add(magazine);
        }

        public void Delete(Magazine magazine)
        {
            try
            {
                _magazineDal.Delete(magazine);
            }
            catch 
            {
                throw new Exception("Delete Failed!");
            }
        }

        public List<Magazine> GetAll()
        {
            return _magazineDal.GetAll();
        }

        public List<Magazine> GetMagazineByCategory(string MagazineCategoy)
        {
            return _magazineDal.GetAll(p => p.MagazineCategory == MagazineCategoy);
        }

        public List<Magazine> GetMagazineByIssue(string Issue)
        {
            return _magazineDal.GetAll(p => p.Issue == Issue);
        }

        public List<Magazine> GetMagazineByName(string MagazineName)
        {
            return _magazineDal.GetAll(p => p.MagazineName == MagazineName);
        }

        public void Update(Magazine magazine)
        {
            ValidationTool.Validate(new MagazineValidator(), magazine);
            _magazineDal.Update(magazine);
        }
    }
}
