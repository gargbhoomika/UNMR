using System.ComponentModel.DataAnnotations;

namespace UNMR.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}