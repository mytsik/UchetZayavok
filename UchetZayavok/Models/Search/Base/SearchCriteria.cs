namespace UchetZayavok.Models.Search.Base;

public class SearchCriteria
{
    public int PageIndex { get; set; } = 1;
    public int PageSize { get; set; } = 20;

    public int Skip => (PageIndex - 1) * PageSize;
    public int Take => PageSize;
}