using VioletPOS.DataAccess.DAO;

namespace VioletPOS.DataAccess.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _applicationDbContext;


        public UnitOfWork(ApplicationDbContext applicationDbContext)
        {

            _applicationDbContext = applicationDbContext;
        }


        public void Dispose()
        {
            _applicationDbContext.Dispose();
        }

        public void Save()
        {
            _applicationDbContext.SaveChanges();
        }
    }

}
