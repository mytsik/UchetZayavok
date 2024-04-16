using UchetZayavok.Models.Search.Base;

namespace UchetZayavok.Models.Search;

public class SearchRequestFilter
{
    
}

public class SearchRequestModel : SearchCriteria
{
    public SearchRequestFilter Filter { get; set; } = null!;
}