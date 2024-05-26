using BusinessLogicLayer.Class;

namespace DAL
{
    public interface IStockRepo1
    {
        void AddStock(int productId, int quantity);
        List<Stock> GetAllStock();
        Stock GetStockByProductId(int productId);
        void ReduceStock(int productId, int quantity);
    }
}