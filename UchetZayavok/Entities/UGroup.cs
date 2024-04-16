using Microsoft.EntityFrameworkCore.ChangeTracking;
using UchetZayavok.Entities.Base;

namespace UchetZayavok.Entities;

public class UGroup : BaseModel
{
    public UGroup()
    {
    }

    public string Name { get; set; } = string.Empty;
    public virtual ObservableCollectionListSource<User> User { get; set; } = new();
}
