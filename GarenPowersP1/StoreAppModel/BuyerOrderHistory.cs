namespace StoreAppModel
{
    public class BuyerOrderHistory
    {
        public int BuyerOrderHistoryId { get; set; } = 00;
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public string ItemOrderList { get; set; } = "";
        public string ItemName { get; set; } = "";
        public string ItemPrice { get; set; } = "";
        public int StoreLocation { get; set; } = 00;
    }
}