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

    public List<Buyer> MembersList()
    {
        List<Buyer> B1 = _repo.Buyer();
        return B1;
    }
}
