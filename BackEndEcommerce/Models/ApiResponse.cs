namespace BackEndEcommerce.Models
{
    public class ApiResponses
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }
        public string ErrorCode { get; set; }
    }
}
