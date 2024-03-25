using VioletPOS.Share.DataModels;

namespace VioletPOS.DataAccess.DAO
{
    public class CustomerDAL
    {
        ApplicationDbContext _dbContext;
        public CustomerDAL(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Insert(CustomerEntity customer)
        {
            _dbContext.Customers.Add(customer);
            _dbContext.SaveChanges();
        }
        public void Update(CustomerEntity customer)
        {
            _dbContext.Customers.Update(customer);
            _dbContext.SaveChanges();
        }

    }
}
