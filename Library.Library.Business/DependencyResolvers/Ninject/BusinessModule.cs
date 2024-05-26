using Library.Library.Business.Abstract;
using Library.Library.Business.Concrete;
using Library.Library.DataAccess.Abstract;
using Library.Library.DataAccess.Concrete.EntityFramework;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Library.Business.DependencyResolvers.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IBookService>().To<BookManager>().InSingletonScope();
            Bind<IBookDal>().To<EfBookDal>().InSingletonScope();

            Bind<IStatusService>().To<StatusManager>().InSingletonScope();
            Bind<IStatusDal>().To<EfStatusDal>().InSingletonScope();

            Bind<ICategoryService>().To<CategoryManager>().InSingletonScope();
            Bind<ICategoryDal>().To<EfCategoryDal>().InSingletonScope();

            Bind<IMagazineService>().To<MagazineManager>().InSingletonScope();
            Bind<IMagazineDal>().To<EfMagazineDal>().InSingletonScope();
        }
    }
}
