using Microsoft.EntityFrameworkCore.ChangeTracking;
using UchetZayavok.Entities.Base;

namespace UchetZayavok.Entities;

public class Enrollee : BaseModel
{
    public int EducationLevelId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string PassportData { get; set; } = string.Empty;
    public string SNILS { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
    public string ParentName { get; set; } = string.Empty;
    public string GraduatedName { get; set; } = string.Empty;
    public double Points { get; set; }
    public int UserID { get; set; }
    public virtual IList<EnrolleeFaculty> EnrolleeFaculty { get; set; }
    public virtual IList<EnrolleeEGE> EnrolleeEGE { get; set; }
    public virtual IList<Request> Request { get; set; }

}
