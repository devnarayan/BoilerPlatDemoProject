using System.ComponentModel.DataAnnotations;

namespace demoProject.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}