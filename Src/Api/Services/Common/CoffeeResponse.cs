namespace Api.Services.Common
{
    public class CoffeeResponse<T>
    {
        public String Message { get; set; } = String.Empty;

        public T Data { get; set; }

        public CoffeeResponse(T data, String message)
        {
            Data = data;
            Message = message;
        }
    }
}
