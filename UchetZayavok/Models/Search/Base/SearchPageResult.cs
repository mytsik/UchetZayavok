namespace UchetZayavok.Models.Search.Base;

public class SearchPageResult<T>
{
    public List<T> Page { get; set; } = null!;
    public int Total { get; set; }
}