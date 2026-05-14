namespace Api.Services.Common
{
    public class CoffeeResponsePageable
    {
        public int Total { get; set; }

        public int PageSize { get; set; }

        public int PageNumer { get; set; }

        public int TotalPages { get; set; }
    }
}
