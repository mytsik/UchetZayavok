using Microsoft.EntityFrameworkCore.ChangeTracking;
using UchetZayavok.Entities.Base;

namespace UchetZayavok.Entities;

public class Faculty : BaseModel
{
    public string Name { get; set; } = string.Empty;
    public int EducationLevelId { get; set; }
    public virtual ObservableCollectionListSource<EnrolleeFaculty> EnrolleeFaculty { get; set; } = new();
}
