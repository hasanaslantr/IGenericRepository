
using System.Linq.Expressions;

namespace NLayer.Core.GenericRepositories
{
    public interface IGenericRepository<T> where T : class
    {

        #region IQueryable nedir, neden kullanırız?

        /*

         IQueryable arabirimi, genelikle veritabanı sorguları gibi büyük veri kümelerin de 
         Çalışırken daha etkili ve verimli sorgular oluşturmak için kullanılır.

         İhtiyaç duyulduğunda veritabanına gönderilir. Bu sayede sorguları optimize edebilir
         ve gereksiz veri transferini engelleyebiliriz.

         */

        #endregion

        #region Task nedir, neden kullanırız?

        /*
         Task, bir işin veya görevin asenkron olarak çalıştırılmasını temsil eder 
         ve bu görevin tamamlanmasını beklerken ana iş parçacığının (thread) bloke olmadan
         diğer işleri yapmasına olanak tanır.
         
         */

        #endregion
         
        IQueryable<T> GetAll();
        Task<T> GetByIdAsycn(int id);
        Task<T> GetByIdsAsync(int id1, int id2);
        IQueryable<T> Where(Expression<Func<T, bool>> filter);
        Task<bool> AnyAsycn(Expression<Func<T, bool>> filter);
        Task AddAsycn(T entity);

        Task AddRangeAsycn(IEnumerable<T> entities);
        void Update(T entity);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);

    }
}
