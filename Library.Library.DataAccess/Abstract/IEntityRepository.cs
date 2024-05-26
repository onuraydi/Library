using Library.Library.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Library.Library.DataAccess.Abstract
{
    public interface IEntityRepository<T> where T : class, IEntity, new()   // oluşacak nesne class, IEntity ve newlenebilir olmalı (Collection)
        // bu kullanım kodun yeniden kullanılabilirliğini arttırmak açısından önemlidir.
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);  // belirli bir koşulu sağlayan tüm öğeleri listeye döndürür.
        T Get(Expression<Func<T, bool>> filter);                // filtreden geçen yani koşul sağlanan ifadeleri getiren foksiyondur.Buradaki T çıkış değeridir

        void Add(T entity);  //ekleme
        void Update(T entity);  // güncelleme
        void Delete(T entity);  // silme
    }
}
