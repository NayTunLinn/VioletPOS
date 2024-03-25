namespace VioletPOS.DataAccess.UnitOfWorks
{
    public interface IUnitOfWork : IDisposable
    {
        void Save();
    }
}