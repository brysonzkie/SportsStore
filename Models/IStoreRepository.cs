namespace Bustamante_SportsStore.Models
{
    public interface IStoreRepository
    {
        IQueryable<Product> Products { get; }
        
    }
}
