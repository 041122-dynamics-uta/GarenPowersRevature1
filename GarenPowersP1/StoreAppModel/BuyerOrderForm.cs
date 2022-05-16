namespace StoreAppModel
{
    public class BuyerOrderForm
    {
        public int BuyerOrderFormId { get; set; } = 0;
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public string ItemName { get; set; } = "";
        public string ItemDescription { get; set; } = "";
        public int ItemPrice { get; set; } = 0;
        public int StoreLocation { get; set; } = 0;
    }
}