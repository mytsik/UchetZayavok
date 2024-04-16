using Microsoft.EntityFrameworkCore.ChangeTracking;
using UchetZayavok.Entities.Base;

namespace UchetZayavok.Entities;

public class EducationLevel : BaseModel
{
    public string Name { get; set; } = string.Empty;
    public virtual ObservableCollectionListSource<Enrollee> Enrollee { get; set; } = new();
    public virtual ObservableCollectionListSource<Faculty> Faculty { get; set; } = new();
}
