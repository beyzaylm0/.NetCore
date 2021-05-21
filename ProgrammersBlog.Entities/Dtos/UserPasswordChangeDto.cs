using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersBlog.Entities.Dtos
{
  public class UserPasswordChangeDto
    {
        [DisplayName("Şu Anki Şifreniz")]
        [Required(ErrorMessage = "{0} Boş Geçilemez.")]
        [MaxLength(300, ErrorMessage = "{0} {1} Karakterden Büyük Olamaz.")]
        [MinLength(5, ErrorMessage = "{0} {1} Karakterden Az Olamaz.")]
        [DataType(DataType.Password)]
        public string CurrentPassword { get; set; }
        [DisplayName("Yeni Şifreniz")]
        [Required(ErrorMessage = "{0} Boş Geçilemez.")]
        [MaxLength(300, ErrorMessage = "{0} {1} Karakterden Büyük Olamaz.")]
        [MinLength(5, ErrorMessage = "{0} {1} Karakterden Az Olamaz.")]
        [DataType(DataType.Password)]
        public string NewPassword { get; set; }
        [DisplayName("Yeni Şifrenin Tekrarı")]
        [Required(ErrorMessage = "{0} Boş Geçilemez.")]
        [MaxLength(300, ErrorMessage = "{0} {1} Karakterden Büyük Olamaz.")]
        [MinLength(5, ErrorMessage = "{0} {1} Karakterden Az Olamaz.")]
        [DataType(DataType.Password)]
        [Compare("NewPassword",ErrorMessage ="Yeni Şİfreniz ile Yeni Şifrenizin Tekrarı Aynı Olmalıdır!")]
        public string RepeatPassword { get; set; }
    }
}
