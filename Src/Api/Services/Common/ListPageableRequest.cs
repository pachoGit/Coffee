namespace Api.Services.Common
{
    public record ListPageableRequest(int PageSize = 10, int PageNumber = 1);
}
