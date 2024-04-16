using Microsoft.EntityFrameworkCore.ChangeTracking;
using UchetZayavok.Entities.Base;

namespace UchetZayavok.Entities;

public class User : BaseModel
{
    public int GroupId { get; set; }
    public string Login { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public virtual UGroup Group { get; set; } = null!;
    public virtual ObservableCollectionListSource<Enrollee> Enrollee { get; set; } = new();
    public virtual ObservableCollectionListSource<Request> Request { get; set; } = new();

    public User()
    {

    }

    public User(int groupId, string login, string password) : this()
    {
        GroupId = groupId;
        Login = login;
        Password = password;
    }
}
