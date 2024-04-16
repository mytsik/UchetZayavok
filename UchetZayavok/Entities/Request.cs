using UchetZayavok.Entities.Base;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace UchetZayavok.Entities;

public class Request : BaseModel
{
    public int EnrolleeId { get; set; }
    public int ExecutorId { get; set; }
    public string Status { get; set; } = string.Empty;
    public string Comment { get; set; } = string.Empty;
    public DateTime Date { get; set; }
}
