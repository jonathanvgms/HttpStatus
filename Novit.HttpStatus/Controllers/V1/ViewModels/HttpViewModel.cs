namespace Novit.HttpStatus.Controllers.V1.ViewModels
{
    public class HttpRequestViewModel
    {
        public int codigo { get; set; }
        public string nombre { get; set; }
        public string categoria { get; set; }
        public string referencia { get; set; } //URL hacia httpstatus.com
        public string imagen { get; set; }
    }
}
