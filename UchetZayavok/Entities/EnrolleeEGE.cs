using UchetZayavok.Entities.Base;

namespace UchetZayavok.Entities;

public class EnrolleeEGE : BaseModel
{
    public int EnrolleeId { get; set; }
    public int SubjectEGEId { get; set; }
}
