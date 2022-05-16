using System.Data.SqlClient;
using StoreAppModel;
namespace StoreAppStorage
{
    public class Mapper
    {
        public Buyer DboToBuyer(SqlDataReader reader)
        {
            Buyer B1 = new Buyer
            {

                BuyerId = (int)reader[0],
                FirstName = (string)reader[1],
                LastName = (string)reader[2],
                Credentials = (string)reader[3],
                Email = (string)reader[4]
            };
            return B1;
        }
        public BuyerOrderForm DboToBuyerOrderForm(SqlDataReader reader)
        {
            BuyerOrderForm BOF1 = new BuyerOrderForm
            {
                BuyerOrderFormId = (int)reader[0],
                FirstName = (string)reader[1],
                LastName = (string)reader[2],
                ItemDescription = (string)reader[3],
                ItemPrice = (int)reader[4],
                StoreLocation = (int)reader[5]
            };
            return BOF1;
        }
        public BuyerOrderHistory DbotoBuyerOrderHistory(SqlDataReader reader)
        {
            BuyerOrderHistory BOH1 = new BuyerOrderHistory
            {
                BuyerOrderHistoryId = (int)reader[0],
                FirstName = (string)reader[1],
                LastName = (string)reader[2],
                ItemOrderList = (string)reader[3],
                ItemName = (string)reader[4],
                ItemPrice = (string)reader[5],
                StoreLocation = (int)reader[6]
            };
            return BOH1;
        }
        public StoreInventoryList DbotoStoreInventoryList(SqlDataReader reader)
        {
            StoreInventoryList SIL1 = new StoreInventoryList
            {
                StoreInventoryListId = (int)reader[0],
                ItemName = (string)reader[1],
                ItemDescription = (string)reader[2],
                ItemPrice = (int)reader[3]
            };
            return SIL1;
        }
        public StoreLocation DboToStoreLocation(SqlDataReader reader)
        {
            StoreLocation SL = new StoreLocation
            {
                StoreLocationId = (int)reader[0],
                City = (string)reader[1]
            };
            return SL;
        }
    }
}