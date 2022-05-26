using System.Data.SqlClient;
using StoreAppModel;

namespace StoreAppStorage;
public class Repo
{
    public Mapper _mapper { get; set; }
    string connectionstring = "Server=tcp:garenpowersserverp1.database.windows.net,1433;Initial Catalog=P1GarenPowersDB;Persist Security Info=False;User ID=GarenPowersDB;Password=Narita204863!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30";

    public bool UnamePwordExists(string ExistingEmail, string ExistingCredentials)
    {
        string query = "SELECT  * FROM Buyer WHERE Email Like 'unicornprincessloveu@gmail.com' And Credenials like 'WELIVEINATWILIGHTWORLD'";
        using (SqlConnection conn = new SqlConnection(connectionstring))
        {
            SqlCommand command = new SqlCommand(query, conn);
            //command.Parameters.AddWithValue("@F", FirstName);
            //command.Parameters.AddWithValue("@L", LastName);
            command.Parameters.AddWithValue("@C", ExistingCredentials);
            command.Parameters.AddWithValue("@E", ExistingEmail);
            conn.Open(); //open the connection to the DB
            SqlDataReader results = command.ExecuteReader(); //do the query
            conn.Close(); //close the connection to the DB
            if (results.Read())
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
    public Repo()
    {
        this._mapper = new Mapper();
    }
    public List<Buyer> Buyer(string FirstName, string LastName, string Credentials, string Email)
    {

        using (SqlConnection query1 = new SqlConnection(connectionstring))
        {
            string myQuery1 = "INSERT INTO Buyer ( FirstName, LastName, Credentials, Email ) VALUES ( @F, @L, @C, @E );";
            SqlCommand command = new SqlCommand(myQuery1, query1);
            command.Parameters.AddWithValue("@F", FirstName);
            command.Parameters.AddWithValue("@L", LastName);
            command.Parameters.AddWithValue("@C", Credentials);
            command.Parameters.AddWithValue("@E", Email);
            command.Connection.Open(); //open the connection to the DB
            SqlDataReader results = command.ExecuteReader(); //do the query

            List<Buyer> B1 = new List<Buyer>();
            while (results.Read())
            {
                B1.Add(this._mapper.DboToBuyer(results));
                //send in the row of the reader to be mapped.
            }
            query1.Close();
            return B1;
        }
    }
    public List<BuyerOrderForm> BuyerOrderForm()
    {
        string myQuery2 = "SELECT * FROM BuyerOrderForm";
        using (SqlConnection query2 = new SqlConnection(connectionstring))
        {
            SqlCommand command = new SqlCommand(myQuery2, query2);
            command.Connection.Open(); //open the connection to the DB
            SqlDataReader results = command.ExecuteReader(); //do the query

            List<BuyerOrderForm> BOF1 = new List<BuyerOrderForm>();
            while (results.Read())
            {
                BOF1.Add(this._mapper.DboToBuyerOrderForm(results));//send in the row of the reader to be mapped.
            }
            query2.Close();
            return BOF1;
        }
    }
    public List<BuyerOrderHistory> BuyerOrderHistory()
    {
        string myQuery3 = "SELECT * FROM BuyerOrderHistory";
        using (SqlConnection query3 = new SqlConnection(connectionstring))
        {
            SqlCommand command = new SqlCommand(myQuery3, query3);
            command.Connection.Open(); //open the connection to the DB
            SqlDataReader results = command.ExecuteReader(); //do the query

            List<BuyerOrderHistory> BOH1 = new List<BuyerOrderHistory>();
            while (results.Read())
            {
                BOH1.Add(this._mapper.DbotoBuyerOrderHistory(results));//send in the row of the reader to be mapped.
            }
            query3.Close();
            return BOH1;
        }


    }
    public List<StoreInventoryList> StoreInventoryList()
    {
        string myQuery4 = "SELECT * FROM StoreInventoryList";
        using (SqlConnection query4 = new SqlConnection(connectionstring))
        {
            SqlCommand command = new SqlCommand(myQuery4, query4);
            command.Connection.Open(); //open the connection to the DB
            SqlDataReader results = command.ExecuteReader(); //do the query

            List<StoreInventoryList> SIL1 = new List<StoreInventoryList>();
            while (results.Read())
            {
                SIL1.Add(this._mapper.DbotoStoreInventoryList(results));//send in the row of the reader to be mapped.
            }
            query4.Close();
            return SIL1;
        }

        // string myQuery5 = "SELECT * FROM StoreLocation";
        // using (SqlConnection query5 = new SqlConnection(connectionstring))
        // {
        //     SqlCommand command = new SqlCommand(myQuery5, query5);
        //     command.Connection.Open(); //open the connection to the DB
        //     SqlDataReader results = command.ExecuteReader(); //do the query

        //     List<StoreLocation> SL1 = new List<StoreLocation>();
        //     while (results.Read())
        //     {
        //         SL1.Add(this._mapper.DbotoStoreLocation(results));//send in the row of the reader to be mapped.
        //     }
        //     query5.Close();
        //     return SL1;
        // }
    }
    public List<StoreLocation> StoreLocation()
    {
        string myQuery5 = "SELECT * FROM StoreLocation";

        using (SqlConnection query5 = new SqlConnection(connectionstring))
        {
            SqlCommand command = new SqlCommand(myQuery5, query5);
            command.Connection.Open(); //open the connection to the DB
            SqlDataReader results = command.ExecuteReader(); //do the query

            List<StoreLocation> SL1 = new List<StoreLocation>();
            while (results.Read())
            {
                SL1.Add(this._mapper.DboToStoreLocation(results));//send in the row of the reader to be mapped.
            }
            query5.Close();
            return SL1;
        }
    }
}
