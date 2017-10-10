using System.ComponentModel.DataAnnotations;

namespace CiderAndCode.Web.DataModels
{
    public class AppleFact
    {
        public int Id { get; set; }
        public AppleType Type { get; set; }
        [Required]
        public string Fact { get; set; }
    }
}