using Microsoft.EntityFrameworkCore.ChangeTracking;
using UchetZayavok.Entities.Base;

namespace UchetZayavok.Entities;

public class SubjectEGE : BaseModel
{
    public string Name { get; set; } = string.Empty;
    public virtual ObservableCollectionListSource<EnrolleeEGE> EnrolleeEGE { get; set; } = new();
}
