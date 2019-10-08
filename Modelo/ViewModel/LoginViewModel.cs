using System.ComponentModel.DataAnnotations;

namespace Modelo.ViewModelo
{
    public class LoginViewModel
    {
        public string UrlRetorno { get; set; }

        [MaxLength(50)]
        [Display(Name = "Login")]
        [Required(ErrorMessage = "Informe o login do usuário", AllowEmptyStrings = false)]
        public string LoginUsuario { get; set; }

        [MaxLength(50)]
        [Required(ErrorMessage = "Informe a senha do usuário", AllowEmptyStrings = false)]
        [DataType(System.ComponentModel.DataAnnotations.DataType.Password)]
        public string Senha { get; set; }
    }
}
