using UchetZayavok.Entities.Base;

namespace UchetZayavok.Entities;

public class EnrolleeFaculty : BaseModel
{
    public int EnrolleeId { get; set; }
    public int FacultyId { get; set; }
}
