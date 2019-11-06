using System.ComponentModel.DataAnnotations;

namespace DotNextDemo.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}