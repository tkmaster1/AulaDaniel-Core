namespace ProjetoDanielEx.Core.WebApi.ViewModels.Responses
{
    public class ResponseSuccesso<T>
    {
        public bool Success { get; set; }

        public T Data { get; set; }
    }
}
