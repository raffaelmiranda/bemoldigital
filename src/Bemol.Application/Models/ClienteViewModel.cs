using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Bemol.Application.Models
{
    public class ClienteViewModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Preencha o campo Nome")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Minimo {0} caracteres")]
        public string Nome { get; set; } = string.Empty;

        [Required(ErrorMessage = "Preencha o campo Cpf")]
        [MaxLength(11, ErrorMessage = "Máximo {0} caracteres")]
        [DisplayName("Cpf")]
        public string Cpf { get; set; } = string.Empty;

        [Required(ErrorMessage = "Preencha o campo Cep")]
        [MaxLength(9, ErrorMessage = "Máximo {0} caracteres")]
        [DisplayName("Cep")]
        public string Cep { get; set; } = string.Empty;

        [Required(ErrorMessage = "Preencha o campo Rual")]
        [MaxLength(100, ErrorMessage = "Máximo {0} caracteres")]
        [DisplayName("Rua")]
        public string Rua { get; set; } = string.Empty;

        [Required(ErrorMessage = "Preencha o campo E-mail")]
        [MaxLength(50, ErrorMessage = "Máximo {0} caracteres")]
        [EmailAddress(ErrorMessage = "Preencha um E-mail válido")]
        [DisplayName("E-mail")]
        public string Email { get; set; } = string.Empty;
    }
}
