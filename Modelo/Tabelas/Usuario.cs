using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelo.Tabelas
{
    [Table("USUARIOS")]
    public class Usuario
    {
        public int UsuarioId { get; set; }

        [MaxLength(50)]
        [Display(Name = "Login")]
        [Required(ErrorMessage = "Informe o login do usuário", AllowEmptyStrings = false)]
        public string LoginUsuario { get; set; }

        [MaxLength(50)]
        [Display(Name = "Nome")]
        [Required(ErrorMessage = "Informe o nome do usuário", AllowEmptyStrings = false)]
        public string NomeUsuario { get; set; }

        [MaxLength(50)]
        [Display(Name = "Sobrenome")]
        [Required(ErrorMessage = "Informe o nome do usuário", AllowEmptyStrings = false)]
        public string SobrenomeUsuario { get; set; }

        [MaxLength(50)]
        [Required(ErrorMessage = "Informe a senha do usuário", AllowEmptyStrings = false)]
        [DataType(System.ComponentModel.DataAnnotations.DataType.Password)]
        public string Senha { get; set; }
    }
}
