namespace StoreAppModel
{
    public class StoreInventoryList
    {
        public int StoreInventoryListId { get; set; } = 0;
        public string ItemName { get; set; } = "";
        public string ItemDescription { get; set; } = "";
        public int ItemPrice { get; set; } = 0;
        public string ItemQuantity { get; set; } = "";
    }
}