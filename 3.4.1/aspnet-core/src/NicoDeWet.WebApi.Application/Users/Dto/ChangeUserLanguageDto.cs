using System.ComponentModel.DataAnnotations;

namespace NicoDeWet.WebApi.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}