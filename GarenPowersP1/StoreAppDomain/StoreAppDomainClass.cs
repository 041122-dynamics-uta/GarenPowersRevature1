using StoreAppStorage;
using StoreAppModel;
namespace StoreAppDomain;
public class StoreAppDomainClass
{
    public Repo _repo { get; set; }
    public StoreAppDomainClass(Repo R)
    {
        this._repo = R;
    }
    public List<Buyer> MembersList(string FirstName, string LastName, string Email, string Credentials)
    {
        List<Buyer> B1 = _repo.Buyer(FirstName, LastName, Email, Credentials);
        return B1;
    }
    public List<Buyer> UnamePwordExists(string ExistingEmail, string ExistingCredentials)
    {
        return null;

        bool existsornot = _repo.UnamePwordExists(ExistingEmail, ExistingCredentials);
        if (existsornot)
        {
            //return null;
        }
        else
        {
            //Buyer NewBuyer = MembersList ( FirstName, LastName, Credentials, Email );
            //return NewBuyer;
        }
    }
    public List<StoreLocation> MyStoreLocationsList()
    {
        List<StoreLocation> SL = _repo.StoreLocation();
        return SL;
    }
    public List<StoreInventoryList> StoreInventoryList()
    {
        List<StoreInventoryList> SIL = _repo.StoreInventoryList();
        return SIL;
    }
    public List<BuyerOrderForm> BuyerOrderForm()
    {
        List<BuyerOrderForm> BOF = _repo.BuyerOrderForm();
        return BOF;
    }
    public List<BuyerOrderHistory> BuyerOrderHistoryList()
    {
        List<BuyerOrderHistory> BOH1 = _repo.BuyerOrderHistory();
        return BOH1;
    }
}