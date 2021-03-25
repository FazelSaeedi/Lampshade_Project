namespace InventoryManagement.Application.Contract.Inventory
{
    public class InventoryViewModel
    {
        public long Id { get; set; }
        public string ProductName { get; set; }
        public long ProductId { get; private set; }
        public double UnitPrice { get; private set; }
        public bool InStock { get; set; }
        public long CurrenctCount { get; set; }
    }
}